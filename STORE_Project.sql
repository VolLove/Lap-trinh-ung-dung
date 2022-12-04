--CREATE DATABASE PROJECT
go
create proc sp_InsertNhanVien
(@maNV varchar(10),@HovaTen nvarchar(50), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD nvarchar(12), @sdt nvarchar(10), @phai nvarchar(5),@luong float,@maPhong varchar(10))
as
	insert into NHANVIEN(MaNV,HovaTen,NgSinh,DiaChi,CanCuoc,SDT,Phai,Luong,MaPhong)
	values (@maNV,@HovaTen,@ngaySinh,@diaChi,@canCuocCD,@sdt,@phai,@luong,@maPhong)
go

create proc sp_DeleteNhanVien @manv varchar(10)
as
	delete NHANVIEN where MaNV = @manv
go

create proc sp_UpdateNhanVien 
(@maNV varchar(10), 	@HovaTen nvarchar(50), @ngaySinh date, @diaChi nvarchar(50), @canCuocCD varchar(12), @sdt varchar(10), @phai nvarchar(5),@luong float,@maPhong varchar(10))
as
	update NHANVIEN 
	set
	MaNV = @maNV,
	HovaTen = @HovaTen,
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
create proc sp_SelectKhachHang
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