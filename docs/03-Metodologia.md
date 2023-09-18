
# Metodologia

A metodologia utilizada pela equipe abrange um conjunto de ferramentas utilizadas para organizar os códigos, gerenciar o trabalho, executar as tarefas e administrar os diversos artefatos do projeto.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

A estratégia de branching que escolhemos é uma abordagem baseada no tronco(trunk-based), onde a branch principal deve estar sempre em um estado estável e atualizado. Quando um desenvolvedor começa a trabalhar em uma nova funcionalidade, eles devem criar uma branch de funcionalidade (ou correção de bug) de curta duração. Branch de funcionalidade de longa duração são desencorajadas, pois aumentariam o risco de conflitos durante o merge. 

## Gerenciamento de Projeto

### Divisão de Papéis

O grupo emprega metodologias ágeis para o desenvolvimento do projeto, sendo o Scrum a base fundamental para a condução do processo.

A organização da equipe é a seguinte:

- `Scrum Master:` Bruno N. M. Cardoso
- `Product Owner:` Renata G. Barbosa  
- `Equipe de Desenvolvimento:`
  - Caio C. S. Rezende 
  - Gabriel M. Pereira
  - Raimundo S. de M. Neto  
- `Equipe de Design:`    
  - Gabriel V. M. de Oliveira  

### Processo

Para gerenciar e distribuir as atividades do projeto, a equipe está utilizando a ferramenta Projects, organizada com as seguintes listas: 

- Backlog: incluímos as atividades a serem realizadas ou identificadas ao longo do projeto no Product Backlog.
- To Do: a lista representa o Sprint Backlog em andamento, ou seja, as atividades executadas neste momento.
- In Progress: tarefas iniciadas são movidas para esta lista.
- Done: os itens desta lista passaram por verificações, idealmente conduzidas por outra pessoa que não esteve envolvida na execução da tarefa. Após serem aprovados, estão prontos para serem entregues. Não há mais modificações ou revisões pendentes.

O quadro kanban do grupo desenvolvido na ferramenta de gerenciamento de projetos está disponível através da URL https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/494/views/1 . A Figura 1 exibe o quadro Kanban em seu estado atual.

![Projects](/docs/img/projects.png)
<center> Figura 1 - Kanban Board </center>

### Ferramentas

As ferramentas utilizadas para o desenvolvimento do projeto estão listadas abaixo:

| AMBIENTE                         | Ferramenta   | LINK DE ACESSO |
|----------------------------------|--------------|----------------|
|Repositório de Código Fonte       | GitHub       | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook |
|Editor de código          | Visual Studio | https://visualstudio.microsoft.com/pt-br/ |
|Projeto de Interface e Wireframes | MarvelApp | https://marvelapp.com/prototype/6de4f63 |
|Ferramentas de comunicação          | Teams e Whatsapp | https://teams.microsoft.com/l/channel/19%3ace5fdca7bfd143d1b8e9f995b048f1c5%40thread.tacv2/T10%2520-%2520Grupo%252003?groupId=39bf0ba3-41ea-4020-847c-e523549608b3&tenantId=14cbd5a7-ec94-46ba-b314-cc0fc972a161 |
|Gerenciamento do Projeto          | GitHub/Projects | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/494/views/1 |


- Editor de código - *Visual Studio*.
- Repositório de Código Fonte - *Github/Classroom*.
- Ferramentas de desenho de tela (_wireframing_) - *Marvel*.
- Ferramentas de comunicação - *Teams e Whatsapp*.
- Gerenciamento do Projeto - *Github/Projects*.

A escolha do editor de código foi feita devido ao fato de possuir integração com o sistema de controle de versão. Da mesma forma, a ferramenta de gerenciamento de projetos oferece uma integração igualmente eficiente, razão pela qual foi selecionada. Já as ferramentas de comunicação foram escolhidas porque abrangem mais facilmente todos os membros do grupo. A ferramenta de desenho de tela foi escolhida  para captar melhor as necessidades da solução.
