using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using WrapperIEI.DTO;

namespace WrapperIEI.Business.Services
{
    public class ElCorteInglesService : IWrapperService<BookDTO>
    {
        string _authorBook;
        string author, price, title, discount;
        double priceAmount, discountAmount;
        List<BookDTO> books = new List<BookDTO>();
        IWebDriver driver;
        IWebElement query, searchButton, resultadosBusqueda;
        IReadOnlyCollection<IWebElement> booksWrapper;


        public ElCorteInglesService(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Init(string searchText, string authorBook = null, string url = "https://www.elcorteingles.es/libros/search/?s=")
        {
            _authorBook = authorBook;

            //look for the books wrapper
            if ((!String.IsNullOrEmpty(searchText) && String.IsNullOrEmpty(authorBook)) ||
                (!String.IsNullOrEmpty(searchText) && !String.IsNullOrEmpty(authorBook)))
            {
                booksWrapper = SearchItemsWrapper(searchText, url);
            }
            else
            {
                booksWrapper = SearchItemsWrapper(authorBook, url);
            }

            //Store each book into a list
            foreach (IWebElement book in booksWrapper)
            {

                SetItemProperties(book);
                StoreItem();

            }


            // This is only for testing
            //PrintBooks();

        }

        #region Methods

        public List<BookDTO> GetList()
        {
            return (!String.IsNullOrEmpty(_authorBook)) ? books.Where(x => x.Author.ToLower().Contains(_authorBook.ToLower())).ToList() : books;
        }

        public IReadOnlyCollection<IWebElement> SearchItemsWrapper(string searchText, string url)
        {
            url = url + searchText;
            driver.Navigate().GoToUrl(url);
            resultadosBusqueda = driver.FindElement(By.ClassName("product-list"));
            return booksWrapper = resultadosBusqueda.FindElements(By.TagName("li"));
        }

        public void SetItemProperties(IWebElement item)
        {
            try
            {
                author = item.FindElement(By.ClassName("product-name")).FindElement(By.ClassName("brand")).Text;
            }

            catch (Exception)
            {
                author = null;
            }

            try
            {
                title = item.FindElement(By.ClassName("product-name")).FindElement(By.ClassName("info-name")).Text;
            }
            catch (Exception)
            {

                title = null;
            }

            try
            {
                price = item.FindElement(By.ClassName("product-price")).FindElement(By.ClassName("current")).Text;
            }
            catch (Exception)
            {
                price = null;
            }

            try
            {
                discount = item.FindElement(By.ClassName("product-price")).FindElement(By.ClassName("former")).Text;
            }
            catch (Exception)
            {
                discount = null;
            }

            if (!String.IsNullOrEmpty(price))
            {
                priceAmount = (price == "GRATIS") ? 0 : Double.Parse(price.Split('€').First(), System.Globalization.CultureInfo.CurrentCulture);
            }

            if (!String.IsNullOrEmpty(discount))
            {
                discountAmount = Double.Parse(discount.Split('€').First(), System.Globalization.CultureInfo.CurrentCulture);

                discount = Math.Round((100 - ((discountAmount * 100) / priceAmount)), 2).ToString();


            }


        }

        public void StoreItem()
        {
            BookDTO libroSave = new BookDTO
            {
                Provider = Constants.EL_CORTE_INGLES,
                Title = ((!String.IsNullOrEmpty(title)) ? title : "No title"),
                Author = ((!String.IsNullOrEmpty(author)) ? author : "No author"),
                Price = priceAmount,
                Discount = discount
            };

            books.Add(libroSave);
        }

        #endregion
    }
}
