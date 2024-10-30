Feature: Sele��o de contas no View Account Details
  Verifica se o usu�rio consegue visualizar as informa��es corretas para cada conta.

  Scenario: Selecionar "800000 Corporate"
    Given que o usu�rio est� logado no sistema
    When o usu�rio navega at� "View Account Details"
    And seleciona "800000 Corporate" na caixa de sele��o
    Then o sistema deve exibir detalhes da conta "800000 Corporate"

  Scenario: Selecionar "800001 Checking"
    Given que o usu�rio est� logado no sistema
    When o usu�rio navega at� "View Account Details"
    And seleciona "800001 Checking" na caixa de sele��o
    Then o sistema deve exibir detalhes da conta "800001 Checking"
