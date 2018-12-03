using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrapperIEI.DTO;
using WrapperIEI.Business.Helpers;

namespace WrapperIEI.Business.Services
{
    public class AmazonService : IWrapperService<BookDTO>
    {
        string _authorBook;
        string author, price, title, discount;
        double priceAmount, discountAmount;
        List<BookDTO> books = new List<BookDTO>();
        IWebDriver driver;
        IWebElement query, searchButton, resultadosBusqueda;
        IReadOnlyCollection<IWebElement> booksWrapper;


        public AmazonService( IWebDriver driver ) {
            this.driver = driver;
        }

        public void Init(string searchText, string authorBook = null, string url = "https://www.amazon.es/s/url=search-alias%3Dstripbooks&field-keywords=")
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

        }

        #region Methods

        public IReadOnlyCollection<IWebElement> SearchItemsWrapper(string searchText, string url)
        {
            url += searchText;
            driver.Navigate().GoToUrl(url);
            try
            {
                resultadosBusqueda = driver.FindElement(By.Id("atfResults"));
            }

            catch (Exception)
            {
                throw new NoResultsException("No se han encontrado resultados");
            }
            
            return booksWrapper = resultadosBusqueda.FindElements(By.TagName("li"));
        }

        public List<BookDTO> GetList()
        {
            return (!String.IsNullOrEmpty(_authorBook)) ? books.Where(x => x.Author.ToLower().Contains(_authorBook.ToLower())).ToList() : books;
        }

        public void SetItemProperties(IWebElement item)
        {
            try
            {
                author = item.FindElement(By.ClassName("a-col-right")).FindElement(By.XPath("div[1]/div[2]/span[2]")).Text;
            }

            catch (Exception)
            {
                author = null;
            }

            try
            {
                title = item.FindElement(By.TagName("h2")).Text;
            }
            catch (Exception)
            {

                title = null;
            }

            try
            {
                price = item.FindElement(By.ClassName("s-price")).Text;
            }
            catch (Exception)
            {
                price = null;
            }

            try
            {
                discount = item.FindElement(By.ClassName("a-text-strike")).Text;
            }
            catch (Exception)
            {
                discount = null;
            }

            if (!String.IsNullOrEmpty(price))
            {
                priceAmount = (price=="GRATIS") ? 0 : Double.Parse(price.Split(' ').Last(), System.Globalization.CultureInfo.CurrentCulture);
            }

            if (!String.IsNullOrEmpty(discount))
            {
                discountAmount = Double.Parse(discount.Split(' ').Last(), System.Globalization.CultureInfo.CurrentCulture);

                discount = Math.Round((100 - ((discountAmount * 100) / priceAmount)),2).ToString();


            }
        }

        public void StoreItem()
        {
            BookDTO libroSave = new BookDTO
            {
                Provider = Constants.AMAZON,
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
