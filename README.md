LABORATÓRIO 1
Event Driven Architecture

Objetivo:

2 endpoints: Get All Notes ; Post Note.

Get All Notes -> Http Trigger > Request Table Storage > Return Json(List<Notes>)

Post Note -> Http Trigger > Queue Binding > Queue Trigger > Table Trigger > Return Email(Nota salva com sucesso!)
                         \
                          > Return Ok(Mensagem enfileirada com sucesso!)

Requisitos técnicos:
  Quota de 3 notas enviadas por hora, exigência de assinatura, interface gráfica, cache das ultimas 5 mensagens.

Recursos usados:
  - Table Storage
  - Queue Storage
  - Azure Function
  - API Management
  - Azure Cache

---------------------------------------------------------------------------------------------------------------------

LABORATÓRIO 2
Monitoring

Objetivo:

2 endpoints: Ok, Error 500

Ok -> Return Ok()
Error -> Return InternalServerError()

Requisitos técnicos:
  Painel gráfico de monitoramento de métricas, utilização de Azure Monitor e Application Insights, envio de email em caso de erro 500

Recursos:
  - Azure App Service
  - Azure Application Insights
  - Azure Monitor

----------------------------------------------------------------------------------------------------------------------

LABORATÓRIO 3
Virtual Machines

Objetivo:
1 endpoint: Hello World

Requisitos técnicos:
  VM com o menor custo possível, acesso quando necessário via SSH, Servidor apache e API em dotnet que retorna um endpoint /api/hello world

Recursos:
  - Azure Vnet
  - Azure Virtual Machine

----------------------------------------------------------------------------------------------------------------------

LABORATÓRIO 4
Blob storage

Objetivo:
2 endpoints: Get Photos, Post Photo.

Requisitos técnicos: Aplicação web que lista fotos postadas e permite o upload de fotos até x tamanho.

Recursos:
  - Azure App Service
  - Azure Blob Storage

