# Send Email API

API simples para envio de e-mails através do meu portfólio.

---

## Tecnologias Usadas

![.NET](https://img.shields.io/badge/.NET-0078D7?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-008080?style=for-the-badge&logo=asp.net&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-6BAE44?style=for-the-badge&logo=swagger&logoColor=white)
![Render](https://img.shields.io/badge/Render-FF3E00?style=for-the-badge&logo=render&logoColor=white)


---

## Funcionalidades

- Recebe requisições HTTP POST com nome, e-mail e mensagem.
- Envia e-mail para o endereço configurado usando SMTP.
- Retorna status de sucesso ou erro.

---

## Endpoints

### `POST /email/send`

Envia um e-mail com os dados do formulário.

**Requisição**

- Content-Type: `application/json`

```json
{
  "name": "Nome do remetente",
  "email": "email@exemplo.com",
  "message": "Conteúdo da mensagem"
}
