# Plano de Testes de Usabilidade

Vamos Avaliar a usabilidade do sistema de reserva em relação aos requisitos funcionais especificados, identificar problemas de usabilidade e coletar feedback dos usuários.

#### Método de Observação
A metodologia de teste de usabilidade será por meio de medição e de avaliação do System Usability Scale(SUS). Os testes serão conduzidos remotamente.

#### Participantes
Serão recrutados 3 participantes interressados no nosso modelo de negócio.

#### Tarefas a serem executadas

Será solicitado aos participantes para concluirem as seguintes tarefas ao usar o sistema:

    1)Realizar o cadastro como novo usuário.        
    2)Realizar login no sistema; 
    3)Reservar um ambiente de teste;
    4)Verificar as reservas feitas;
    5)Verificar o status atual das salas; 
    6)Realizar operações de gerenciamento de reservas (apenas para administradores);
    7)Verificar se os e-mails de notificação são recebidos e compreendidos.

|**Casos de Teste** |**CT-01– Realizar o cadastro como novo usuário**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-02 - O site deve exibir uma página de cadastro ao clicar no botão “Cadastro”. |
|Objetivo do Teste       | Efetuar cadastro no sistema. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a página principal |
|                        | 4)  Clicar em “Cadastrar” |
|                        | 5)  Na página de cadastro informar dados|
|                        | 6) Clicar no botão "Cadastrar”.  |
| Critérios de êxito     |Realizar o login com os dados informados sem intercorrencias relacionadas ao sistema. |

|**Casos de Teste** |**CT-02– Realizar Login**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-01 - O site deve exibir uma página para login ao clicar no botão “Sing in”. |
|Objetivo do Teste       | Efetuar login no site. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a página principal |
|                        | 4)  Clicar em “Entrar” |
|                        | 5)  Na página de login informar: username e password|
|                        | 6) Clicar no botão "Entrar”.  |
| Critérios de êxito     |Realizar o login com os dados informados sem intercorrencias relacionadas ao sistema.|

|**Casos de Teste** |**CT-03– Reservar um ambiente de teste**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-04- O site deve exibir uma página de reserva ao clicar no botão “Book”. |
|Objetivo do Teste       | Efetuar reserva de ambiente de teste. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a página de reserva |
|                        | 4)  Clicar em “Book” |    
| Critérios de êxito     |Realizar a reserva de um abimente de teste. |

|**Casos de Teste** |**CT-04– Verificar as reservas feitas**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-0- O site deve exibiras reserva realizadas. |
|Objetivo do Teste       | Ver a reserva de ambiente de teste. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a reserva |  
| Critérios de êxito     |Visualizar de Reservas Feitas. |

|**Casos de Teste** |**CT-05– Verificar o status atual das salas**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-07- O site deve exibir uo status atual das salas. |
|Objetivo do Teste       | Verificar o status atual das salas. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a página de reserva | 
| Critérios de êxito     |Visualizar o status atual das salas. |

|**Casos de Teste** |**CT-06– Realizar operações de gerenciamento de reservas (apenas para administradores)**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-09- O site deve exibir uo status atual das salas. |
|Objetivo do Teste       | Realizar operações de gerenciamento de reservas (apenas para administradores). | 
| Critérios de êxito     |Realizar operações de gerenciamento de reservas pelos admin. |

|**Casos de Teste** |**CT-07– Reservar um ambiente de teste**  |
|:--------------:        |---------------------------------------|
|Requisitos associados   | RF-10- O sistema deve enviar notificações por e-mail aos usuários sobre suas reservas. |
|Objetivo do Teste       | Receber e-mails de confirmação. |
|Passos                  | 1)  Acessar o Navegador |
|                        | 2)  Informar o endereço do Site |
|                        | 3)  Visualizar a página de reserva |
|                        | 4)  Fazer a reserva |  
|                        | 5)  Verificar caixa de -mails|   
| Critérios de êxito     |Verificar se os e-mails de notificação são recebidos. |

        
#### Métricas

A métrica será medida a partir da taxa de sucesso, facilidade de uso e satisfação:

Taxa de sucesso: O percentual de participantes que conseguiram concluir cada tarefa.

Facilidade de uso: os usuários irão avaliar o quão fácil ou difícil foi concluir cada tarefa conforme a escala de Likert de 1 a 5.

Satisfação: os participantes avaliarão sua satisfação geral, de acordo, com a escala Likert de 1 a 5.

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).

