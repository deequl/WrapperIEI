using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using WrapperIEI.DTO;

namespace WrapperIEI.Business.Services
{
    public class ElCorteInglesService : IWrapperService<BookDTO>
    {

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

        public List<BookDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<IWebElement> SearchItemsWrapper(string searchText, string url)
        {
            throw new NotImplementedException();
        }

        public void SetItemProperties(IWebElement item)
        {
            throw new NotImplementedException();
        }

        public void StoreItem()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
