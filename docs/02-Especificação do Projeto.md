# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários – membros de startups - em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

|Julia Gualtieri     | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona1](/docs/img/Persona1.jpg) | **Idade:** 24 <br> **Ocupação:** Pós-Graduanda em Designer Gráfico, Designer Gráfico Junior em uma startup. |**Aplicativos:** <br>● Twitter <br>● Instagram <br>● WhatsApp <br>● LinkedIn   |
|**Motivações:** <br>●	Inspirar outras jovens mulheres a perseguir seus sonhos <br>● Busca oportunidades de aprimorar suas habilidades. |**Frustrações:** <br>●	Nunca ter saído do País; <br>● Problemas em casa com os pais. |**Hobbies, História:** <br>● Dançar <br>● Ler <br>● Ama experimentar novas culinárias |

|Gilberto Souza    | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona2](/docs/img/Persona2.jpg) | **Idade:** 26 <br> **Ocupação:** Desenvolvedor Pleno, trabalha em uma startup em Belo Horizonte.  |**Aplicativos:** <br>● Discord <br>● Instagram <br>● Reddit <br>● LinkedIn   |
|**Motivações:** <br>●	Progressão de carreira;<br>● Sair com os amigos para aliviar o estresse do trabalho <br>● Ter uma vida saudável. |**Frustrações:** <br>●	Sobrecarga no trabalho <br>● 	Falta de tempo para hobbies<br>● Isolamento social. |**Hobbies, História:** <br>● Games <br>● Esportes <br>● Sair com amigos |

|Igor Alves da Silva   | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona3](/docs/img/Persona3.jpg) | **Idade:** 37 <br> **Ocupação:** Professor de Análise e Desenvolvimento de Sistemas, CEO de uma startup.  |**Aplicativos:** <br>● Instagrem <br>●Twitter <br>● LinkedIn <br>● Facebook <br>● GitHub  |
|**Motivações:** <br>●	Família <br>● Gerar oportunidades <br>● Guiar as pessoas até seus sonhos  <br>● Criar metodologias de alta performance |**Frustrações:** <br>● Não poder oferecer  oportunidades a quem precisa de auxílio <br>● Oportunidades desperdiçadas por falta de investimentos |**Hobbies, História:** <br>● Ler <br>● Estudar idiomas <br>● Fotografia |

|Elisa Maria Fonseca     | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona4](/docs/img/Persona4.jpg) | **Idade:** 35 <br> **Ocupação:** Business Developer em uma startup e coach de investimentos. |**Aplicativos:** <br>● Twitter <br>● Instagram <br>● WhatsApp <br>● LinkedIn   |
|**Motivações:** <br>● Ser 1% melhor do que no dia anterior; <br>● Romper preconceitos e diversidades. |**Frustrações:** <br>●	Não ter sido mãe ainda; <br>● Ganhar menos que meus colegas homens. |**Hobbies, História:** <br>● Dançar <br>● Beber vinho <br>● Gatos|

|Ricardo Gomes Aguiar     | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona5](/docs/img/Persona5.jpg) | **Idade:** 26 <br> **Ocupação:** Estagio em gestão de tráfego em uma startup, graduando em ciência da computação. |**Aplicativos:** <br>● Twitter <br>● Instagram  <br>● LinkedIn <br>● Discord <br>●  Reddit    |
|**Motivações:** <br>● Formar <br>●Sair da casa dos  pais <br>● Comprar um carro. |**Frustrações:** <br>● Demorar para entrar para a área da tecnologia <br>● Falar pouco sobre seus sentimentos. |**Hobbies, História:** <br>● Jogos de computador <br>● Truco com amigos <br>● Cerveja|



## Histórias de Usuários

