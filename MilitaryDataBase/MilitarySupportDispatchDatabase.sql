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

--CHATPGT

INSERT INTO Volunteers (vol_nameOfOrgan, vol_password, vol_showInform)
VALUES 
    ('VolunteerOrg1', 'volunteer123', 1),
    ('VolunteerOrg2', 'volunteer456', 1),
    ('VolunteerOrg3', 'volunteer789', 0);

-- Заповнення таблиці Military фейковими даними
INSERT INTO Military (mil_nameOfOrgan, mil_password, mil_showInform)
VALUES 
    ('MilitaryOrg1', 'military123', 1),
    ('MilitaryOrg2', 'military456', 0),
    ('MilitaryOrg3', 'military789', 1);

-- Заповнення таблиці InformVol фейковими даними
INSERT INTO InformVol (vol_firstName, vol_lastName, vol_number, vol_post)
VALUES 
    ('John', 'Doe', '1234567890123', 'Volunteer Post 1'),
    ('Jane', 'Smith', '9876543210123', 'Volunteer Post 2'),
    ('Robert', 'Johnson', '4567890123456', 'Volunteer Post 3');

-- Заповнення таблиці InformMil фейковими даними
INSERT INTO InformMil (mil_firstName, mil_lastName, mil_number, mil_post)
VALUES 
    ('Michael', 'Brown', '1111111111111', 'Military Post 1'),
    ('Emily', 'Wilson', '2222222222222', 'Military Post 2'),
    ('David', 'Davis', '3333333333333', 'Military Post 3');

-- Заповнення таблиць Supply та SuccessHistorySupply фейковими даними
INSERT INTO Supply (id_supply, mil_nameOfOrgan, category, name_of_goods, name_of_company, number_of_goods, delivery_location, datetime_add, vol_nameOfOrgan, datetime_accept, is_success, goods_image)
VALUES 
    (1, 'MilitaryOrg1', 'Category1', 'Goods1', 'Company1', 10, 'Location1', '2024-04-30 10:00:00', 'VolunteerOrg1', '2024-05-01 12:00:00', 'Success', 'image1.jpg'),
    (2, 'MilitaryOrg2', 'Category2', 'Goods2', 'Company2', 20, 'Location2', '2024-04-30 11:00:00', 'VolunteerOrg2', '2024-05-01 13:00:00', 'Failed', 'image2.jpg'),
    (3, 'MilitaryOrg3', 'Category3', 'Goods3', 'Company3', 30, 'Location3', '2024-04-30 12:00:00', 'VolunteerOrg3', '2024-05-01 14:00:00', 'Success', 'image3.jpg');

INSERT INTO SuccessHistorySupply (id_supply, mil_nameOfOrgan, category, name_of_goods, name_of_company, number_of_goods, delivery_location, datetime_add, vol_nameOfOrgan, datetime_accept, is_success, goods_image)
VALUES 
    (1, 'MilitaryOrg1', 'Category4', 'Goods4', 'Company4', 40, 'Location4', '2024-04-30 13:00:00', 'VolunteerOrg1', '2024-05-01 15:00:00', 'Success', 'image4.jpg'),
    (2, 'MilitaryOrg2', 'Category5', 'Goods5', 'Company5', 50, 'Location5', '2024-04-30 14:00:00', 'VolunteerOrg2', '2024-05-01 16:00:00', 'Success', 'image5.jpg'),
    (3, 'MilitaryOrg3', 'Category6', 'Goods6', 'Company6', 60, 'Location6', '2024-04-30 15:00:00', 'VolunteerOrg3', '2024-05-01 17:00:00', 'Success', 'image6.jpg');



------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--Верхній і нижній рівні - різні
--SELECT vol_id, vol_password FROM Volunteers WHERE vol_nameOfOrgan COLLATE SQL_Latin1_General_CP1_CS_AS = 'DimaMakota'

--Скидання на місця айді
--WITH UpdateCTE AS (
--    SELECT id_supply,
--           ROW_NUMBER() OVER (ORDER BY id_supply) AS NewRowID
--    FROM Supply
--)
--UPDATE UpdateCTE
--SET id_supply = NewRowID;

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
SELECT * FROM Supply ORDER BY id_supply DESC

--додати чи бажає користувач показувати дані
