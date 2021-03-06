﻿using AutomationTest.Framework;
using OpenQA.Selenium;

namespace AutomationTest.PageObject
{
    public class User : PageObjectBase
    {
        private static readonly By ByEmail = By.ClassName("form-control");
        private static readonly By ByPassword =
            By.XPath(
                "//div[@class='input-group js-parent-focus']//input[@class='form-control js-child-focus js-visible-password']");
        private static readonly By LoginButton = By.Id("submit-login");
        private static readonly By BySearch =
            By.XPath("//div[@id='search_widget']//form[@method='get']//input[@type='text']");
        private static readonly By SearchButton =
            By.XPath("//div[@id='search_widget']//form[@method='get']//i[@class='material-icons search']");
        private static readonly By SubmitButton =
            By.XPath("//div[@class='col-xs-12']//input[@class='btn btn-primary float-xs-right hidden-xs-down']");
        private static readonly By AllProductsButton = By.XPath("//*[@id='content']/section/a");
        public User(IWebDriver driver) : base(driver)
        {
        }
        public User LoginUser()
        {
            InputData(ByEmail, Settings.Email);
            InputData(ByPassword, Settings.Password);
            InputData(LoginButton);
            return this;
        }
        public User SearchWord(string word)
        {
            InputData(BySearch, word);
            InputData(SearchButton);
            return this;
        }
        public User SubmitNewsletter()
        {
            InputData(SubmitButton);
            return this;
        }
        public User OpenAllProducts()
        {
            InputData(AllProductsButton);
            return this;
        }
    }
}