Proposta
O objetivo desse desafio é a criação de uma API REST para um aplicativo de
gerenciamento de usuários, com base no conceito CRUD (Create, Read, Update, Delete).
Não é esperado que você saiba todos os códigos de cabeça, mas é esperado que você
seja capaz de encontrar soluções por meio das documentações oficiais ou por meio de fóruns
ou artigos. Leia com atenção todo esse documento antes de pôr a mão na massa!
Requisitos
Segue abaixo o resumo dos requisitos que devem ser desenvolvidos:
• Cadastro de um novo usuário
• Listagem de usuários
• Listagem de usuário por Id
• Atualização de informações do usuário por Id
• Exclusão de um usuário por Id
• Disponibilização da documentação da API utilizando o Swagger
• Queries T-SQL
Cadastro de um usuário
A API deve receber o nome, e-mail e senha, CPF e data de nascimento do usuário para
realizar a criação do usuário. Todos obrigatórios.
Será um diferencial conseguir armazenar a senha em forma de hash. Lembre-se,
segurança é muito importante!
Deve ser gerado automaticamente um ID para o usuário.
Não deve permitir criar dois usuários com o mesmo e-mail, nem o mesmo CPF, senão
isso daria uma boa confusão.
Listagem de usuários
A API deve ser capaz de retornar a lista de todos os usuários cadastrados previamente.
Além disso, caso seja chamado o método de listagem, e não existir nenhum usuário cadastrado,
deve-se retornar o HTTP Code correto, com mensagem de tratamento.
Listagem de usuário por Id
A API deve possuir um método para retornar um usuário, recebendo como parâmetro o
Id de identificação dele. Novamente, lembre-se de tratar as exceções, como Id inválido, que
deve retornar uma mensagem adequada para quem estiver utilizando o método.
Atualização de informações do usuário por Id
A API deve possuir um método para atualização dos dados de um usuário previamente
cadastrado, passando como parâmetro o Id de identificação dele. Lembre-se, Id inválido, deve
retornar o tratamento adequado.
Caso seja informado um e-mail e/ou um CPF na alteração, que já esteja em uso por outro
usuário cadastrado, deve barrar a alteração, e devolver mensagem adequada.
Em caso de sucesso, informar que a alteração foi realizada, e retornar os dados
atualizados do usuário.
Exclusão de um usuário por Id
A API deve possuir um método de exclusão de um usuário previamente cadastrado,
passando como parâmetro o Id de identificação dele. Lembre-se, Id inválido, deve retornar o
tratamento adequado.
Após a exclusão, deve-se retornar apenas o HTTP Code de sucesso, com a mensagem de
exclusão do usuário.
Disponibilização da documentação da API utilizando o Swagger
O Swagger é um framework composto por diversas ferramentas que,
independentemente da linguagem, auxilia a descrição, consumo e visualização de serviços de
uma API REST.
A API REST desenvolvida deve retornar os métodos documentos via Swagger. Lembrese de usar o método HTTP correto para cada método criado.
Queries T-SQL
Dado os métodos API acima (Criação, listagem, listagem por Id, Alteração e Exclusão),
crie queries T-SQL representando cada um deles.
Disponibilize todos os scripts em uma pasta chamada “Database”.
Lembre-se de utilizar padrões de desenvolvimento limpo no seu script. Por exemplo,
evite:
• Nome de campos com espaço ou caracteres especiais.
• Nome extensos ou muito abreviados.
Requisitos técnicos
Plataforma: a API deve ser desenvolvida em C# com .NET Core 2.0 (ou superior).
Banco de dados: pode ser utilizado banco de dados em memória, por exemplo o Entity
Framework Core, através do provedor InMemory, listas em memória, bem como pode ser
utilizado SQL-Server. Em caso de utilização de banco de dados relacional, disponibilizar os scripts
das tabelas no código fonte.
Código fonte: o código fonte deve ser disponibilizado no GitHub pessoal até a data acordada.
Lembre-se de deixar seu repositório público, caso contrário estará desclassificado.
Commits feitos depois do prazo final, serão desconsiderados.
  
