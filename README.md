# Hashing-Exercises
## Desenvolver um sistema de registro de estudantes para uma universidade. 
O sistema deve ser capaz de cadastrar, 
pesquisar e remover registros de estudantes de forma eficiente. Para isso, utilize uma tabela Hash com colisões 
resolvidas por encadeamento para armazenar os dados dos estudantes para permitir buscas rápidas. 
Para desenvolver o sistema, além das classes relacionadas a Tabela Hash (com colisões resolvidas por 
encadeamento), implemente a classe Estudante com os seguintes campos: 
• int matricula - um identificador único para o estudante. 
• string nome - o nome do estudante. 
• string curso - o curso do estudante. 
Obs: utilize a matrícula como campo chave 
Faça um programa que apresente o seguinte menu de opções: 
1- Inserir um estudante 
2- Remover um estudante. O usuário deve informar a matrícula do estudante a ser removido 
3- Pesquisar um estudante. Caso conste deve-se imprimir todos os dados do estudante, senão deve-se imprimir 
a mensagem: Estudante não cadastrado 
4- Sair 
### O programa deve ler a opção escolhida pelo usuário, ler os dados necessários e fazer o processamento. O programa deve ser executado até que a opção 4 seja escolhida pelo usuário.
