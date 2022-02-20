# UsuariosApi

## Proposta

O objetivo desse desafio é a criação de uma API REST para um aplicativo de gerenciamento de usuários, com base no conceito CRUD (Create, Read, Update, Delete). Não é esperado que você saiba todos os códigos de cabeça, mas é esperado que você seja capaz de encontrar soluções por meio das documentações oficiais ou por meio de fóruns ou artigos.

## Requisitos

Segue abaixo o resumo dos requisitos que devem ser desenvolvidos:

- ### Cadastro de um novo usuário
- [x] A API deve receber o nome, e-mail e senha, CPF e data de nascimento do usuário para realizar a criação do usuário. Todos obrigatórios.
- [x] Será um diferencial conseguir armazenar a senha em forma de hash. Lembre-se,segurança é muito importante!
- [x] Deve ser gerado automaticamente um ID para o usuário.
- [x] Não deve permitir criar dois usuários com o mesmo e-mail, nem o mesmo CPF, senão isso daria uma boa confusão.

- ### Listagem de usuários
- [x] A API deve ser capaz de retornar a lista de todos os usuários cadastrados previamente. Além disso, caso seja chamado o método de listagem, e não existir nenhum usuário cadastrado, deve-se retornar o HTTP Code correto, com mensagem de tratamento.

- ### Listagem de usuário por Id
- [x] A API deve possuir um método para retornar um usuário, recebendo como parâmetro o Id de identificação dele. Novamente, lembre-se de tratar as exceções, como Id inválido, que deve retornar uma mensagem adequada para quem estiver utilizando o método.

- ### Atualização de informações do usuário por Id
- [x] A API deve possuir um método para atualização dos dados de um usuário previamente cadastrado, passando como parâmetro o Id de identificação dele. Lembre-se, Id inválido, deve retornar o tratamento adequado.
- [x] Caso seja informado um e-mail e/ou um CPF na alteração, que já esteja em uso por outro usuário cadastrado, deve barrar a alteração, e devolver mensagem adequada.
- [x] Em caso de sucesso, informar que a alteração foi realizada, e retornar os dados
atualizados do usuário



