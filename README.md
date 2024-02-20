
Exo.WebApi

Bem-vindo ao projeto Exo.WebApi! Este projeto é uma API ASP.NET Core que gerencia operações relacionadas a Projetos e Usuários.

Projetos Controller

O controlador "ProjetosController" lida com operações CRUD (Criar, Ler, Atualizar, Deletar) para entidade `Projeto`.

Listar Projetos
GET /api/Projetos
Retorna uma lista de projetos cadastrados.

Cadastrar Projeto
http
Copy code
POST /api/Projetos
Cadastra um novo projeto.

Buscar Projeto por ID
http
Copy code
GET /api/Projetos/{id}
Retorna um projeto específico com base no ID.

Atualizar Projeto
http
Copy code
PUT /api/Projetos/{id}
Atualiza as informações de um projeto existente.

Deletar Projeto
http
Copy code
DELETE /api/Projetos/{id}
Exclui um projeto com base no ID.

Usuários Controller
O controlador UsuariosController gerencia operações relacionadas a Usuários, incluindo autenticação usando tokens JWT.

Listar Usuários
http
Copy code
GET /api/Usuarios
Retorna uma lista de usuários cadastrados.

Login (Autenticação)
http
Copy code
POST /api/Usuarios
Autentica um usuário e gera um token JWT.

Buscar Usuário por ID
http
Copy code
GET /api/Usuarios/{id}
Retorna informações de um usuário específico com base no ID.

Atualizar Usuário
http
Copy code
PUT /api/Usuarios/{id}
Atualiza as informações de um usuário existente (requer autenticação).

Deletar Usuário
http
Copy code
DELETE /api/Usuarios/{id}
Exclui um usuário com base no ID (requer autenticação).

Configuração do Token JWT
A autenticação de usuários é gerenciada usando tokens JWT. Certifique-se de incluir o token JWT nas solicitações autenticadas.

A chave de autenticação JWT é definida como "exoapi-chave-autenticacao". Mantenha esta chave segura e considere substituí-la por uma chave mais segura em ambientes de produção.

Dependências
Certifique-se de ter todas as dependências necessárias instaladas antes de executar o projeto.


