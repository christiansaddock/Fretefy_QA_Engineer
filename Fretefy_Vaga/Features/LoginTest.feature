Feature: Teste de Login no TestFire
  Verifica se o login � realizado corretamente.

  Scenario: Login com sucesso
    Given que o usu�rio est� na p�gina de login
    When o usu�rio faz login com "admin" e "admin"
    Then o sistema deve exibir a mensagem "Hello Admin User"

  Scenario: Login com falha
    Given que o usu�rio est� na p�gina de login
    When o usu�rio faz login com "admin" e "wrong_password"
    Then o sistema deve exibir a mensagem de erro "Login Failed: We're sorry, but this username or password was not found in our system. Please try again."
