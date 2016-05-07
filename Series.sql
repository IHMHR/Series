/*USE master;
Drop DATABASE series;*/
--CREATE DATABASE series;
USE series;
GO

CREATE TABLE situacao (
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
situacao VARCHAR(20) NOT NULL
);
GO

INSERT INTO situacao (situacao) VALUES ('Em andamento'),('Cancelada'),('Concluída'),('Em Produção');

CREATE TABLE seriado (
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
seriado VARCHAR(35) NOT NULL,
descricao VARCHAR(150) NOT NULL,
temporadas SMALLINT NOT NULL,
imdb_nota NUMERIC(3,1) NOT NULL,
lancamento_data DATE NOT NULL,
ultima_exibicao DATE NULL,
situacaoID INT NOT NULL,

CONSTRAINT fk_Situacao FOREIGN KEY (situacaoID) REFERENCES situacao(id)
);
GO

CREATE TABLE loja (
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
loja VARCHAR(35) NOT NULL,
telefone VARCHAR(20) NOT NULL,
);
GO

INSERT INTO loja (loja,telefone) VALUES ('Submarino','4003-2000'),('Americanas','4003-1000'),('Saraiva','(11) 4003-3390'),('Extra','11 3004-6262'),('Walmart','(11) 3003 6080');

CREATE TABLE acesso (
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
dt_acesso DATETIME NOT NULL DEFAULT GETDATE(),
vlr_Total DECIMAL(12,2) NOT NULL,
parcelas SMALLINT NOT NULL,
vlr_Parcelas DECIMAL(12,5) NOT NULL,
vlr_frete DECIMAL(12,2) NOT NULL,
tipo_frete VARCHAR(35) NULL,
tmp_frete INT NOT NULL,
url VARCHAR(MAX) NOT NULL,
lojaID INT NOT NULL,
seriadoID INT NOT NULL,

CONSTRAINT fk_loja FOREIGN KEY (lojaID) REFERENCES loja(id),
CONSTRAINT fk_seriado FOREIGN KEY (seriadoID) REFERENCES seriado(id)
);
GO

CREATE PROCEDURE usp_InserirSeriado
  @seriado VARCHAR(35),
  @descricao VARCHAR(150),
  @temporadas SMALLINT,
  @imdb_nota NUMERIC(3,1),
  @lancamento_data DATE,
  @ultima_exibicao DATE = NULL,
  @situacaoID INT
AS
  BEGIN
    BEGIN TRY

	BEGIN TRAN
	  INSERT INTO seriado (seriado,descricao,temporadas,imdb_nota,lancamento_data,ultima_exibicao,situacaoID)
	  VALUES (@seriado,@descricao,@temporadas,@imdb_nota,@lancamento_data,@ultima_exibicao,@situacaoID);
	COMMIT

	END TRY
	BEGIN CATCH

	END CATCH
  END
GO

CREATE PROCEDURE usp_InserirVisita
  @dt_acesso DATETIME,
  @vlr_Total DECIMAL(12,2),
  @parcelas SMALLINT,
  @vlr_frete DECIMAL(12,2),
  @tipo_frete VARCHAR(35),
  @tmp_frete INT,
  @url VARCHAR(MAX),
  @lojaID INT,
  @seriadoID INT
AS
  BEGIN
    BEGIN TRY
	
	BEGIN TRAN
	  INSERT INTO acesso (dt_acesso,vlr_Total,parcelas,vlr_Parcelas,vlr_frete,tmp_frete,tipo_frete,url,lojaID,seriadoID)
	  VALUES (@dt_acesso,@vlr_Total,@parcelas,(@vlr_total/@parcelas),@vlr_frete,@tmp_frete,@tipo_frete,@url,@lojaID,@seriadoID);
	COMMIT

	END TRY
	BEGIN CATCH
	  ROLLBACK TRAN;
	  SELECT ERROR_MESSAGE() AS 'Erro na transação';
	END CATCH
  END
