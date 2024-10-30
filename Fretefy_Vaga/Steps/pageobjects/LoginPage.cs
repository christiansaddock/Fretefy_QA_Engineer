using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement UsernameField => _driver.FindElement(By.Name("uid"));
    private IWebElement PasswordField => _driver.FindElement(By.Name("passw"));
    private IWebElement LoginButton => _driver.FindElement(By.Name("btnSubmit"));
    private IWebElement LoginMessage => _driver.FindElement(By.Id("loginMessage"));
    private IWebElement ErrorMessage => _driver.FindElement(By.Id("_ctl0__ctl0_Content_Main_message"));

    public void NavigateToLoginPage()
    {
        _driver.Navigate().GoToUrl("https://demo.testfire.net/login.jsp");
    }

    public void EnterCredentials(string username, string password)
    {
        UsernameField.SendKeys(username);
        PasswordField.SendKeys(password);
    }

    public void ClickLoginButton()
    {
        LoginButton.Click();
    }

    public string GetLoginMessage() => LoginMessage.Text;

    public string GetErrorMessage() => ErrorMessage.Text;
}
