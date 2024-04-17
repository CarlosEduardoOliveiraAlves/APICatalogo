<h1>Projeto ASP.NET Core Web API</h1>

<h2>Definição do projeto</h2> 

<h3>Escopo:</h3>

>- Criar uma Web API para um catálogo de produtos/categorias que pode atender uma rede de lojas ou supermercados.

<h3>Requisitos:</h3>

>1 - Criar um serviço RESTful que permita que aplicativos clientes gerenciem o catálogo de produtos e categorias.

>2 - Expor endpoints para criar, ler, editar e excluir produtos e também para consultar produtos e um produto específico.

>3 - Expor endpoints para criar, ler, editar e excluir categorias e também consultar categorias, podendo consultar uma categoria específica e os produtos de uma categoria.

>4 - Para categorias, é preciso armazenar: O nome e o caminho da imagem.

>5 - Para produtos, é preciso armazenar: O nome, descrição, valor unitário, caminho da imagem, estoque, data do cadastro e categoria.

>6 - Permitir o acesso às APIs somente a usuários autenticados

>7 - Definir uma política de autorização de acesso aos usuários

>8 - Criar um serviço RESTful que permita gerenciar os usuários

>9 - Expor endpoints para criar, ler, editar e excluir usuários e também para consultar usuários e um usuário específico

>10 - Para os usuários é preciso armazenar: nome, email e senha.

<h2>Definição dos recursos, endpoints e mapeamento:</h2>

<h3>Endpoints de Produtos:</h3>

Main Endpoint: /v1/api/produtos

>- GET/v1/api/produtos - Consultar todos os produtos.
>- GET/v1/api/produtos/1 - Consultar produto de produtos pelo ID.
>- POST/v1/api/produtos - Inserir um produto a produtos.
>- PUT/v1/api/produtos/1 - Alterar o produto de produtos pelo ID.
>- DELETE/v1/produtos/1 - Deletar produto de produtos pelo ID.

<h3>Endpoints de Categorias:</h3>

Main Endpoint: /v1/api/categorias

>- GET/v1/api/categorias - Consultar todas as categorias.
>- GET/v1/api/categorias/1 - Consultar categoria de categorias pelo ID.
>- GET/v1/api/categorias/1/produtos - Consultar produtos de uma determinada categoria pelo ID.
>- POST/v1/api/categorias - Inserir uma categoria a categorias.
>- PUT/v1/api/categorias/1 - Alterar categoria de categorias pelo ID.
>- DELETE/v1/categorias/1 - Deletar categoria de categorias pelo ID.

<h3>Endpoints de Usuários:</h3>

Main Endpoint: /v1/api/usuarios

>- GET/v1/api/usuarios - Consultar todos os usuários.
>- GET/v1/api/usuarios/1 - Consultar usuário de usuários pelo ID.
>- POST/v1/api/usuarios - Inserir usuário à usuários.
>- PUT/v1/api/usuarios/1 - Alterar usuário de usuários pelo ID.
>- DELETE/v1/api/usuarios/1 - Deletar usuário de usuários pelo ID.

<h2>Recusos que serão utilizados:</h2> 

>- .NET 8.0(SDK);
>- ASP.NET Core 8.0;
>- Entity Framework Core 8.0 (Code First);
>- Banco de dados MySQL e MySQL WorkBench(SGBD);
>- Utilização do CRUD;
>- Criação de endpoints usando verbos HTTP: GET POST PUT DELETE;
>- Uso de Controllers e integração com Swagger(suporte a Open API);
>- Visual Studio 2022 Community.
