CREATE TABLE VARE
(    ID            INT IDENTITY (1,1)    NOT NULL,
    Varenavn    VARCHAR(50)            NOT NULL,
    VareBeskrivelse    VARCHAR(50),
    Antal        INT                    NOT NULL,
    Indkøbspris    DECIMAL                 NOT NULL,
    Fortjeneste DECIMAL                NOT NULL,
    Udsalgspris    AS (CONVERT(DECIMAL(10,2), Indkøbspris * Fortjeneste/100+Indkøbspris)),
PRIMARY KEY (ID));

  
  INSERT INTO VARE(Varenavn,VareBeskrivelse,Antal,Indkøbspris, Fortjeneste)
  VALUES ('Computer','Elektronik',4,3199, 50),
		 ('Telefon','Elektronik',5,2199, 75),
		 ('SmartWatch','Elektronik',8,1500, 66),
		 ('Højtaler','Elektronik',2,4199, 55),
		 ('SSD','HardWare',10,499, 90),
		 ('GrafikKort','HardWare',5,2000, 50),
		 ('MotherBoard','HardWare',1,1300, 50),
		 ('CPU','HardWare',9,2500, 0.25),
		 ('CPU Køler','HardWare',4,1499, 0.30),
		 ('HDD','HardWare',5,800, 0.45);
		 
		 SELECT *
		 FROM VARE