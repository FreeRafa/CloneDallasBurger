CREATE DATABASE CloneDallasBurger;
 
USE CloneDallasBurger;


CREATE TABLE Funcionario(
FuncionarioId INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(100) NOT NULL,
Cargo VARCHAR(50)  NOT NULL, -- Garcom, Gerente, Cozinha, Caixa
Usuario VARCHAR(50)  NOT NULL UNIQUE,
SenhaHash VARCHAR(255) NOT NULL,
Ativo BIT          NOT NULL DEFAULT 1,
DataCadastro DATETIME     NOT NULL DEFAULT GETDATE()
);
GO
 
CREATE TABLE Mesa(
MesaId INT IDENTITY(1,1) PRIMARY KEY,
Numero INT NOT NULL UNIQUE,
Capacidade INT NOT NULL DEFAULT 4,
Status VARCHAR(20) NOT NULL DEFAULT 'Livre'
       CHECK (Status IN ('Livre','Ocupada','Reservada','Manutencao')),
Ativa BIT NOT NULL DEFAULT 1
);
GO
 
CREATE TABLE Categoria(
CategoriaId INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(50) NOT NULL UNIQUE,
Ordem INT NOT NULL DEFAULT 0
);
GO
 
CREATE TABLE Ingrediente(
IngredienteId INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(100) NOT NULL,
Tipo VARCHAR(30) NOT NULL
     CHECK (Tipo IN ('Molho','Queijo','Proteina','Vegetal','Extra')),
PrecoAdicional DECIMAL(6,2) NOT NULL DEFAULT 0, -- preco quando adicionado extra
Vegano BIT NOT NULL DEFAULT 0,
DisponivelComoExtra BIT NOT NULL DEFAULT 0 -- se true, aparece na lista de "adicionar extra" no pedido
);
GO
 

CREATE TABLE Produto(
ProdutoId INT IDENTITY(1,1) PRIMARY KEY,
CategoriaId INT NOT NULL FOREIGN KEY REFERENCES Categoria(CategoriaId),
Nome VARCHAR(100) NOT NULL,
Descricao VARCHAR(500) NULL,
Preco DECIMAL(6,2) NOT NULL,
Vegano BIT NOT NULL DEFAULT 0,
PermiteTrocaProteina BIT NOT NULL DEFAULT 0, 
Disponivel BIT NOT NULL DEFAULT 1
);
GO
 

CREATE TABLE ProdutoIngrediente(
ProdutoId INT NOT NULL FOREIGN KEY REFERENCES Produto(ProdutoId),
IngredienteId INT NOT NULL FOREIGN KEY REFERENCES Ingrediente(IngredienteId),
Removivel BIT NOT NULL DEFAULT 1,
PRIMARY KEY (ProdutoId, IngredienteId)
);
GO
 
CREATE TABLE Pedido(
PedidoId INT IDENTITY(1,1) PRIMARY KEY,
MesaId INT NOT NULL FOREIGN KEY REFERENCES Mesa(MesaId),
FuncionarioId INT NOT NULL FOREIGN KEY REFERENCES Funcionario(FuncionarioId),
NumeroPessoas INT NOT NULL DEFAULT 1, -- quantidade de pessoas na mesa, usado para dividir a conta
[Status] VARCHAR(20) NOT NULL DEFAULT 'Aberto'
         CHECK (Status IN ('Aberto','EmPreparo','Entregue','Fechado','Cancelado')),
DataAbertura DATETIME NOT NULL DEFAULT GETDATE(),
DataFechamento DATETIME NULL,
FormaPagamento VARCHAR(20) NULL
               CHECK (FormaPagamento IN ('Cartao')), -- por enquanto so cartao; campo pronto pra receber outras formas depois
ValorTotal DECIMAL(8,2) NULL,     -- preenchido no fechamento da conta
ValorPorPessoa DECIMAL(8,2) NULL,     -- ValorTotal / NumeroPessoas, preenchido no fechamento
Observacao VARCHAR(300) NULL
);
GO
 

CREATE TABLE ItemPedido(
ItemPedidoId INT IDENTITY(1,1) PRIMARY KEY,
PedidoId INT NOT NULL FOREIGN KEY REFERENCES Pedido(PedidoId),
ProdutoId INT NOT NULL FOREIGN KEY REFERENCES Produto(ProdutoId),
Quantidade INT NOT NULL DEFAULT 1,
PrecoUnitario DECIMAL(6,2) NOT NULL, -- preco no momento do pedido (historico)
Observacao VARCHAR(300) NULL,
[Status] VARCHAR(20) NOT NULL DEFAULT 'Pendente'
         CHECK (Status IN ('Pendente','EmPreparo','Pronto','Entregue','Cancelado'))
);
GO
 

CREATE TABLE ItemPedidoPersonalizacao (
PersonalizacaoId INT IDENTITY(1,1) PRIMARY KEY,
ItemPedidoId INT NOT NULL FOREIGN KEY REFERENCES ItemPedido(ItemPedidoId),
IngredienteId INT NOT NULL FOREIGN KEY REFERENCES Ingrediente(IngredienteId),
Acao VARCHAR(10) NOT NULL CHECK (Acao IN ('Adicionar','Remover')),
PrecoAdicional DECIMAL(6,2) NOT NULL DEFAULT 0
);
GO
 