GO

EXEC usp_InserirSeriado 'House M.D.','An antisocial maverick doctor who specializes in diagnostic medicine does whatever it takes to solve puzzling cases that come his way using his crack team of doctors and his wits.',8,8.8,'2004-11-16','2012-05-21',3
EXEC usp_InserirSeriado 'Dexter','Dexter Morgan is a Forensics Expert, a loyal brother, boyfriend, and friend. That''s what he seems to be, but that''s not what he really is. Dexter Morgan is a Serial Killer that hunts the bad.',8,8.8,'2006-10-01','2013-09-22',3
EXEC usp_InserirSeriado 'Two and a Half Men','A hedonistic jingle writer''s free-wheeling life comes to an abrupt halt when his brother and 10-year-old nephew move into his beach-front house.',12,7.1,'2003-09-22','2015-02-19',3
EXEC usp_InserirSeriado 'Fringe','An FBI agent is forced to work with an institutionalized scientist and his son in order to rationalize a brewing storm of unexplained phenomena.',5,8.5,'2008-9-9','2013-01-18',3
EXEC usp_InserirSeriado 'Friends','Follows the lives of six 20-something friends living in Manhattan.',10,9,'1994-09-22','2004-05-06',3
EXEC usp_InserirSeriado 'Supernatural','Two brothers follow their father''s footsteps as "hunters" fighting evil supernatural beings of many kinds including monsters, demons, and gods that roam the earth.',11,8.6,'2005-09-13',NULL,1
EXEC usp_InserirSeriado 'Prison Break','Due to a political conspiracy, an innocent man is sent to death row and his only hope is his brother, who makes it his mission to deliberately get himself sent to the same prison in order to break the both of them out, from the inside out.',5,8.5,'2005-08-29','2009-05-15',3


CREATE VIEW vwSeriados AS
  SELECT
    seriado AS Seriado,
	descricao AS Descrição,
	temporadas AS 'Nº Temporadas',
	imdb_nota AS 'Nota IMDB',
	CONVERT(VARCHAR(12),lancamento_data, 103) AS 'Data Lançamento',
	CONVERT(VARCHAR(12),ultima_exibicao, 103) AS 'Ultima exibição',
	situacao AS Situação
  FROM
    seriado LEFT JOIN situacao ON seriado.situacaoID = situacao.id
GO


EXEC usp_InserirVisita '2016-04-10 21:15:00',149.90,3,9.14,'econômica',7,'http://www.americanas.com.br/produto/122339441/dvd-prison-break-a-colecao-completa-incluindo-o-resgate-final-23-discos-',2,7
EXEC usp_InserirVisita '10/04/2016 21:15:45',149.90,3,9.14,'econômica',7,'http://www.submarino.com.br/produto/122339441/dvd-prison-break-a-colecao-completa-incluindo-o-resgate-final-23-discos-',1,7


ALTER VIEW vwSitesAcessados AS
  SELECT
    seriado AS 'Seriado',
	temporadas AS 'Nº Temporadas',
	CONVERT(CHAR(10),dt_acesso,103) AS 'Data Acessado',
	loja AS 'Loja',
	'R$ ' + CAST(vlr_Total AS VARCHAR) AS'Valor Coleção',
	parcelas AS 'Qnt Parcelas',
	'R$ ' + CAST(CAST(vlr_Parcelas AS DECIMAL(9,2)) AS VARCHAR) AS 'Valor Parcelas',
	'R$ ' + CAST(vlr_frete AS VARCHAR) AS 'Valor frete',
	tipo_frete AS 'Entrega',
	CAST(tmp_frete AS VARCHAR(3)) + ' Dias úteis' AS 'Tempo de Espera',
	url AS 'Link'
  FROM
    acesso LEFT JOIN loja ON acesso.lojaID = loja.id
	INNER JOIN seriado ON acesso.seriadoID = seriado.id
GO
