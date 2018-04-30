SELECT *
FROM TblCliente
WHERE Nome LIKE 'M%'

INSERT INTO TblCliente(Nome, CPF, DataNascimento)
VALUES
--('Roberto', '000.652.965-44', '1984-05-25'),
('Maria', '040.456.765-44', '2000-02-22'),
('José', '234.456.124-54', '1968-03-12')

UPDATE TblCliente SET
DataNascimento = '1999-03-22',
CPF = '125.658.695-87'
WHERE IdCliente = 2

DELETE 
FROM TblCliente 
WHERE IdCliente = 2
