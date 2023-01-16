/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Utilisateur
------------------------------------------------------------*/
CREATE TABLE Utilisateur(
	id_user     INT IDENTITY (1,1) NOT NULL ,
	username    VARCHAR (50) NOT NULL ,
	firstname   VARCHAR (50) NOT NULL ,
	lastname    VARCHAR (50) NOT NULL ,
	password    VARCHAR (20) NOT NULL ,
	role        VARCHAR (50) NOT NULL ,
	etat        VARCHAR (5) NOT NULL  ,
	CONSTRAINT Utilisateur_PK PRIMARY KEY (id_user)
);


/*------------------------------------------------------------
-- Table: Facture
------------------------------------------------------------*/
CREATE TABLE Facture(
	num_fac   VARCHAR (255) NOT NULL ,
	ordre      INT IDENTITY (1,1) NOT NULL ,
	cleint     VARCHAR (255) NOT NULL ,
	date_to    DATETIME NOT NULL ,
	time_to    TIME (2) NOT NULL ,
	etat       VARCHAR (20) NOT NULL ,
	id_user    INT  NOT NULL  ,
	CONSTRAINT Facture_PK PRIMARY KEY (num_fac)

	,CONSTRAINT Facture_Utilisateur_FK FOREIGN KEY (id_user) REFERENCES Utilisateur(id_user)
);


/*------------------------------------------------------------
-- Table: Produit
------------------------------------------------------------*/
CREATE TABLE Produit(
	code          VARCHAR (50) NOT NULL ,
	designation   VARCHAR (255) NOT NULL  ,
	CONSTRAINT Produit_PK PRIMARY KEY (code)
);


/*------------------------------------------------------------
-- Table: Concerner
------------------------------------------------------------*/
CREATE TABLE Concerner(
	facture   VARCHAR (255) NOT NULL ,
	produit       VARCHAR (50) NOT NULL ,
	prix       MONEY  NOT NULL ,
	quantite   INT  NOT NULL  ,
	CONSTRAINT Concerner_PK PRIMARY KEY (facture,produit)

	,CONSTRAINT Concerner_Facture_FK FOREIGN KEY (facture) REFERENCES Facture(num_fac)
	,CONSTRAINT Concerner_Produit0_FK FOREIGN KEY (produit) REFERENCES Produit(code)
);



