CREATE TABLE [dbo].[Cadastro_produtos ] (
    [Cod_Produto] INT            IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (50)   NOT NULL,
    [NF]          INT            NOT NULL,
    [Descricao]   TEXT           NOT NULL,
    [Valor_Uni]   DECIMAL (6, 2) NOT NULL,
    [Quantidade]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Cod_Produto] ASC)
);

