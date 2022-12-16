using lab9_WebDriver.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Pages
{
    public class MainPage
    {
        private Workspace _workspace;
        public MainPage(Workspace workspace)
        {
            _workspace = workspace;
        }

        private IWebElement _discounts => _workspace.findElementByXPath("//a[@class='nav-item h-discounts']");
        private IWebElement _sales => _workspace.findElementByXPath("//img[@title='Скидки']");
        private IWebElement _televisions => _workspace.findElementByXPath("//a[@href='/catalog/13-televizory-i-video']");


        public void OpenDiscounts()
        {
            _discounts.Click();
        }
        public void OpenSales()
        {
            _sales.Click();
        }
        public void OpenTelevisions()
        {
            _televisions.Click();
        }
    }
}
