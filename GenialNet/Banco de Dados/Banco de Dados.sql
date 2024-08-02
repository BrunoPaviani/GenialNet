INSERT INTO Fornecedores (ID, NOME, CNPJ, TELEFONE, DATACRIACAO, DATAALTERACAO)
VALUES
(1, 'Fornecedor A', '12.345.678/0001-95', '(11) 1234-5678', GETDATE(), GETDATE()),
(2, 'Fornecedor B', '23.456.789/0001-96', '(21) 2345-6789', GETDATE(), GETDATE()),
(3, 'Fornecedor C', '34.567.890/0001-97', '(31) 3456-7890', GETDATE(), GETDATE()),
(4, 'Fornecedor D', '45.678.901/0001-98', '(41) 4567-8901', GETDATE(), GETDATE()),
(5, 'Fornecedor E', '56.789.012/0001-99', '(51) 5678-9012', GETDATE(), GETDATE());


INSERT INTO Produtos (ID, DESCRICAO, MARCA, UNIDADEMEDIDA, VALOR, FORNECEDORID, DATACRIACAO, DATAALTERACAO)
VALUES
(1, 'Produto X', 'Marca X', 'Unidade', 10.00, 1, GETDATE(), GETDATE()),
(2, 'Produto Y', 'Marca Y', 'Unidade', 20.00, 2, GETDATE(), GETDATE()),
(3, 'Produto Z', 'Marca Z', 'Unidade', 30.00, 3, GETDATE(), GETDATE()),
(4, 'Produto W', 'Marca W', 'Unidade', 40.00, 4, GETDATE(), GETDATE()),
(5, 'Produto V', 'Marca V', 'Unidade', 50.00, 5, GETDATE(), GETDATE());


INSERT INTO Enderecos (ID, CEP, LOGRADOURO, COMPLEMENTO, UNIDADE, BAIRRO, LOCALIDADE, UF, IBGE, GIA, DDD, SIAFI, FORNECEDORID, DATACRIACAO, DATAALTERACAO)
VALUES
(1, '01001-000', 'Rua A', 'Apto 101', '1', 'Centro', 'São Paulo', 'SP', '3550308', '0001', '11', '1234', 1, GETDATE(), GETDATE()),
(2, '02002-000', 'Rua B', 'Apto 202', '2', 'Jardim', 'São Paulo', 'SP', '3550308', '0002', '11', '2345', 2, GETDATE(), GETDATE()),
(3, '03003-000', 'Rua C', 'Apto 303', '3', 'Vila', 'São Paulo', 'SP', '3550308', '0003', '11', '3456', 3, GETDATE(), GETDATE()),
(4, '04004-000', 'Rua D', 'Apto 404', '4', 'Bela Vista', 'São Paulo', 'SP', '3550308', '0004', '11', '4567', 4, GETDATE(), GETDATE()),
(5, '05005-000', 'Rua E', 'Apto 505', '5', 'Perdizes', 'São Paulo', 'SP', '3550308', '0005', '11', '5678', 5, GETDATE(), GETDATE());
