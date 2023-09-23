# Arquitetura da Solução

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Possuem atributos e métodos que as qualificam para proposta de sua criação. Essa estrutura de classes fornece uma base para gerenciar os recursos de desenvolvimento e teste, bem como para rastrear atividades e gerar relatórios financeiros.

![diagrama](/docs/img/Diagrama_classe.png)
<center>Figura 1 - Diagrama de Classes </center>

### Classes criadas para a estrutura do software:

<br>● 1. Classe Startup: 
- **Atributos**: ID, Nome, Fundador, Data de Fundação, Endereço | **Métodos**: AdicionarMembroEquipe(), RemoverMembroEquipe(), 

<br>● 2.  Classe MembroEquipe:
- **Atributos**: ID, Nome, Cargo, Especialização | **Métodos**: AlocarAmbienteDesenvolvimento(), AlocarAmbienteTeste(), LiberarAmbiente().

<br>● 3. Classe AmbienteDesenvolvimento: 
- **Atributos**: ID, Nome, Capacidade, Status (Disponível/Reservado) |	**Métodos**: Reservar(), Liberar().

<br>● 4. Classe AmbienteTeste: 
- **Atributos**: ID, Nome, Capacidade, Status (Disponível/Reservado) |	**Métodos**: Reservar(), Liberar().

<br>●  Classe Projeto:
- **Atributos**: ID, Nome, Descrição, Data de Início, Data de Término, Responsável |	**Métodos**: AdicionarMembroEquipe(), RemoverMembroEquipe(), ListarMembrosEquipe(), DefinirAmbientesDesenvolvimento(), DefinirAmbientesTeste().

<br>●  Classe GerenciadorRecursos:
- **Métodos**: ListarAmbientesDesenvolvimentoDisponíveis(), ListarAmbientesTesteDisponíveis(), ReservarAmbienteDesenvolvimento(), ReservarAmbienteTeste().

<br>●  Classe Usuário:	
- **Atributos**: ID, Nome, Email, Senha |	**Métodos**: Autenticar(), AlterarSenha().

<br>●  Classe RegistroAtividade:
- **Atributos**: ID, DataHora, Descrição (para registrar atividades como reservas, liberações, etc.).

<br>●  Classe Classe RelatórioFinanceiro:
- **Métodos**: GerarRelatórioDespesas(), GerarRelatórioReceitas(), GerarRelatórioLucro().:

<br>●  Classe 	Classe Sistema:
- **Métodos**: IniciarSistema(), EncerrarSistema().
  

### Classes e suas relações cardinais entre si:

**Startup - MembroEquipe** (Relação 1:N)
<br>● Uma startup pode ter vários membros na equipe, mas um membro da equipe pertence a uma única startup.
<br>● **Cardinalidade**: Startup (1) -> MembroEquipe (N)

**MembroEquipe - AmbienteDesenvolvimento** (Relação N:M)
<br>● Um membro da equipe pode reservar vários ambientes de desenvolvimento.
<br>● Um ambiente de desenvolvimento pode ser reservado por vários membros da equipe.
<br>● **Cardinalidade**: MembroEquipe (N) <-> AmbienteDesenvolvimento (N)

**MembroEquipe - AmbienteTeste** (Relação N:M)
<br>● Um membro da equipe pode reservar vários ambientes de teste.
<br>● Um ambiente de teste pode ser reservado por vários membros da equipe.
<br>● **Cardinalidade**: MembroEquipe (N) <-> AmbienteTeste (N)

**Projeto - MembroEquipe** (Relação N:M)
<br>● Um projeto pode ter vários membros na equipe.
<br>● Um membro da equipe pode estar envolvido em vários projetos.
<br>● **Cardinalidade**: Projeto (N) <-> MembroEquipe (N)

**Projeto - AmbienteDesenvolvimento** (Relação 1:N)
<br>●	Um projeto pode estar associado a vários ambientes de desenvolvimento.
<br>●	Um ambiente de desenvolvimento pertence a um único projeto.
<br>●	**Cardinalidade**: Projeto (1) -> AmbienteDesenvolvimento (N)

**Projeto - AmbienteTeste** (Relação 1:N)
<br>●	Um projeto pode estar associado a vários ambientes de teste.
<br>● Um ambiente de teste pertence a um único projeto.
<br>● **Cardinalidade**: Projeto (1) -> AmbienteTeste (N)

**MembroEquipe - Usuário** (Relação 1:1)
<br>● Cada membro da equipe tem uma conta de usuário associada.
<br>● Cada conta de usuário pertence a um único membro da equipe.
<br>● **Cardinalidade**: MembroEquipe (1) <-> Usuário (1)

**RegistroAtividade - Usuário** (Relação N:1)
<br>● Cada registro de atividade é registrado por um usuário.
<br>● Um usuário pode ter registrado várias atividades.
<br>● **Cardinalidade**: RegistroAtividade (N) -> Usuário (1)

**RelatórioFinanceiro** - Startup (Relação 1:1)
<br>● Cada relatório financeiro está relacionado a uma única startup.
<br>● Cada startup possui um único relatório financeiro.
<br>● **Cardinalidade**: RelatórioFinanceiro (1) <-> Startup (1)

**Sistema - Startup** (Relação 1:1)
<br>● Cada instância do sistema é associada a uma única startup.
<br>● Cada startup possui uma única instância do sistema.
<br>● **Cardinalidade**: Sistema (1) <-> Startup (1)

A classe **GerenciadorRecursos** não possui cardinalidade com outra classe no diagrama de classes fornecido. Ela é uma classe que contém métodos para gerenciar recursos, como listar ambientes de desenvolvimento disponíveis e reservar ambientes de desenvolvimento ou teste. Essa classe não possui relacionamentos diretos (associações) com outras classes no diagrama, mas ela interage com outras classes por meio dos métodos que ela contém.
A principal função do GerenciadorRecursos é fornecer funcionalidades para alocar e liberar ambientes de desenvolvimento e teste para os membros da equipe e projetos, mas ela não mantém relacionamentos de associação direta com outras classes, como as classes **AmbienteDesenvolvimento**, **AmbienteTeste**, **MembroEquipe**, ou **Projeto**. Em vez disso, ela atua como uma espécie de intermediário para fornecer acesso a recursos gerenciados por outras classes.


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![MER](/docs/img/MER.drawio.png)
<center>Figura 2 - Modelo ER  </center>

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
![PBD](/docs/img/PBD.drawio.png)
<center>Figura 2 - Projeto da Base de Dados </center>

## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
