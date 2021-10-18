DROP DATABASE IF EXISTS creditCeleste;
CREATE DATABASE creditCeleste;
use creditCeleste;



DROP TABLE IF EXISTS CLIENT;
CREATE TABLE CLIENT(
        num    Int PRIMARY KEY ,
        nom    Varchar (50) NOT NULL ,
        nomJeuneFille     Varchar (50) NOT NULL ,
        prenom Varchar (50) NOT NULL ,
        adresse Varchar (50) NOT NULL ,
        codePostal     Int NOT NULL ,
        dateNaissance date NOT NULL,
        revenu  Int NOT NULL,
        profession      Varchar(50) NOT NULL,
        ville  Varchar (50) NOT NULL
);

DROP TABLE IF EXISTS CONCESSION;
CREATE TABLE CONCESSION(
        idConcession     Int PRIMARY KEY ,
        nomConcession    Varchar (50) NOT NULL ,
        numRueConcession Int NOT NULL ,
        rueConcession    Varchar (50) NOT NULL ,
        CPConcession     Int NOT NULL ,
        villeConcession  Varchar (50) NOT NULL
);



DROP TABLE IF EXISTS VENDEUR;
CREATE TABLE VENDEUR(
        idVendeur     Int PRIMARY KEY ,
        nomVendeur    Varchar (50) NOT NULL ,
        prenomVendeur Varchar (50) NOT NULL ,
        idConcession  Int NOT NULL

	,CONSTRAINT VENDEUR_CONCESSION_FK FOREIGN KEY (idConcession) REFERENCES CONCESSION(idConcession)
);


DROP TABLE IF EXISTS VEHICULE;
CREATE TABLE VEHICULE(
        numImmat      Varchar (50) PRIMARY KEY,
        datePremImmat Varchar (50) NOT NULL ,
        anneeModele   Varchar (50) NOT NULL ,
        numSerie      Varchar (50) NOT NULL ,
        puissance     Varchar (50) NOT NULL ,
        numClient     Int ,
        idVendeur     Int ,
        idConcession  Int NOT NULL

	--,CONSTRAINT VEHICULE_CLIENT_FK FOREIGN KEY (numClient) REFERENCES CLIENT(num)
	,CONSTRAINT VEHICULE_VENDEUR0_FK FOREIGN KEY (idVendeur) REFERENCES VENDEUR(idVendeur)
	,CONSTRAINT VEHICULE_CONCESSION1_FK FOREIGN KEY (idConcession) REFERENCES CONCESSION(idConcession)
);

DROP TABLE IF EXISTS NIVEAU;
CREATE TABLE NIVEAU(
        CodeNiveau     Int PRIMARY KEY ,
        Libelle        Varchar (50) NOT NULL ,
        TauxCommission Float NOT NULL
);


DROP TABLE IF EXISTS CREDIT;
CREATE TABLE CREDIT(
        montantFinance   Int PRIMARY KEY ,
        duree     Varchar (50) NOT NULL ,
        taux       Int NOT NULL ,
        mensualite Int NOT NULL ,
        idVendeur        Int NOT NULL ,
        num        Int NOT NULL ,
        CodeNiveau       Int NOT NULL


	,CONSTRAINT CREDIT_VENDEUR_FK FOREIGN KEY (idVendeur) REFERENCES VENDEUR(idVendeur)
	--,CONSTRAINT CREDIT_CLIENT0_FK FOREIGN KEY (num) REFERENCES CLIENT(num)
	,CONSTRAINT CREDIT_NIVEAU1_FK FOREIGN KEY (CodeNiveau) REFERENCES NIVEAU(CodeNiveau)
);


DROP TABLE IF EXISTS MTFIN;
CREATE TABLE MTFIN(
        MtFin Float PRIMARY KEY
);

DROP TABLE IF EXISTS NBMENS;
CREATE TABLE NBMENS(
        NbMens Int PRIMARY KEY
);

DROP TABLE IF EXISTS commissionner;
CREATE TABLE commissionner(
        CodeNiveau Int PRIMARY KEY ,
        MtFin      Float NOT NULL ,
        NbMens     Int NOT NULL

	,CONSTRAINT commissionner_NIVEAU_FK FOREIGN KEY (CodeNiveau) REFERENCES NIVEAU(CodeNiveau)
	,CONSTRAINT commissionner_MTFIN0_FK FOREIGN KEY (MtFin) REFERENCES MTFIN(MtFin)
	,CONSTRAINT commissionner_NBMENS1_FK FOREIGN KEY (NbMens) REFERENCES NBMENS(NbMens)
);

