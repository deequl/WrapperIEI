using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WrapperIEI.Business.Services
{
    public interface IWrapperService<T>
    {
        /// <summary>
        /// Returns the wrapper where the items to look for are
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        IReadOnlyCollection<IWebElement> SearchItemsWrapper(string searchText, string url);


        /// <summary>
        /// Returns a list with the searched items
        /// </summary>
        /// <returns></returns>
        List<T> GetList();

        /// <summary>
        /// Sets the properties of an item into the local variables
        /// </summary>
        /// <param name="item">One element with the properties that you want to obtain</param>
        void SetItemProperties(IWebElement item);

        /// <summary>
        /// Store one item into a list
        /// </summary>
        void StoreItem();

    }
}
