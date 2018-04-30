
use bdCaixa

--   ---------------------- Cliente ------------------------------ --
INSERT INTO tblCliente(Nome, CPF, DataNacimento)
VALUES
('Roberto', '000.652.965-44', '1984-05-25'),
('Maria', '040.456.765-44', '2000-02-22'),
('José', '234.456.124-54', '1968-03-12'),
('Maria', '440.456.767-78', '2000-02-22'),
('Maria', '140.456.767-43', '2011-12-11')

SELECT * FROM tblCliente 

UPDATE tblCliente SET
DataNacimento = '1999-03-22',
CPF = '125.658.695-87'
WHERE IdCliente = 2

DELETE 
FROM tblCliente 
WHERE IdCliente = 8
-- --------------------------------------------------------------------- --

--   ---------------------- Venda ------------------------------ --
INSERT INTO tblVenda(DataCompra, ValorTotal, NumVenda, CodigoFiscal)
VALUES
('2015-05-25', 66.77 , 115,'c11' ),
('2015-05-25', 665.77, 111, 'c12'),
('2015-05-25', 456.77, 112,'c13'),
('1944-05-25', 686.55, 113, 'c14'),
('1994-05-25', 669.79, 114,'c15')

SELECT * FROM tblVenda

UPDATE tblVenda SET
ValorTotal = 600.90
WHERE IdVenda = 4

DELETE 
FROM tblVenda 
WHERE IdVenda = 3
-- --------------------------------------------------------------------- --

--   ---------------------- Venda Cliente ------------------------------ --
INSERT INTO tblVendaCliente(idCliente,idVenda)
VALUES
(1,2),
(3,2),
(4,4),
(4,5),
(1,1)

SELECT * FROM tblVendaCliente

UPDATE tblVendaCliente SET
idCliente = 1
WHERE IdVendaCliente = 4

DELETE 
FROM tblVendaCliente 
WHERE IdVendaCliente = 2
-- --------------------------------------------------------------------- --

--   ---------------------- Funcionario ------------------------------ --
INSERT INTO tblFuncionario(Nome, CPF, DataNacimento, Matricula)
VALUES
('Roberto', '000.652.965-44', '1984-05-25',44),
('Maria', '040.456.765-44', '2000-02-22', 23),
('José', '234.456.124-54', '1968-03-12', 45),
('Maria', '440.456.767-78', '2000-02-22',89),
('Maria', '140.456.767-43', '2011-12-11',77)

SELECT * FROM tblFuncionario

UPDATE tblFuncionario SET
Nome = 'Marcos'
WHERE IdFuncionario = 5

DELETE 
FROM tblFuncionario
WHERE IdFuncionario = 3
-- --------------------------------------------------------------------- --
--   ---------------------- Funcionario Venda ------------------------------ --
INSERT INTO tblVendaFuncionario(IdFuncinario,IdVenda)
VALUES
(1,2),
(5,2),
(4,5),
(4,5),
(4,2)

SELECT * FROM tblVendaFuncionario

UPDATE tblVendaFuncionario SET
IdVenda = 1
WHERE IdVendaFuncionario = 4

DELETE 
FROM tblVendaFuncionario
WHERE IdVendaFuncionario = 2
-- --------------------------------------------------------------------- --

--   ---------------------- Produto ------------------------------ --
INSERT INTO tblProduto(Nome, Valor, Descricao)
VALUES
('Escova', 334.99, '-----'),
('Pente',34.99, '-----'),
('Pasta de Dente', 324.99, '-----'),
('Compudador', 24.99, '-----'),
('Resma', 27.92, '-----')

SELECT * FROM tblProduto

UPDATE tblProduto SET
Nome = 'Cartucho'
WHERE IdProduto = 5

DELETE 
FROM tblProduto
WHERE IdProduto = 3
-- --------------------------------------------------------------------- --

--   ---------------------- Produto Venda ------------------------------ --
INSERT INTO tblProdutoVenda(idProduto,idVenda)
VALUES
(1,2),
(5,2),
(4,1),
(4,4),
(4,5)

SELECT * FROM tblProdutoVenda

UPDATE tblProdutoVenda SET
idVenda = 1
WHERE id = 4

DELETE 
FROM tblProdutoVenda
WHERE Id = 2
-- --------------------------------------------------------------------- -- 

--   ---------------------- Lote ------------------------------ --
INSERT INTO tblLote(DataCompra, DataVencimento,IdProduto)
VALUES
('2015-05-25','2015-10-25',1),
('2015-06-25','2015-11-25',2),
('2015-07-25','2015-12-25',2),
('2015-08-25','2016-01-25',2),
('2015-09-25','2016-02-25',1)

SELECT * FROM tblLote

UPDATE tblLote SET
DataCompra = '2014-10-25'
WHERE IdLote = 5

DELETE 
FROM tblLote
WHERE IdLote = 3

-- ------------------- Select INNER JOIN ------------------------------- --
SELECT tblProduto.Nome,tblLote.DataCompra FROM tblProduto INNER JOIN tblLote ON (tblProduto.IdProduto = tblLote.IdProduto)

SELECT tblCliente.Nome as 'Nome do Cliente' ,tblVenda.NumVenda,tblVenda.DataCompra FROM tblCliente
	INNER JOIN tblVendaCliente on tblVendaCliente.IdCliente = tblCliente.IdCliente
	RIGHT JOIN tblVenda on tblVenda.IdVenda = tblVendaCliente.IdVenda
	ORDER BY NumVenda,[Nome do Cliente]

SELECT * FROM tblVenda

UPDATE tblVendaCliente SET
IdCliente = 1
WHERE IdVenda  = 1

SELECT tblProduto.Nome,tblProduto.Descricao,tblVenda.NumVenda FROM tblProduto
	INNER JOIN tblProdutoVenda on tblProdutoVenda.IdProduto = tblProduto.IdProduto
	INNER JOIN tblVenda on tblVenda.IdVenda = tblProdutoVenda.IdVenda
	ORDER BY NumVenda

DELETE
	FROM tblVenda
	WHERE NumVenda = 115

SELECT * FROM tblVenda




	
