
drop database PROJECT
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
	DiaChi nvarchar(50) not null,
	SDT varchar(10)
)
go


CREATE TABLE NHANVIEN(
	MaNV varchar(10) not null primary key,
	HoNV nvarchar(50) ,
	TenNV nvarchar(30),
	NgSinh date not null,
	DiaChi nvarchar(50),
	CanCuoc varchar(12) not null,
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
go



create proc sp_InsertNhanVien
(@maNV varchar(10), @hoNV nvarchar(50), @tenNV nvarchar(30), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD nvarchar(12), @sdt nvarchar(10), @phai nvarchar(5),@luong float,@maPhong varchar(10))
as
	insert into NHANVIEN(MaNV,HoNV,TenNV,NgSinh,DiaChi,CanCuoc,SDT,Phai,Luong,MaPhong)
	values (@maNV,@hoNV,@tenNV,@ngaySinh,@diaChi,@canCuocCD,@sdt,@phai,@luong,@maPhong)
go

create proc sp_DeleteNhanVien @manv varchar(10)
as
	delete NHANVIEN where MaNV = @manv
go

create proc sp_UpdateNhanVien 
(@maNV varchar(10), @hoNV nvarchar(50), @tenNV nvarchar(30), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD varchar(12), @sdt varchar(10), @phai nvarchar(5),@luong float,@maPhong varchar(10))
as
	update NHANVIEN 
	set
	MaNV = @maNV,
	HoNV = @hoNV,
	TenNV = @tenNV,
	NgSinh = @ngaySinh,
	DiaChi = @diaChi,
	CanCuoc = @canCuocCD,
	SDT = @sdt,
	Phai = @phai,
	Luong = @luong,
	MaPhong = @maPhong
	where MaNV = @maNV;
go

create proc sp_SelectNhanVien
as
	select * from NHANVIEN
go




create proc sp_InsertKhachHang
(@CanCuoc varchar(12),@hovaten nvarchar(50),@diaChi nvarchar(50),@sdt varchar(10))
as
	insert into KHACHHANG(CanCuocCD,HovaTen,DiaChi,SDT)
	values(@CanCuoc,@hovaten,@diaChi,@sdt)
go

create proc sp_DeleteKhachHang
@CanCuoc varchar(12)
as
	delete KHACHHANG where CanCuocCD = @CanCuoc
go

create proc sp_UpdateKhachHang
(@CanCuoc varchar(12),@hovaten nvarchar(50),@diaChi nvarchar(50),@sdt varchar(10))
as
	update KHACHHANG
	set
	CanCuocCD = @CanCuoc,
	HovaTen = @hovaten,
	DiaChi = @diaChi,
	SDT = @sdt
	where CanCuocCD = @CanCuoc
go
create proc sp_SelectKhacHang
as
	select * from KHACHHANG
go




create proc sp_InsertPhongBan
(@maPhong varchar(10) , @maQL varchar(10),@tenPhong nvarchar(30))
as
	insert into PHONGBAN(MaPhong,MaQL,TenPhong)
	values(@maPhong,@maQL,@tenPhong)
go

create proc sp_DeletePhongBan
@maPhongBan varchar(10)
as
	delete PHONGBAN where MaPhong = @maPhongBan
go

create proc sp_UpdatePhongBan
(@maPhong varchar(10) , @maQL varchar(10),@tenPhong nvarchar(30))
as
	update PHONGBAN
	set
	MaPhong = @maPhong,
	MaQL = @maQL,
	TenPhong = @tenPhong
	where MaPhong = @maPhong
go
create proc sp_SelectPhongBan
as
	select * from PHONGBAN
go



create proc sp_InsertDonHang
(@maDonHang varchar(10),@diachiGui nvarchar(100),@diachiNhan nvarchar(100),@cccdNhan varchar(12),@cccdGui varchar(12),@mieuta nvarchar(200),@khoiLuong float, @KichThuoc float, @cuoc int, @maNV varchar(10))
as
	insert into DONHANG(MaDonHang,DiachiGui,DiachiNhan,CCCDGui,CCCDNhan,MieuTa,KhoiLuong,KichThuoc,Cuoc,MaNV)
	values(@maDonHang,@diachiGui,@diachiNhan,@cccdGui,@cccdNhan,@mieuta,@khoiLuong,@KichThuoc,@cuoc,@maNV)
go

create proc sp_DeleteDonHang
@maDonHang varchar(10)
AS
	DELETE dbo.DONHANG WHERE MaDonHang = @maDonHang
GO

CREATE PROC sp_UpdateDonHang
(@maDonHang varchar(10),@diachiGui nvarchar(100),@diachiNhan nvarchar(100),@cccdNhan nvarchar(12),@cccdGui varchar(12),@mieuta varchar(200),@khoiLuong float, @KichThuoc float, @cuoc int, @maNV varchar(10))
AS	
	UPDATE dbo.DONHANG
	set
	MaDonHang = @maDonHang,
	DiachiGui = @diachiGui,
	DiachiNhan = @diachiNhan,
	CCCDGui = @cccdGui,
	CCCDNhan = @cccdNhan,
	MieuTa = @mieuta,
	KhoiLuong = @khoiLuong,
	KichThuoc = @KichThuoc,
	Cuoc = @cuoc,
	MaNV = @maNV
GO

create proc sp_SelectDonHang
as
select * from DONHANG;
go
