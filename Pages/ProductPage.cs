using lab9_WebDriver.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Pages
{
    public class ProductPage
    {
        private Workspace _workspace;
        public ProductPage(Workspace workspace)
        {
            _workspace = workspace;
        }

        private IWebElement _likeCount => _workspace.findElementByXPath("//div[@class='n-item__icon ic-favorite']//span");
        private IWebElement _cartCount => _workspace.findElementByXPath("//div[@class='n-item__icon ic-cart']//span");

        public int? LikeCount => int.Parse(_likeCount.Text);
        public int? CartCount => int.Parse(_cartCount.Text);
        public void Like(string productId)
        {
            var likeElem = _workspace.findElementByXPath("//div[@data-product_id='" + productId + "']//div[@class='c-actions']//button[1]");
            likeElem.Click();                
        }
        public void AddToCart(string productId)
        {
            var cartElem = _workspace.findElementByXPath("//div[@data-product_id='" + productId + "']//div[@class='c-controls']//button[1]");
            cartElem.Click();
            _workspace.RefreshPage();
        }
        private void FindIcons()
        {

        }


    }
}
