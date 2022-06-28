# CRUD-de-Produtos
CRUD de produtos utilizando Angular e .NET6 desenvolvido para avaliação técnica Full-Stack
Para rodar o sistema é necessário:
- API:
    - O projeto está sendo desenvolvido utilizando EntityFramework, com banco de dados MySql (Utilizando MariaDB)
    - Dentro do servidor local do MariaDB é necessário criar um banco de dados chamado "store"
    - Abrir a solução LojaJet no VisualStudio e alterar a string de conexão com o banco de dados de acordo com seu local
    - ir para o console do gerenciador de pacotes e executar o comando Update-Database
    - Executar a API
- SITE:
    - Para a execução do site basta abrir a solução no 'LojaJetFront' na IDE de preferência e executar o comando 'npm install' no terminal
    - Após a instalação dos pacotes basta executar o comando 'ng s' para execução do projeto