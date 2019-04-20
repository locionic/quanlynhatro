create database quanlynhatro
use quanlynhatro
create table loaiphong
(
	loaiphong bit,
	giatien float,
	primary key(loaiphong)
)

create table phongtro
(
	maphong int not null primary key identity,
	loaiphong bit not null,
	trangthai bit not null,
	daylau int not null,
	constraint fk_phongtro_loaiphong_maphong foreign key(loaiphong) references loaiphong(loaiphong),
)

CREATE TABLE KHACHTRO (
    cmnd int NOT NULL primary key,
	sdt int not null,
    name NVARCHAR(50) NOT NULL,
    ngaysinh date,
	noisinh nvarchar(20),
	maphong int,
	constraint fk_khachtro_phongtro foreign key(KT_IDROOM) references phongtro(maphong)
)
insert into loaiphong values
(0, 1000),
(1, 2000)
insert into phongtro(loaiphong, trangthai) values
(0, 1, 1),
(1, 0, 2)
/*
create procedure sp_khachtro_update
(
    @cmnd int output,
    @sdt int output,
    @ten nvarchar(50),
	@maphong varchar(5)
)
as
    update khachtro set sdt = @sdt, ten = @ten, maphong = @maphong
    where cmnd = @cmnd

create procedure sp_khachtro_insert
(
    @cmnd int output,
    @sdt int output,
    @ten nvarchar(50),
	@maphong varchar(5)
)
as
    insert into khachtro values(@cmnd, @sdt, @ten, @maphong)
*/

