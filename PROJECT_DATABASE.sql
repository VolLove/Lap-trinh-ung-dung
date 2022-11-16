
drop database PROJECT
go
CREATE DATABASE PROJECT
go
USE PROJECT
go

drop table DONHANG
GO
drop table KHACHHANG
GO
drop table PHONGBAN
go
drop table NHANVIEN
go



CREATE TABLE DONHANG(
	MaDonHang nvarchar(10) not null PRIMARY KEY,
	DiachiGui nvarchar(100) not null,
	DiachiNhan nvarchar(100) not null,
	CCCDNhan nvarchar(12) not null,
	CCCDGui nvarchar(12) not null,
	MieuTa nvarchar(200),
	KhoiLuong float,
	KichThuoc float,
	Cuoc int,
	MaNV nvarchar(10) not null
)
go
CREATE TABLE KHACHHANG(
	CanCuocCD nvarchar(12) not null primary KEY,
	Ho nvarchar(50) not null,
	Ten nvarchar(30) not null,
	DiaChi nvarchar(50) not null,
	SDT nvarchar(10) not null
)
go

CREATE TABLE NHANVIEN(
	MaNV nvarchar(10) not null primary key,
	HoNV nvarchar(50) not null,
	TenNV nvarchar(30) not null,
	NgSinh date not null,
	DiaChi nvarchar(50) not null,
	CanCuoc nvarchar(12) not null,
	SDT nvarchar(10),
	Phai nvarchar(5),
	Luong float,
	MaPhong nvarchar(10) not null

)
GO
CREATE TABLE PHONGBAN(
	MaPhong nvarchar(10) not null primary key,
	MaQL nvarchar(10) not null,
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

drop proc insertNhanVien
go
drop proc deleteNhanVien
go
drop proc updateNhanVien
go
drop proc selectNhanVien
go

create proc insertNhanvien
(@maNV nvarchar(10), @hoNV nvarchar(50), @tenNV nvarchar(30), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD nvarchar(12), @sdt nvarchar(10), @phai nvarchar(5),@luong float,@maPhong nvarchar(10))
as
	insert into NHANVIEN(MaNV,HoNV,TenNV,NgSinh,DiaChi,CanCuoc,SDT,Phai,Luong,MaPhong)
	values (@maNV,@hoNV,@tenNV,@ngaySinh,@diaChi,@canCuocCD,@sdt,@phai,@luong,@maPhong)
go

create proc deleteNhanVien @manv nvarchar(10)
as
	delete NHANVIEN where MaNV = @manv
go

create proc updateNhanVien 
(@maNV nvarchar(10), @hoNV nvarchar(50), @tenNV nvarchar(30), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD nvarchar(12), @sdt nvarchar(10), @phai nvarchar(5),@luong float,@maPhong nvarchar(10))
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

create proc selectNhanVien
as
	select * from NHANVIEN
go

drop proc insertKhachHang
go
drop proc deleteKhachHang 
go
drop proc updateKhachHang
go
drop proc selectKhachHang
go

create proc insertKhachHang
(@CanCuoc nvarchar(12),@ho nvarchar(50),@ten nvarchar(30),@diaChi nvarchar(50),@sdt nvarchar(10))
as
	insert into KHACHHANG(CanCuocCD,Ho,Ten,DiaChi,SDT)
	values(@CanCuoc,@ho,@ten,@diaChi,@sdt)
go

create proc deleteKhachHang
@CanCuoc nvarchar(12)
as
	delete KHACHHANG where CanCuocCD = @CanCuoc
go

create proc updateKhachHang
(@CanCuoc nvarchar(12),@ho nvarchar(50),@ten nvarchar(30),@diaChi nvarchar(50),@sdt nvarchar(10))
as
	update KHACHHANG
	set
	CanCuocCD = @CanCuoc,
	Ho = @ho,
	Ten = @ten,
	DiaChi = @diaChi,
	SDT = @sdt
	where CanCuocCD = @CanCuoc
go
create proc selectKhacHang
as
	select * from KHACHHANG
go


drop proc insertPhongBan
go
drop proc deletePhongBan
go
drop proc updatePhongBan
go
drop proc selectPhongBan
go

create proc insertPhongBan
(@maPhong nvarchar(10) , @maQL nvarchar(10),@tenPhong nvarchar(30))
as
	insert into PHONGBAN(MaPhong,MaQL,TenPhong)
	values(@maPhong,@maQL,@tenPhong)
go

create proc deletePhongBan
@maPhongBan nvarchar(10)
as
	delete PHONGBAN where MaPhong = @maPhongBan
go

create proc updatePhongBan
(@maPhong nvarchar(10) , @maQL nvarchar(10),@tenPhong nvarchar(30))
as
	update PHONGBAN
	set
	MaPhong = @maPhong,
	MaQL = @maQL,
	TenPhong = @tenPhong
	where MaPhong = @maPhong
go
create proc selectPhongBan
as
	select * from PHONGBAN
go

drop proc insertDonHang
go
drop proc deleteDonHang
go
drop proc updateDonHang
go
drop proc selectDonHang
go

create proc insertDonHang
(@maDonHang nvarchar(10),@diachiGui nvarchar(100),@diachiNhan nvarchar(100),@cccdNhan nvarchar(12),@cccdGui nvarchar(12),@mieuta nvarchar(200),@khoiLuong float, @KichThuoc float, @cuoc int, @maNV nvarchar(10))
as
	insert into DONHANG(MaDonHang,DiachiGui,DiachiNhan,CCCDGui,CCCDNhan,MieuTa,KhoiLuong,KichThuoc,Cuoc,MaNV)
	values(@maDonHang,@diachiGui,@diachiNhan,@cccdGui,@cccdNhan,@mieuta,@khoiLuong,@KichThuoc,@cuoc,@maNV)
go

create proc deleteDonHang
@maDonHang NVARCHAR(10)
AS
	DELETE dbo.DONHANG WHERE MaDonHang = @maDonHang
GO

CREATE PROC updateDonHang
(@maDonHang nvarchar(10),@diachiGui nvarchar(100),@diachiNhan nvarchar(100),@cccdNhan nvarchar(12),@cccdGui nvarchar(12),@mieuta nvarchar(200),@khoiLuong float, @KichThuoc float, @cuoc int, @maNV nvarchar(10))
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

create proc selectDonHang
as
select * from DONHANG;
go
