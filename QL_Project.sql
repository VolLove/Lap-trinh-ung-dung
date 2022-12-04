
--DROP DATABASE PROJECT
go
CREATE DATABASE PROJECT
go
USE PROJECT
go


CREATE TABLE DONHANG(
	MaDonHang varchar(10) not null PRIMARY KEY,
	DiachiGui nvarchar(100) not null,
	DiachiNhan nvarchar(100) not null,
	CCCDNhan varchar(12) not null,
	CCCDGui varchar(12) not null,
	MieuTa nvarchar(200),
	KhoiLuong float,
	KichThuoc float,
	Cuoc int,
	MaNV varchar(10) not null
)
go
CREATE TABLE KHACHHANG(
	CanCuocCD varchar(12) not null primary KEY,
	Phai nvarchar(5),
	HovaTen nvarchar(50),
	DiaChi nvarchar(50) ,
	SDT varchar(10)
)
go


CREATE TABLE NHANVIEN(
	MaNV varchar(10) not null primary key,
	HovaTen nvarchar(50),
	NgSinh date ,
	DiaChi nvarchar(50),
	CanCuoc varchar(12) ,
	SDT varchar(10),
	Phai nvarchar(5),
	Luong float,
	MaPhong varchar(10) not null

)
GO
CREATE TABLE PHONGBAN(
	MaPhong varchar(10) not null primary key,
	MaQL varchar(10) not null,
	TenPhong nvarchar(30),
)
GO

--CREATE FOREIGN KEY
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_NVHD FOREIGN KEY(MaNV) REFERENCES dbo.NHANVIEN(MaNV)
go
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_KHNhan FOREIGN KEY(CCCDNhan) REFERENCES dbo.KHACHHANG(CanCuocCD)
go
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_KHGUI FOREIGN KEY(CCCDGui) REFERENCES dbo.KHACHHANG(CanCuocCD)
go
ALTER TABLE dbo.PHONGBAN ADD CONSTRAINT FK_MQL FOREIGN KEY(MaQL) REFERENCES dbo.NHANVIEN(MaNV)
go
alter table dbo.NHANVIEN ADD CONSTRAINT FK_Phong foreign key(MaPhong) references dbo.PHONGBAN(MaPhong)


