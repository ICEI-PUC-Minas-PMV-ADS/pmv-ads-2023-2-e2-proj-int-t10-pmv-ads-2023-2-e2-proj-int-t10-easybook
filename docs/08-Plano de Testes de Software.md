# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

| Caso de Teste   | CT-01 – Cadastro de Perfil                                   |
|------------------|--------------------------------------------------------------|
| Requisito       | RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste | Verificar se o usuário consegue se cadastrar na aplicação de forma intuitiva e sem problemas significativos. |
| Passos          | 1. Acesse o navegador.                                       |
|                  | 2. Informe o endereço do site: https://www.easybooking.com |
|                  | 3. Na página principal, clique no botão "Criar conta" ou equivalente. |
|                  | 4. Preencha os seguintes campos obrigatórios:               |
|                  |    - E-mail                                                   |
|                  |    - Nome                                                     |
|                  |    - Sobrenome                                                |
|                  |    - Celular                                                  |
|                  |    - CPF                                                      |
|                  |    - Senha                                                    |
|                  |    - Confirmação de senha                                     |
|                  | 5. Marque a caixa de seleção para aceitar os termos de uso, se aplicável. |
|                  | 6. Clique no botão "Registrar" ou equivalente.              |
| Critério de Êxito | O cadastro foi realizado com sucesso, e o usuário é redirecionado para a próxima etapa ou para sua área de perfil. |
| Observações      | - Certifique-se de fornecer dados de teste válidos (por exemplo, um endereço de e-mail temporário e informações fictícias) durante o teste. |
|                  | - Avalie a clareza das mensagens de erro, caso ocorra um problema durante o cadastro. |
|                  | - Registre o tempo necessário para concluir o processo de cadastro. |
|                  | - Observe se o site fornece confirmação por e-mail ou outra forma de verificação. |
|                  | - Avalie a facilidade de uso e a intuição do fluxo de cadastro. |

| Caso de Teste   | CT-02 – Efetuar Login                                    |
|------------------|---------------------------------------------------------|
| Requisito       | RF-00Y - A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste | Verificar se o usuário consegue realizar login de forma eficiente e sem problemas significativos. |
| Passos          | 1. Acesse o navegador.                                    |
|                  | 2. Informe o endereço do site: https://www.easybooking.com |
|                  | 3. Na página principal, clique no botão "Entrar" ou equivalente. |
|                  | 4. Preencha o campo de e-mail com um endereço de e-mail válido. |
|                  | 5. Preencha o campo de senha com a senha correta.          |
|                  | 6. Clique no botão "Login" ou equivalente.                |
| Critério de Êxito | O login foi realizado com sucesso, e o usuário é redirecionado para sua área de perfil ou uma página de destino apropriada. |
| Observações      | - Certifique-se de fornecer dados de teste válidos para o campo de e-mail e senha. |
|                  | - Avalie a clareza das mensagens de erro, caso ocorra um erro durante o login. |
|                  | - Registre o tempo necessário para concluir o processo de login. |
|                  | - Verifique se o site fornece recuperação de senha, caso o login falhe devido a senha incorreta. |
|                  | - Avalie a facilidade de uso e a intuição do processo de login. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
