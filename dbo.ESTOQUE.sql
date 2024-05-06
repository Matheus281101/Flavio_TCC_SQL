CREATE TABLE [dbo].[ESTOQUE] (
    [ID_Produto] INT             IDENTITY (1, 1) NOT NULL,
    [Produto]    VARCHAR (50)    NOT NULL,
    [Tipo]       VARCHAR (20)    NOT NULL,
    [Preço_UNI]  DECIMAL (10, 2) NOT NULL,
    [Quantidade] INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Produto] ASC)
);

