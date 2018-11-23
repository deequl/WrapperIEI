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

namespace WrapperIEI
{
    public partial class WrapperIEI : Form
    {
        public WrapperIEI()
        {
            InitializeComponent();
            Chrome();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Chrome() {
            using (IWebDriver driver = new ChromeDriver())
            {
                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("https://www.amazon.es/comprar-libros-espa%C3%B1ol/b/ref=nav_shopall_abks?ie=UTF8&node=599364031");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Id("twotabsearchtextbox"));

                // Enter something to search for
                query.SendKeys("Harry Potter");

                IWebElement resultadosBusqueda = driver.FindElement(By.Id(""));
                IReadOnlyCollection<IWebElement> libros = resultadosBusqueda.FindElements(By.TagName("li"));
                foreach(IWebElement libro in libros)
                {
                    Console.WriteLine(libro);
                }

                // Now submit the form. WebDriver will find the form for us from the element
                query.Submit();

                // Google's search is rendered dynamically with JavaScript.
                // Wait for the page to load, timeout after 10 seconds
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(d => d.Title.StartsWith("Harry Potter", StringComparison.OrdinalIgnoreCase));


            }
        }
    }
}
