# 🐾 BancoDeDados: API .NET com Docker e MySQL

Este projeto foi criado como um esforço de aprendizado e aprofundamento nas tecnologias **.NET**, **Docker** e **MySQL**.  
O objetivo principal foi praticar a construção de uma **API em C#** e entender como orquestrar e gerenciar o ambiente de desenvolvimento usando contêineres Docker, simulando um ambiente de produção.

---

## 🚀 Tecnologias Utilizadas

- **.NET 8** → Framework de desenvolvimento web.  
- **MySQL** → Sistema de gerenciamento de banco de dados.  
- **Docker & Docker Compose** → Orquestração da aplicação e do banco de dados.  
- **Entity Framework Core** → ORM para acesso e manipulação de dados.  
- **Swagger/OpenAPI** → Documentação e teste interativo da API.  

---

## ⚙️ Funcionalidades da API

- **GET /gatos** → Retorna a lista completa de gatos.  
- **GET /gatos/{id}** → Retorna um gato específico por ID.  
- **POST /gatos** → Adiciona um novo gato.  
- **PUT /gatos/{id}** → Atualiza os dados de um gato existente.  
- **DELETE /gatos/{id}** → Remove um gato do banco de dados.  

---

## 📋 Pré-requisitos

Antes de começar, certifique-se de ter instalado:

- [Docker Desktop](https://www.docker.com/products/docker-desktop)  
- [Git](https://git-scm.com/)  

---

## ▶️ Como Executar o Projeto

Clone este repositório para sua máquina local:

```bash
git clone https://github.com/MayaraOliveir/Banco-De-Gatos-API-Docker
```
```bash
cd Banco-De-Gatos-API-Docker
 ```

Suba os contêineres da aplicação e do banco de dados usando o Docker Compose.
O parâmetro --build garante que a imagem da API seja reconstruída com a versão mais recente do código.

```bash
 docker-compose up --build
 ```


ℹ️ Isso pode levar alguns minutos na primeira execução.

🔗 Documentação da API

Após iniciar os contêineres, abra o navegador e acesse:

👉 http://localhost:8080/swagger

A partir daí, é possível explorar e testar todos os endpoints da API.

## 📂 Estrutura do Projeto

| Caminho              | Descrição |
|----------------------|-----------|
| **/api**             | Código-fonte da API .NET |
| **/db**              | Script SQL (`gatos.sql`) para inicialização do banco |
| **docker-compose.yml** | Arquivo de configuração do Docker Compose |
| **README.md**        | Documentação do projeto |



👩‍💻 Autor: Mayara de Oliveira

Este projeto foi desenvolvido para fins de estudo e prática pessoal.

Fique à vontade para entrar em contato ou contribuir com feedback!

