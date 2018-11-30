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
    public class AmazonService
    {

        string author, price, title, discount;
        double priceAmount, discountAmount;
        List<LibroDTO> books = new List<LibroDTO>();
        IWebDriver driver;
        IWebElement query, searchButton, resultadosBusqueda;
        IReadOnlyCollection<IWebElement> libros;


        public AmazonService( IWebDriver driver ) {
            this.driver = driver;
        }

        public void Init()
        {
            string searchText = "corsair keyboard";
            string url = "https://www.amazon.es";

            SearchElement(searchText, url);

            foreach (IWebElement libro in libros)
            {

                SetBookProperties(libro);
                StoreBook();

            }


            //// This is only for testing
            //PrintBooks();
            
        }

        #region Methods

        private void SearchElement(string searchText, string url)
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
            libros = resultadosBusqueda.FindElements(By.TagName("li"));

        }

        private void SetBookProperties(IWebElement libro)
        {
            try
            {
                author = libro.FindElement(By.ClassName("a-col-right")).FindElement(By.XPath("div[1]/div[2]/span[2]")).Text;
            }

            catch (Exception)
            {
                author = null;
            }

            try
            {
                title = libro.FindElement(By.TagName("h2")).Text;
            }
            catch (Exception)
            {

                title = null;
            }

            try
            {
                price = libro.FindElement(By.ClassName("s-price")).Text;
            }
            catch (Exception)
            {
                price = null;
            }

            try
            {
                discount = libro.FindElement(By.ClassName("a-text-strike")).Text;
            }
            catch (Exception)
            {
                discount = null;
            }

            if (!String.IsNullOrEmpty(price))
            {
                priceAmount = Double.Parse(price.Split(' ').Last());
            }

            if (!String.IsNullOrEmpty(discount))
            {
                discountAmount = Double.Parse(discount.Split(' ').Last());
            }


        }

        private void StoreBook()
        {
            LibroDTO libroSave = new LibroDTO
            {
                Provider = "Amazon",
                Title = ((!String.IsNullOrEmpty(title)) ? title : "No title"),
                Author = ((!String.IsNullOrEmpty(author)) ? author : "No author"),
                Price = priceAmount,
                Discount = discountAmount
            };

            books.Add(libroSave);
        }

        private void PrintBooks()
        {
            Console.WriteLine(" ------ BOOKS ------ ");
            foreach (LibroDTO book in books)
            {
                Console.WriteLine("------------");
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Price);
                Console.WriteLine(book.Discount);
                Console.WriteLine("------------");
            }
        }

        #endregion
    }
}
