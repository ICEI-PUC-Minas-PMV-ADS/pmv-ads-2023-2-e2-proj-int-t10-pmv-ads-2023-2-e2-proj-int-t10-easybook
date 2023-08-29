# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários – membros de startups - em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

|Julia Gualtieri     | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona1](/docs/img/Persona1.jpg) | **Idade:** 24 <br> **Ocupação:** Pós-Graduanda em Designer Gráfico, Designer Gráfico Junior em uma startup. |**Aplicativos:** <br>● Twitter <br>● Instagram <br>● WhatsApp <br>● LinkedIn   |
|**Motivações:** <br>●	Inspirar outras jovens mulheres a perseguir seus sonhos <br>● Busca oportunidades de aprimorar suas habilidades. |**Frustrações:** <br>●	Nunca ter saído do País; <br>● 	Problemas em casa com os pais. |**Hobbies, História:** <br>● Dançar <br>● Ler <br>● Ama experimentar novas culinárias |

|Gilberto Souza    | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona2](/docs/img/Persona2.jpg) | **Idade:** 26 <br> **Ocupação:** Desenvolvedor Pleno, trabalha em uma startup em Belo Horizonte.  |**Aplicativos:** <br>● Discord <br>● Instagram <br>● Reddit <br>● LinkedIn   |
|**Motivações:** <br>●	Progressão de carreira;<br>● Sair com os amigos para aliviar o estresse do trabalho <br>● Ter uma vida saudável. |**Frustrações:** <br>●	Sobrecarga no trabalho <br>● 	Falta de tempo para hobbies<br>● Isolamento social. |**Hobbies, História:** <br>● Games <br>● Esportes <br>● Sair com amigos |

|Igor Alves da Silva   | Informações:                          |                                      |
|--------------------|----------------------------------|--------------------------------------|
| ![persona3](/docs/img/Persona3.jpg) | **Idade:** 37 <br> **Ocupação:** Professor de Análise e Desenvolvimento de Sistemas, CEO de uma startup.  |**Aplicativos:** <br>● Instagrem <br>●Twitter <br>● LinkedIn <br>● Facebook <br>● GitHub <br>Git   |
|**Motivações:** <br>●	Família <br>● Gerar oportunidades <br>● Guiar as pessoas até seus sonhos  <br>● Criar metodologias de alta performance |**Frustrações:** <br>● Não poder oferecer  oportunidades a quem precisa de auxílio <br>● 	Oportunidades desperdiçadas por falta de investimentos |**Hobbies, História:** <br>● Ler <br>● Estudar idiomas <br>● Fotografia |

## Histórias de Usuários

`Reserva Rápida de Ambientes de Desenvolvimento`
|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Julia Gualtieri  | Uma plataforma dinâmica e segura.    | Acessibilidade do time em tempo real e com segurança.        |
|Gilberto Souza       | Um financiamento concreto para os projetos. | Conseguir concluir com o máximo de qualidades as demandas. |
|Igor Alves da Silva  | Segurança para a produção de projetos.     | Cada vez mais existem formas de furtar dados.         |

`Testes de Integração Contínua`
|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Julia Gualtieri | Conciliar melhor a gestão da produção do projeto.     | Concluir as demandas dentro do prazo.         |
|Gilberto Souza       | Maior efetividade das ferramentas usadas para o desenvolvimento de sistemas. | Usarmos os meios que estão dentro do orçamento da Startup, e muitas vezes é o básico. |
|Igor Alves da Silva  | Não haver escassez de recursos durante o desenvolvimento do projeto.    | Quanto maior os investimentos, melhor será a qualidade final do produto.     |

## Requisitos

O sistema deve atender de modo eficiente as demandas crescentes de um mesmo usuário e ser capaz de resistir a falhas e se recuperar delas inclusive as oriundas de ataques cibernéticos.


O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.


### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deverá ter disponibilidade de 0,999 % | ALTA | 
|RNF-002| O tempo médio de indisponibilidade deverá ser de 5 min em 99% das vezes |  ALTA | 
|RNF-003| O sistema deverá ter uma taxa de ocorrência de falhas de 1/1000 |  ALTA | 
|RNF-004| Os usuários devem realizar um cadastro onde se identificarão antes de utilizar o sistema |  ALTA | 
|RNF-005| Todas as informações do cliente devem ser criptografadas |  ALTA | 
|RNF-006| O sistema deve implementar métodos de autenticação multi-fator para acesso ao sistema |  ALTA | 




Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
