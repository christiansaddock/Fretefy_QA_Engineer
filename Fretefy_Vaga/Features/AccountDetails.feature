Feature: Seleção de contas no View Account Details
  Verifica se o usuário consegue visualizar as informações corretas para cada conta.

  Scenario: Selecionar "800000 Corporate"
    Given que o usuário está logado no sistema
    When o usuário navega até "View Account Details"
    And seleciona "800000 Corporate" na caixa de seleção
    Then o sistema deve exibir detalhes da conta "800000 Corporate"

  Scenario: Selecionar "800001 Checking"
    Given que o usuário está logado no sistema
    When o usuário navega até "View Account Details"
    And seleciona "800001 Checking" na caixa de seleção
    Then o sistema deve exibir detalhes da conta "800001 Checking"
