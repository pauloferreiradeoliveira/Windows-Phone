 CREATE DATABASE bdCaixa
 GO
 use bdCaixa
--DROP DATABASE bdCaixa

CREATE TABLE tblCliente (
	IdCliente INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150) NOT NULL,
	CPF VARCHAR(14) NOT NULL UNIQUE,
	DataNacimento DATE NOT NULL,

)
GO
CREATE TABLE tblVenda (
	IdVenda INT PRIMARY KEY IDENTITY(1,1),
	DataCompra DATE NOT NULL,
	ValorTotal SMALLMONEY NOT NULL,
	NumVenda DECIMAL NOT NULL UNIQUE,
	CodigoFiscal VARCHAR(100) NOT NULL UNIQUE
	)
GO
CREATE TABLE tblVendaCliente (
	IdVendaCliente INT PRIMARY KEY IDENTITY(1,1),
	IdCliente INT NOT NULL FOREIGN KEY
		REFERENCES tblCliente(IdCliente),
	IdVenda INT NOT NULL FOREIGN KEY
		REFERENCES tblVenda(IdVenda)
)
GO
CREATE TABLE tblProduto (
	IdProduto INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150) NOT NULL,
	Valor SMALLMONEY NOT NULL,
	Descricao VARCHAR(5000) NOT NULL,
	)
GO
CREATE TABLE tblProdutoVenda (
	id INT PRIMARY KEY IDENTITY(1,1),
	IdVenda INT NOT NULL FOREIGN KEY
		REFERENCES tblVenda(IdVenda),
	IdProduto INT NOT NULL FOREIGN KEY
		REFERENCES tblProduto(IdProduto)
	)
GO
CREATE TABLE tblLote (
	IdLote INT PRIMARY KEY IDENTITY(1,1),
	DataCompra DATE NOT NULL,
	DataVencimento DATE,
	IdProduto INT NOT NULL FOREIGN KEY
		REFERENCES tblProduto(IdProduto)
	)

GO

CREATE TABLE tblFuncionario(
	IdFuncionario INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150) NOT NULL,
	CPF VARCHAR(14) NOT NULL UNIQUE,
	DataNacimento DATE NOT NULL,
	Matricula INT NOT NULL UNIQUE
)
GO
CREATE TABLE tblVendaFuncionario(
	IdVendaFuncionario INT PRIMARY KEY IDENTITY(1,1),
	IdFuncinario INT NOT NULL FOREIGN KEY
		REFERENCES tblFuncionario(IdFuncionario),
	IdVenda INT NOT NULL FOREIGN KEY
		REFERENCES tblVenda(IdVenda)
)