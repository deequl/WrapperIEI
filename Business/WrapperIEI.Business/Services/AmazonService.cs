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
using System.Windows.Forms;
using WrapperIEI.DTO;
using WrapperIEI.Business.Helpers;

namespace WrapperIEI.Business.Services
{
    public class AmazonService
    {
        static IWebDriver driver = new ChromeDriver();
        string author, price, title, discount;
        double priceAmount, discountAmount;
        List<LibroDTO> books = new List<LibroDTO>();


        public void Init()
        {
            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            //driver.Navigate().GoToUrl("https://www.amazon.es/comprar-libros-espa%C3%B1ol/b/ref=nav_shopall_abks?ie=UTF8&node=599364031");
            driver.Navigate().GoToUrl("https://www.amazon.es");

            // Find the text input element by its name
            IWebElement query = driver.FindElement(By.Id("twotabsearchtextbox"));

            // Enter something to search for
            query.SendKeys("corsair keyboard");

            IWebElement searchButton = driver.FindElement(By.ClassName("nav-input"));
            searchButton.Click();


            Wait.WaitUntilElementExists(By.Id("atfResults"), driver);
            IWebElement resultadosBusqueda = driver.FindElement(By.Id("atfResults"));
            IReadOnlyCollection<IWebElement> libros = resultadosBusqueda.FindElements(By.TagName("li"));
            foreach (IWebElement libro in libros)
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
                    continue;
                    //title = null;
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





                Console.WriteLine((!String.IsNullOrEmpty(title)) ? title : "No title");
                Console.WriteLine((!String.IsNullOrEmpty(author)) ? author : "No author");

                if (!String.IsNullOrEmpty(price))
                {
                    priceAmount = Double.Parse(price.Split(' ').Last());
                }

                if (!String.IsNullOrEmpty(discount))
                {
                    discountAmount = Double.Parse(discount.Split(' ').Last());
                }

                LibroDTO libroSave = new LibroDTO
                {

                    Title = ((!String.IsNullOrEmpty(title)) ? title : "No title"),
                    Author = ((!String.IsNullOrEmpty(author)) ? author : "No author"),
                    Price = priceAmount,
                    Discount = discountAmount
                };

                books.Add(libroSave);




            }
        }
    }
}
