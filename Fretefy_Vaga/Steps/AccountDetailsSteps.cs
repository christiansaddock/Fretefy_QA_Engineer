using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using Selenium_Driver.WrapperFactory;

[Binding]
public class AccountDetailsSteps
{
    private readonly IWebDriver _driver;
    private readonly LoginPage _loginPage;
    private readonly AccountDetailsPage _accountDetailsPage;

    public AccountDetailsSteps()
    {
        _driver = DriverStepsFactory.CreateDriver();
        _loginPage = new LoginPage(_driver);
        _accountDetailsPage = new AccountDetailsPage(_driver);
    }

    [Given(@"que o usuário está logado no sistema")]
    public void DadoQueOUsuarioEstaLogadoNoSistema()
    {
        _loginPage.NavigateToLoginPage();
        _loginPage.EnterCredentials("admin", "admin");
        _loginPage.ClickLoginButton();
    }

    [When(@"o usuário navega até ""(.*)""")]
    public void QuandoOUsuarioNavegaPara(string linkText)
    {
        _accountDetailsPage.NavigateToAccountDetails();
    }

    [When(@"seleciona ""(.*)"" na caixa de seleção")]
    public void QuandoOUsuarioSelecionaNaCaixaDeSelecao(string accountName)
    {
        _accountDetailsPage.SelectAccount(accountName);
    }

    [Then(@"o sistema deve exibir detalhes da conta ""(.*)""")]
    public void EntaoOSistemaDeveExibirDetalhesDaConta(string contaEsperada)
    {
        var detalhes = _accountDetailsPage.GetAccountDetails();
        detalhes.Should().Contain(contaEsperada);
    }
}
