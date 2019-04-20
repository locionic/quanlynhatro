drop database QuanLyNhaTro03
go
create database QuanLyNhaTro03
go
use QuanLyNhaTro03
go
create table LOAIPHONG
(
	STYLE int primary key not null,
	PRICE float,
)
go
create table PHONGTRO
(
	IDROOM char(2) primary key not null,
	STYLE int,
	STATE int,
	FLOOR int,
	constraint fk_PHONGTRO_LOAIPHONG foreign key(STYLE) references LOAIPHONG(STYLE)
)
go
create table KHACHTRO
(
	CMND int primary key not null,
	SDT varchar(12),
	NAME varchar(50),
	BIRTHDAY date,
	BIRTHPLACE varchar(50),
	IDROOM char(2),
	constraint fk_KHACHTRO_PHONGTRO foreign key(IDROOM) references PHONGTRO(IDROOM)
)
go
CREATE FUNCTION AUTO_IDHD()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(IDHOADON) FROM HOADON) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(IDHOADON, 3)) FROM HOADON
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
create table HOADON
(
	IDHOADON varchar(5) primary key default dbo.auto_idhd(),
	ELECTRICMONEY FLOAT,
	WATERMONEY FLOAT,
	INTERNETMONEY FLOAT,
	LIVINGEXPENSE FLOAT,
	IDROOM char(2)
	constraint fk_HOADON_PHONGTRO foreign key(IDROOM) references PHONGTRO(IDROOM)
)
create table account
(
	USERNAME varchar(20) PRIMARY KEY,
	PASSWORD varchar(20),
)
go
insert into account values ('hongthuan', '1234')
go
insert into loaiphong values (0, 1000), (1,2000), (2, 3000)
insert into phongtro values ('11', 0, 0, 1), ('12', 1, 0, 1), ('13', 2, 0, 1), ('14', 0, 1, 1), ('15', 1, 1, 1), ('16', 2, 1, 1)
						,('21', 0, 0, 2), ('22', 1, 0, 2), ('23', 2, 0, 2), ('24', 0, 1, 2), ('25', 1, 1, 2), ('26', 2, 1, 2)
						,('31', 0, 0, 3), ('32', 1, 0, 3), ('33', 2, 0, 3), ('34', 0, 1, 3), ('35', 1, 1, 3), ('36', 2, 1, 3)
insert into khachtro values (123456781, '84123456781', 'Mot', '2000-04-17', 'Thanh pho 1', '14')
							,(123456782, '84123456782', 'Hai', '2000-04-18', 'Thanh pho 2', '15')
							,(123456783, '84123456783', 'Ba', '2000-04-19', 'Thanh pho 3', '16')
							,(123456784, '84123456784', 'Bon', '2000-04-20', 'Thanh pho 4', '24')
							,(123456785, '84123456785', 'Nam', '2000-04-21', 'Thanh pho 5', '25')
							,(123456786, '84123456786', 'Sau', '2000-04-22', 'Thanh pho 6', '26')
							,(123456787, '84123456787', 'Bay', '2000-04-23', 'Thanh pho 7', '34')
							,(123456788, '84123456788', 'Tam', '2000-04-24', 'Thanh pho 8', '35')
							,(123456789, '84123456789', 'Chin', '2000-04-25', 'Thanh pho 9', '36')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 101, 50, 50, '14')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(110, 101, 50, 100, '15')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 101, 100, 50, '16')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(150, 100, 50, 50, '24')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 150, 50, 50, '25')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 100, 100, 100, '26')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 101, 100, 50, '34')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(100, 101, 100, 100, '35')
insert into hoadon(electricmoney, watermoney, internetmoney, livingexpense, idroom) values(130, 101, 50, 50, '36')
						

SELECT *
FROM phongtro