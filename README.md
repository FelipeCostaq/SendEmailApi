# Send Email API

<p>API Simples feita para envio de e-mails atráves do meu portfólio</p>

## Funcionalidades

<ul>
  <li>Recebe requisição HTTP POST com nome, e-mail e mensagem</li>
  <li>Envia e-mail para o endereço configurado</li>
  <li>Retorna status de sucesso ou erro</li>
</ul>

## Endpoints

<p>POST Email/send</p>
<p>Envia um e-mail com os dados do usuário</p>

## Requisição

<code>
  {
    "name": "Nome Remetente"
    "email": "email@exemplo.com",
    "message": "Conteúdo da mensagem"
  }
</code>

## Resposta

<h2>Sucesso: HTTP 200</h2>
<code>
    "message": "E-mail enviado."
</code>

<hr>

<h2>Erro: HTTP 500</h2>
<code>
    "message": "Erro ao enviar e-mail.",
  "error": "Descrição do erro"
</code>

## Tecnologias Usadas

![.NET](https://img.shields.io/badge/.NET-7.0-blue?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-9.0-blue?logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-7.0-green?logo=asp.net&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-API-yellow?logo=swagger&logoColor=black)
![Render](https://img.shields.io/badge/Render-Cloud-orange?logo=render&logoColor=white)
