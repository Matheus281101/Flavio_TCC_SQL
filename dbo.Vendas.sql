CREATE TABLE [dbo].[Vendas] (
    [Ano_Mes]        INT             IDENTITY (1, 1) NOT NULL,
    [ID_NF]          INT             NOT NULL,
    [Cod_Produto]    INT             NOT NULL,
    [Produto]        VARCHAR (40)    NOT NULL,
    [Quantidade]     DECIMAL (10, 2) NOT NULL,
    [Valor_unitario] DECIMAL (10, 2) NOT NULL,
    [Valor_total]    DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Ano_Mes] ASC)
);