`Reserva Rápida de Ambientes de Desenvolvimento`
|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Julia Gualtieri  | Uma plataforma dinâmica e segura.    | Acessibilidade do time em tempo real e com segurança.        |
|Gilberto Souza       | Valores acessíveis quanto a reserva. | Startup não possui condições de mantes custos altos. |
|Igor Alves da Silva  | Segurança na reserva.     | Assegurar a locação de tempo dentro do ambiente.         |
|Elisa Maria Fonseca  | Consistência quanto as reservas .  | Sempre que solicitado o sistema ele venha responder adequadamente.         |
|Ricardo Gomes Aguiar  | Designe adequado do sistema.     | Uso fácil e instintivo.         |

`Testes de Integração Contínua`
|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Julia Gualtieri | Conciliar melhor a gestão da produção do projeto.     | Concluir as demandas dentro do prazo com o auxílio ddos testes.         |
|Gilberto Souza       | Maior efetividade das ferramentas usadas para o desenvolvimento de sistemas. | Projetos são dinâmicos, logo precisam de uam metodologia de testes. |
|Igor Alves da Silva  | Não haver escassez de recursos durante o desenvolvimento do projeto.    | Quanto maior os investimentos, melhor será a qualidade final do produto.     |
|Elisa Maria Fonseca  | Custo baixo para promover os testes.     | Valores altos afastam Startups com pouca liquidez.         |
|Ricardo Gomes Aguiar  | Testes de com alta qualidade.     | Evitar bugs na hora de apresentar/usar o produto.         |

## Requisitos

O sistema deve atender de modo eficiente as demandas crescentes de um mesmo usuário e ser capaz de resistir a falhas e se recuperar delas inclusive as oriundas de ataques cibernéticos.

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O site deve permitir que os usuários façam login | MEDIA | 
|RF-02| O site deve permitir que os usuários se cadastrem | MÉDIA |
|RF-03|	Os site deve permitir que os ususários visualizem o sistema de reserva |ALTA||
|RF-04|	O site deve permitir que os usuários reservem ambientes de testes |ALTA|
|RF-05|	O site deve permitir visualizar as reservas feitas |MEDIA|
|RF-06|	O site deve permitir que monitorem as reservas feitas |BAIXA|
|RF-07|	O site deve informar o estado atual das salas (ambientes) |media|
|RF-08|	O site deve possibilitar a visualização do número total de ambientes disponíveis |BAIXA|
|RF-09| O site deve permitir que os administradores gerenciem as reservas |ALTA|
|RF-10| O sistema deve enviar notificação por e-mail aos usuários sobre suas reservas|MEDIA|


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um abiente acessível expostas às publicamente na internet (Repl.it, GithHub Pgages,Heroku)|ALTA| 
|RNF-002| O tempo médio de insisponbilidade deverá ser de 5min em 99% das vezes |MEDIA| 
|RNF-003| O site deverá ter uma ocorrência de falhas de 1/1000 |MEDIA| 
|RNF-004| Os usuários devem realizar um cadastro onde se identificarão antes de utilizar o sistema |BAIXA| 
|RNF-005| O sistema deve ser compatível com os principais navegadores do mercado |ALTA| 
|RNF-006| O site deve ser fácil de usar e com interface intuitiva |MEDIA| 
|RNF-007| O sistema deverá ter disponibilidade de 0,999% |BAIXA|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deve ser concluído no prazo estipulado, sem qualquer atraso.|
|RE-02| O sistema deve ser desenvolvido utilizando tecnologias básicas de uma aplicação interativa.|
|RE-03| O sistema deve estar consoante às regras da disciplina.|
|RE-04| A equipe responsável pelo desenvolvimento do sistema deve ser o grupo 03 turma 10 da disciplina de Projeto: Desenvolvimento de uma Aplicação Interativa. |

## Diagrama de Casos de Uso

O diagrama de casos de uso representa interações no sistema, facilitando a compreensão dos requisitos funcionais, os casos de uso e seus relacionamentos. É essencial para o desenvolvimento eficaz de sistemas.


![PBD](/docs/img/diagrama-caso-uso.png)
<center>Figura 1 - Diagrama de Caso de Uso </center>
