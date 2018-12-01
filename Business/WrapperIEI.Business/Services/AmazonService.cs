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
        string author, price, title, discount;
        double priceAmount, discountAmount;
        List<BookDTO> books = new List<BookDTO>();
        IWebDriver driver;
        IWebElement query, searchButton, resultadosBusqueda;
        IReadOnlyCollection<IWebElement> booksWrapper;


        public AmazonService( IWebDriver driver ) {
            this.driver = driver;
        }

        public void Init(string searchText, string url = "https://www.amazon.es")
        {

            //look for the books wrapper
            booksWrapper = SearchItemsWrapper(searchText, url);

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

        private void PrintBooks()
        {
            Console.WriteLine(" ------ BOOKS ------ ");
            foreach (BookDTO book in books)
            {
                Console.WriteLine("------------");
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Price);
                Console.WriteLine(book.Discount);
                Console.WriteLine("------------");
            }
        }

        public IReadOnlyCollection<IWebElement> SearchItemsWrapper(string searchText, string url)
        {
            //driver.Navigate().GoToUrl("https://www.amazon.es/comprar-libros-espa%C3%B1ol/b/ref=nav_shopall_abks?ie=UTF8&node=599364031");
            driver.Navigate().GoToUrl(url);

            query = driver.FindElement(By.Id("twotabsearchtextbox"));

            // Text to search
            query.SendKeys(searchText);

            searchButton = driver.FindElement(By.ClassName("nav-input"));
            searchButton.Click();


            Wait.WaitUntilElementExists(By.Id("atfResults"), driver);

            resultadosBusqueda = driver.FindElement(By.Id("atfResults"));
            return booksWrapper = resultadosBusqueda.FindElements(By.TagName("li"));
        }

        public List<BookDTO> GetList()
        {
            return books;
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
