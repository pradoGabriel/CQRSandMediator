#CQRS Command and Queries Responsability Segregation 
Separação de Responsabilidades em Consultas e Comandos

Neste projeto contém um exemplo do Pattern CQRS, que consiste em segregar consultas e escritas. 
Este Pattern é baseado em comandos (Requests e Responses) e Handlers que auxiliam na criação do fluxo de execução de uma determinada ação e isso pode variar bastante. Resumindo, a regra de negócio irá se encontrar no nosso Handler, que irá receber uma requisição e emitir uma resposta. 

#Mediator
O Mediator como o próprio nome diz, funciona como um mediador. Ele facilita a comunicação e simplifica nossas dependencias abstraindo isso para a gente. Recebemos uma request e o mediator "se vira" para encontrar o handle responsável e executar a ação. 