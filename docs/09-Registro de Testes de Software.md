# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

A seguir, são apresentados os resultados dos testes de software.   


### CT-01 - O site deve permitir que os usuários faça login.
Caso de teste: Verificar se o usuário consegue realizar login de forma eficiente e sem problemas significativos. 
- Entrada: Entrar na página de login; 
- Saída esperada: O login foi realizado com sucesso, e o usuário é redirecionado para sua área de perfil ou uma página de destino apropriada.

<video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook/assets/79698768/11c7ad8c-f790-4759-9311-70aa92700238" title="CT-01">| 
<center> Video 1 - CT-01</center>  


### CT-02 - Cadastro de Perfil.
Caso de teste: Verificar se o usuário consegue se cadastrar na aplicação de forma intuitiva e sem problemas significativos.
- Entrada: Entrar na página de cadastro, preencher os campos; 
- Saída esperada: O cadastro foi realizado com sucesso, e o usuário é redirecionado para a próxima etapa ou para sua área de perfil.
  
<video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook/assets/79698768/ad4e8940-d018-4dc5-a940-9897df6711ae" title="CT-02">| 
<center> Video 2 - CT-02</center>  



### CT-03 - Visualização do Sistema de Reserva.
Caso de teste: Verificar se os usuários conseguem acessar e visualizar o sistema de reserva de forma eficiente e intuitiva.
- Entrada: Fazer login, entrar na página de reserva; 
- Saída esperada: Os usuários conseguem acessar e visualizar o sistema de reserva de forma eficiente, as informações sobre disponibilidade são precisas, e o processo de reserva é intuitivo.

<video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook/assets/79698768/172ead32-5e65-4c36-90f5-c96b4eedf797" title="CT-03">| 
<center> Video 3 - CT-03</center>


### CT-04 - Reserva de Ambientes de Testes.
Caso de teste: Verificar se os usuários podem efetuar reservas de ambientes de testes de forma eficiente e sem problemas significativos.
- Entrada: Fazer login, entrar na página de reserva e fazer a reserva; 
- Saída esperada: Os usuários conseguem efetuar reservas de ambientes de testes de forma eficiente, e o sistema fornece confirmação da reserva.

  
<video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook/assets/79698768/9885ec42-06d2-4a69-a329-ff6adcd7be92" title="CT-04">| 
<center> Video 4 - CT-04</center>



### CT-05 - Gerenciamento de Reservas por Administradores.
Caso de teste: Verificar se os administradores conseguem gerenciar as reservas de forma eficiente e eficaz.
- Entrada: Fazer login como admin, entrar na página de reserva, navegue até a seção de gerenciamento de reservas ; 
- Saída esperada: Os administradores conseguem gerenciar as reservas de forma eficiente, e as ações de gerenciamento são refletidas corretamente no sistema.

  
<video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t10-pmv-ads-2023-2-e2-proj-int-t10-easybook/assets/79698768/5117547c-9671-4a26-8af1-46cd27410edf" title="CT-05">| 
<center> Video 5 - CT-05</center>








## Avaliação


### Relatório de Avaliação de Registros de Testes de Software

Projeto: EasyBooking

Equipe de Testes: Renata G. Barbosa

## 1. Introdução

Este relatório apresenta uma análise detalhada dos resultados dos testes de software realizados no projeto. A avaliação se concentra nos casos de teste específicos definidos para garantir o correto funcionamento de funcionalidades cruciais do sistema.

## 2. Resultados dos Testes

##### CT-01 - Login de Usuários:

###### Pontos Fortes:

- Eficiência no processo de login.
- Redirecionamento para a área de perfil ou página de destino bem-sucedido.
  
###### Pontos Fracos:

- Não foram identificados pontos fracos que mereçam destaque.

###### Abordagem para Melhorias:

- Monitoramento contínuo do desempenho do login.
- Implementação de verificações adicionais de segurança, se necessário.
- Exploração de melhorias na experiência do usuário durante o redirecionamento.
  
##### CT-02 - Cadastro de Perfil:

###### Pontos Fortes:

- Cadastro realizado com sucesso e de forma intuitiva.
- Redirecionamento pós-cadastro ocorreu conforme esperado.
  
###### Pontos Fracos:

- A mensagem indicando o sucesso do cadastro não é exibida.

###### Abordagem para Melhorias:

- Monitoramento contínuo do processo de cadastro para garantir consistência.
- Implementação de feedbacks visuais adicionais durante o cadastro.
  
##### CT-03 - Visualização do Sistema de Reserva:

###### Pontos Fortes:

- Eficiência na visualização do sistema de reserva.
- Informações sobre disponibilidade.
  
###### Pontos Fracos:

- Design de interface mais simplificado e elegante.
  
###### Abordagem para Melhorias:

- Consideração de melhorias na interface de reserva.

##### CT-04 - Reserva de Ambientes de Testes:

###### Pontos Fortes:

- Eficiência na realização de reservas.
- Confirmação da reserva fornecida conforme esperado.
  
###### Pontos Fracos:

- Ausência de mensagem que indique a confirmação da reserva.

###### Abordagem para Melhorias:

- Monitoramento contínuo da confiabilidade do sistema de confirmação de reserva.
- Exibir uma mensagem indicando se a reserva foi concluída ou não.

##### CT-05 - Gerenciamento de Reservas por Administradores:

###### Pontos Fortes:

- Eficiência no gerenciamento de reservas pelos administradores.
- Ações de gerenciamento refletidas corretamente no sistema.

###### Pontos Fracos:

- Não foram identificados pontos fracos que mereçam destaque.
###### Abordagem para Melhorias:

- Continuação do monitoramento da eficácia do sistema de gerenciamento.
- Implementação de verificações adicionais para garantir consistência nas ações administrativas.
  
## 3. Falhas Detectadas e Melhorias Geradas

Nenhuma falha significativa foi detectada durante os testes.
As melhorias propostas visam principalmente o monitoramento contínuo e algumas otimizações de usabilidade.

## 4. Conclusão

Com base nos resultados dos testes, o sistema demonstrou robustez e confiabilidade. As melhorias propostas são medidas preventivas para garantir a manutenção da eficiência e consistência nas próximas iterações do projeto. 


