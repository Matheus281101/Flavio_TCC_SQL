CREATE TABLE [dbo].[Fornecedor]
(
	CNPJ INT PRIMARY KEY NOT NULL IDENTITY,
    Nome_Fantasia VARCHAR(50) NOT NULL,
    Statuss VARCHAR(12) NOT NULL,
    Contato VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Razao_Social VARCHAR(100) NOT NULL,
    Telefone1 VARCHAR(20) NOT NULL,
    Telefone2 VARCHAR(20),
    Endereço VARCHAR(50) NOT NULL,
    N VARCHAR(10) NOT NULL,
    Complemento VARCHAR(20),
    Bairro VARCHAR(20) NOT NULL,
    CEP VARCHAR(10) NOT NULL,
    Observações TEXT,
)
