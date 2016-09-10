### MUDANÇAS QUE FIZ NO PROJETO

- Removi comentários de código antigo de outros exercícios e só deixei os que realmente eram úteis.

- Alterei a propriedade "Text" do Form1 para "Caixa Eletrônico".

- Renomeei (usando Refatoração) a classe "Form1" para "FormPrincipal" para ficar com um significado correto.

- Coloquei o "this" em todas as referências a componentes visuais. Todos eles fazem parte das classes Form.

- Coloquei os campos informativos (Titular, Número e Saldo) como ReadOnly. Sâo apenas para informar mesmo.

- Tinha muito código repetido nas operações de banco (DEPOSITO, SAQUE ou TRANSFERENCIA). Então, eu criei algumas melhorias:
	- Criei um Enum chamado TipoOperacao de acordo com a operação a ser executada (DEPOSITO, SAQUE ou TRANSFERENCIA).
	- Criei um Enum chamado TipoComboConta com os tipos de combos que temos no formulário.
	- Criei uma Exception nova para o caso de uma conta não estar selecionada na combo.
	- Adicionei um registro padrão "-- Selecione --" às combos no load do FormPrincipal para mostrar para o usuário que ele deve
	  selecionar uma conta.
	- Criei um método chamado GetContaSelecionada onde passamos como parâmetro o enum criado acima. Dependendo do enum, o método te retorna
	  a conta selecionada na combo de origem (comboContas) ou na combo de destino (comboDestino).
	- Criei um método chamado ExecutaOperacaoBancaria, que usa o Enum TipoOperacao acima para chamar o método correto na instância de conta.
	  Todo o código que antes estava repetido, agora só é feito uma vez como recuperar a(s) conta(s) selecionada(s), recuperar o valor, 
	  tratar as exceções e atualizar os campos no formulário.