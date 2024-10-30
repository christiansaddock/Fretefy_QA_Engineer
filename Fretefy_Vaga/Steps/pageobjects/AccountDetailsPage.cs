using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class AccountDetailsPage
{
    private readonly IWebDriver _driver;

    public AccountDetailsPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement AccountDropdown => _driver.FindElement(By.Name("listAccounts"));
    private IWebElement AccountDetailsLabel => _driver.FindElement(By.Id("lblAccDetails"));

    public void NavigateToAccountDetails()
    {
        _driver.FindElement(By.LinkText("View Account Details")).Click();
    }

    public void SelectAccount(string accountName)
    {
        var selectElement = new SelectElement(AccountDropdown);
        selectElement.SelectByText(accountName);
    }

    public string GetAccountDetails() => AccountDetailsLabel.Text;
}
