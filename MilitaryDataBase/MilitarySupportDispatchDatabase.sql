----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE DataBase MilitaryDatabase

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

use MilitaryDatabase

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table Volunteers(
	vol_id int identity(1,1) PRIMARY KEY not null,
	vol_nameOfOrgan nvarchar(25) not null UNIQUE,
	vol_password nvarchar(25) not null,
	vol_showInform bit DEFAULT 1,
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table Military(
	mil_id int identity(1,1) PRIMARY KEY not null,
	mil_nameOfOrgan nvarchar(25) not null UNIQUE,
	mil_password nvarchar(25) not null,
	mil_showInform bit  DEFAULT 1,
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table InformVol(
	id_volunter int identity(1,1) not null,
	vol_firstName nvarchar(25) not null,
	vol_lastName nvarchar(35) not null,
	vol_number nchar(13) not null,
	vol_post nvarchar(50) not null,
	CONSTRAINT fk_volunteer_id FOREIGN KEY (id_volunter) REFERENCES Volunteers(vol_id)
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table InformMil(
	id_military int identity(1,1) not null,
	mil_firstName nvarchar(25) not null,
	mil_lastName nvarchar(35) not null,
	mil_number nchar(13) not null,
	mil_post nvarchar(50) not null,
	CONSTRAINT fk_military_id FOREIGN KEY (id_military) REFERENCES Military(mil_id)
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table Supply(
	id_supply int PRIMARY KEY not null,
	mil_nameOfOrgan nvarchar(25) not null,
	category nvarchar (30) not null,
	name_of_goods nvarchar(50) not null,
	name_of_company nvarchar(50) not null,
	number_of_goods int not null,
	delivery_location nvarchar(100) not null,
	datetime_add datetime not null,

	vol_nameOfOrgan nvarchar(25),
	datetime_accept datetime,
	is_success nvarchar(25), 

	goods_image nvarchar(MAX),

	CONSTRAINT fk_supply_vol_nameOfOrgan FOREIGN KEY (vol_nameOfOrgan) REFERENCES Volunteers(vol_nameOfOrgan),
    CONSTRAINT fk_supply_mil_nameOfOrgan FOREIGN KEY (mil_nameOfOrgan) REFERENCES Military(mil_nameOfOrgan)
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

create table SuccessHistorySupply(
	id_supply int PRIMARY KEY not null,
	mil_nameOfOrgan nvarchar(25) not null,
	category nvarchar (30) not null,
	name_of_goods nvarchar(50) not null,
	name_of_company nvarchar(50) not null,
	number_of_goods int not null,
	delivery_location nvarchar(100) not null,
	datetime_add datetime not null,

	vol_nameOfOrgan nvarchar(25),
	datetime_accept datetime,
	is_success nvarchar(25),

	goods_image nvarchar(MAX),

	CONSTRAINT fk_success_supply_vol_nameOfOrgan FOREIGN KEY (vol_nameOfOrgan) REFERENCES Volunteers(vol_nameOfOrgan),
    CONSTRAINT fk_success_supply_mil_nameOfOrgan FOREIGN KEY (mil_nameOfOrgan) REFERENCES Military(mil_nameOfOrgan)
)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Fake data
INSERT INTO Volunteers(vol_nameOfOrgan, vol_password, vol_showInform)
VALUES ('DimaMakota', 'Dima1234', 1);
INSERT INTO Volunteers(vol_nameOfOrgan, vol_password, vol_showInform)
VALUES ('AnnaOl', 'Anna1234', 1);
INSERT INTO Volunteers(vol_nameOfOrgan, vol_password, vol_showInform)
VALUES ('Anatolii', 'Anatolii1234', 1);
INSERT INTO Volunteers(vol_nameOfOrgan, vol_password, vol_showInform)
VALUES ('OlegIlin', 'Oleg1234', 1);
INSERT INTO Volunteers(vol_nameOfOrgan, vol_password, vol_showInform)
VALUES ('1', '1', 1);

INSERT INTO Military(mil_nameOfOrgan, mil_password, mil_showInform)
VALUES ('IvanDron', 'Ivan1234', 1);
INSERT INTO Military(mil_nameOfOrgan, mil_password, mil_showInform)
VALUES ('OlegDron', 'Oleg1234', 1);
INSERT INTO Military(mil_nameOfOrgan, mil_password, mil_showInform)
VALUES ('AnnaDron', 'Anna1234', 1);
INSERT INTO Military(mil_nameOfOrgan, mil_password, mil_showInform)
VALUES ('TatianaDron', 'Tatiana1234', 1);
INSERT INTO Military(mil_nameOfOrgan, mil_password, mil_showInform)
VALUES ('1', '1', 1);


INSERT INTO InformVol(vol_firstName, vol_lastName, vol_number, vol_post)
VALUES ('Dima', 'Makota', '+380971241137', 'mdmitry2002@gmail.com');
INSERT INTO InformVol(vol_firstName, vol_lastName, vol_number, vol_post)
VALUES ('Anna', '', '', '');
INSERT INTO InformVol(vol_firstName, vol_lastName, vol_number, vol_post)
VALUES ('', '', '', '');
INSERT INTO InformVol(vol_firstName, vol_lastName, vol_number, vol_post)
VALUES ('Oleg', 'Ilin', '+380971241111', 'oleginin@gmail.com');
INSERT INTO InformVol(vol_firstName, vol_lastName, vol_number, vol_post)
VALUES ('', '', '', '');

INSERT INTO InformMil(mil_firstName, mil_lastName, mil_number, mil_post)
VALUES ('Ivan', 'Dron', '+380971231111', 'ivandron@gmail.com');
INSERT INTO InformMil(mil_firstName, mil_lastName, mil_number, mil_post)
VALUES ('Oleg', 'Drwon', '380971222111', 'olegdron@gmail.com');
INSERT INTO InformMil(mil_firstName, mil_lastName, mil_number, mil_post)
VALUES ('', 'Dron', '', '');
INSERT INTO InformMil(mil_firstName, mil_lastName, mil_number, mil_post)
VALUES ('', '', '', '');
INSERT INTO InformMil(mil_firstName, mil_lastName, mil_number, mil_post)
VALUES ('', '', '', '');

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
