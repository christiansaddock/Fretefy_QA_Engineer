using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using Selenium_Driver.WrapperFactory;

[Binding]
public class LoginTestSteps
{
    private readonly IWebDriver _driver;
    private readonly LoginPage _loginPage;

    public LoginTestSteps()
    {
        _driver = DriverStepsFactory.CreateDriver();
        _loginPage = new LoginPage(_driver);
    }

    [Given(@"que o usuário está na página de login")]
    public void DadoQueOUsuarioEstaNaPaginaDeLogin()
    {
        _loginPage.NavigateToLoginPage();
    }

    [When(@"o usuário faz login com ""(.*)"" e ""(.*)""")]
    public void QuandoOUsuarioFazLoginCom(string username, string password)
    {
        _loginPage.EnterCredentials(username, password);
        _loginPage.ClickLoginButton();
    }

    [Then(@"o sistema deve exibir a mensagem ""(.*)""")]
    public void EntaoOSistemaDeveExibirAMensagem(string mensagemEsperada)
    {
        var mensagemAtual = _loginPage.GetLoginMessage();
        mensagemAtual.Should().Contain(mensagemEsperada);
    }

    [Then(@"o sistema deve exibir a mensagem de erro ""(.*)""")]
    public void EntaoOSistemaDeveExibirAMensagemDeErro(string mensagemErroEsperada)
    {
        var mensagemErroAtual = _loginPage.GetErrorMessage();
        mensagemErroAtual.Should().Contain(mensagemErroEsperada);
    }
}
