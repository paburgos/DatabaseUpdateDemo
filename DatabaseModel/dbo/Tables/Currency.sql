CREATE TABLE [dbo].[Currency] (
    [CurrencyId]   INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [Country]      NVARCHAR (50) NOT NULL,
    [Abbreviation] NVARCHAR (4)  NOT NULL,
    CONSTRAINT [PK__Currency__14470AF03E960332] PRIMARY KEY CLUSTERED ([CurrencyId] ASC)
);



