# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>
| Caso de Teste   | CT-01 – Efetuar Login                                    |
|------------------|---------------------------------------------------------|
| Requisito       | RF-01 - O site deve permitir que os usuários faça o login. |
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

| Caso de Teste   | CT-02 – Cadastro de Perfil                                   |
|------------------|--------------------------------------------------------------|
| Requisito       | RF-02 - O site deve permitir que os usuários se cadastrem. |
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

| Caso de Teste   | CT-03 – Visualização do Sistema de Reserva                 |
|------------------|-----------------------------------------------------------|
| Requisito       | RF-03 - O site deve permitir que os usuários visualizem o sistema de reserva. |
| Objetivo do Teste | Verificar se os usuários conseguem acessar e visualizar o sistema de reserva de forma eficiente e intuitiva. |
| Passos          | 1. Acesse o navegador.                                     |
|                  | 2. Vá para a página inicial do site: https://www.easybooking.com. |
|                  | 3. Efetue o login na aplicação usando suas credenciais de usuário. |
|                  | 4. Navegue até a seção "Sistema de Reserva" ou equivalente. |
|                  | 5. Observe e interaja com as opções de reserva disponíveis, como datas, horários e tipos de ambientes. |
|                  | 6. Tente realizar uma consulta ou pesquisa para encontrar disponibilidade de reservas específicas, se aplicável. |
|                  | 7. Verifique se as informações sobre a disponibilidade são apresentadas de forma clara e precisa. |
|                  | 8. Selecione uma data e horário para uma reserva hipotética. |
|                  | 9. Confirme se é possível prosseguir com a reserva ou obter mais detalhes sobre a mesma. |
| Critério de Êxito | Os usuários conseguem acessar e visualizar o sistema de reserva de forma eficiente, as informações sobre disponibilidade são precisas, e o processo de reserva é intuitivo. |
| Observações      | - Certifique-se de que o sistema de reserva seja acessível apenas para usuários autenticados. |
|                  | - Avalie a clareza das informações apresentadas, a navegabilidade e a eficácia do sistema de reserva. |
|                  | - Registre o tempo necessário para encontrar informações e realizar ações relacionadas à reserva. |
|                  | - Observe como os usuários interagem com as opções e quaisquer desafios ou problemas encontrados. |

| Caso de Teste   | CT-04 – Reserva de Ambientes de Testes                      |
|------------------|------------------------------------------------------------|
| Requisito       | RF-04 - O sistema deve permitir que os usuários reservem ambientes de testes. |
| Objetivo do Teste | Verificar se os usuários podem efetuar reservas de ambientes de testes de forma eficiente e sem problemas significativos. |
| Passos          | 1. Acesse o navegador.                                      |
|                  | 2. Vá para a página inicial do site: https://www.easybooking.com |
|                  | 3. Efetue o login na aplicação usando suas credenciais de usuário. |
|                  | 4. Navegue até a seção "Reservar Ambiente de Teste" ou equivalente. |
|                  | 5. Selecione o tipo de ambiente de teste que deseja reservar (se houver opções). |
|                  | 6. Escolha a data e horário desejados para a reserva.        |
|                  | 7. Verifique se há disponibilidade para o ambiente e horário selecionados. |
|                  | 8. Preencha quaisquer informações adicionais necessárias para a reserva (por exemplo, propósito da reserva). |
|                  | 9. Confirme a reserva e aguarde a confirmação do sistema.     |
| Critério de Êxito | Os usuários conseguem efetuar reservas de ambientes de testes de forma eficiente, e o sistema fornece confirmação da reserva. |
| Observações      | - Certifique-se de que apenas usuários autenticados tenham acesso à função de reserva. |
|                  | - Avalie a clareza das informações apresentadas durante o processo de reserva. |
|                  | - Registre o tempo necessário para concluir o processo de reserva. |
|                  | - Observe se o sistema lida bem com conflitos de reservas e disponibilidade. |

| Caso de Teste   | CT-05 – Gerenciamento de Reservas por Administradores     |
|------------------|------------------------------------------------------------|
| Requisito       | RF-09 - O sistema deve permitir que os administradores gerenciem as reservas. |
| Objetivo do Teste | Verificar se os administradores conseguem gerenciar as reservas de forma eficiente e eficaz. |
| Passos          | 1. Acesse o navegador.                                      |
|                  | 2. Vá para a página de login da aplicação: https://www.easybooking.com |
|                  | 3. Efetue o login como um administrador usando suas credenciais de administrador. |
|                  | 4. Navegue até a seção de gerenciamento de reservas ou equivalente. |
|                  | 5. Visualize a lista de reservas existentes.                |
|                  | 6. Selecione uma reserva específica para gerenciar.         |
|                  | 7. Realize ações de gerenciamento, como aprovar, rejeitar ou modificar a reserva. |
|                  | 8. Confirme se as ações de gerenciamento são executadas corretamente. |
|                  | 9. Registre qualquer problema ou desafio encontrado durante o processo de gerenciamento. |
| Critério de Êxito | Os administradores conseguem gerenciar as reservas de forma eficiente, e as ações de gerenciamento são refletidas corretamente no sistema. |
| Observações      | - Certifique-se de que apenas administradores tenham acesso às funcionalidades de gerenciamento de reservas. |
|                  | - Avalie a clareza das informações apresentadas durante o gerenciamento de reservas. |
|                  | - Registre o tempo necessário para concluir cada ação de gerenciamento. |
|                  | - Observe como o sistema lida com situações incomuns, como conflitos de reservas ou erros de usuário. |

| Caso de Teste   | CT-06 – Notificações por E-mail de Reservas                   |
|------------------|------------------------------------------------------------|
| Requisito       | RF-10 - O sistema deve enviar notificações por e-mail aos usuários sobre suas reservas. |
| Objetivo do Teste | Verificar se o sistema envia notificações por e-mail aos usuários quando realizam uma reserva e se essas notificações são entregues corretamente. |
| Passos          | 1. Acesse o navegador.                                      |
|                  | 2. Vá para a página inicial do site: https://www.easybooking.com. |
|                  | 3. Efetue o login na aplicação usando suas credenciais de usuário. |
|                  | 4. Realize uma reserva em nome do usuário, preenchendo os campos necessários. |
|                  | 5. Após a conclusão da reserva, aguarde a notificação por e-mail. |
|                  | 6. Verifique sua caixa de entrada de e-mail para a notificação. |
|                  | 7. Confirme se a notificação contém informações relevantes sobre a reserva, como data, horário e detalhes adicionais. |
|                  | 8. Certifique-se de que a notificação foi entregue corretamente e não foi marcada como spam. |
| Critério de Êxito | O sistema envia notificações por e-mail aos usuários após uma reserva, e as notificações contêm informações relevantes e são entregues corretamente. |
| Observações      | - Certifique-se de configurar um ambiente de teste para enviar notificações por e-mail. |
|                  | - Verifique a clareza e o formato das notificações enviadas. |
|                  | - Registre o tempo necessário para a entrega da notificação após a reserva. |
|                  | - Certifique-se de que as notificações não sejam marcadas como spam pelos serviços de e-mail. |




 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
