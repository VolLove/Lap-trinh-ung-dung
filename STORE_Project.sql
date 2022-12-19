USE PROJECT
go
 
--Store DONHANG
create proc sp_InsertDonHang
(@maDH char(10), @maNV char(10),@cCCdNhan char(12),@cCCdGui char(12),@diaChiNhan nvarchar(100),@diaChiGui nvarchar(100),
@mieuTa nvarchar(200),@khoiLuong float, @kichThuoc float, @cuoc float)
as
	insert into DONHANG 
	values(@maDH,@maNV,@cCCdNhan,@cCCdGui,@diaChiNhan,@diaChiGui,@mieuTa,@khoiLuong,@kichThuoc,@cuoc)
go

create proc sp_DeleteDonHang
(@maDH char(10))
as
	DELETE dbo.DONHANG WHERE MaDH = @maDH
GO

CREATE PROC sp_UpdateDonHang
(@maDH char(10), @maNV char(10),@cCCdNhan char(12),@cCCdGui char(12),@diaChiNhan nvarchar(100),@diaChiGui nvarchar(100),
@mieuTa nvarchar(200),@khoiLuong float, @kichThuoc float, @cuoc float)
as
	UPDATE dbo.DONHANG
	set
	MaDH = @maDH,
	MaNV = @maNV,
	CCCDNhan = @cCCdNhan,
	CCCDGui = @cCCdGui,
	DiachiNhan = @diaChiNhan,
	DiachiGui = @diaChiGui,
	MieuTa = @mieuTa,
	KhoiLuong = @khoiLuong,
	KichThuoc = @kichThuoc,
	Cuoc = @cuoc
	where MaDH = @maDH

GO

create proc sp_SelectDonHang
as
select * from DONHANG;
go





--Store NHANVIEN
create proc sp_InsertNhanVien
(@maNV char(10),@hoVaTen nvarchar(50), @ngaySinh date, @diaChi nvarchar(50), @cccd char(12), @sdt char(10), @phai nvarchar(5),@luong float,@maPhong char(10))
as
	insert into NHANVIEN
	values (@maNV,@hoVaTen,@ngaySinh,@diaChi,@cccd,@sdt,@phai,@luong,@maPhong)
go

create proc sp_DeleteNhanVien
(@manv char(10))
as
	delete NHANVIEN where MaNV = @manv
go

create proc sp_UpdateNhanVien 
(@maNV char(10), @hoVaTen nvarchar(50), @ngaySinh date, @diaChi nvarchar(50), @cCCD char(12), @sdt char(10), @phai nvarchar(5),@luong float,@maPhong char(10))
as
	update NHANVIEN 
	set
	MaNV = @maNV,
	HoVaTen = @hoVaTen,
	NgSinh = @ngaySinh,
	DiaChi = @diaChi,
	CCCD = @cCCD,
	SDT = @sdt,
	Phai = @phai,
	Luong = @luong,
	MaPhong = @maPhong
	where MaNV = @maNV
go

create proc sp_SelectNhanVien
as
	select * from NHANVIEN
go



--STORE KHACHHANG
create proc sp_InsertKhachHang
(@cccd char(12), @phai nvarchar(5),@hoVaTen nvarchar(50),@diaChi nvarchar(50),@sdt char(10))
as
	insert into KHACHHANG
	values(@cccd,@phai,@hoVaTen,@diaChi,@sdt)
go

create proc sp_DeleteKhachHang
(@cccd char(12))
as
	delete KHACHHANG where CCCD = @cccd
go

create proc sp_UpdateKhachHang
(@cccd char(12), @phai nvarchar(5),@hoVaTen nvarchar(50),@diaChi nvarchar(50),@sdt char(10))
as
	update KHACHHANG
	set
	CCCD = @cccd,
	Phai = @phai,
	HoVaTen = @hoVaTen,
	DiaChi = @diaChi,
	SDT = @sdt
	where CCCD = @cccd
go
create proc sp_SelectKhachHang
as
	select * from KHACHHANG
go




--STORE PHONGBAN
create proc sp_InsertPhongBan
(@maPhong char(10) , @maQL char(10),@tenPhong nvarchar(30))
as
	insert into PHONGBAN
	values(@maPhong,@maQL,@tenPhong)
go

create proc sp_DeletePhongBan
(@maPhong char(10))
as
	delete PHONGBAN where MaPhong = @maPhong
go

create proc sp_UpdatePhongBan
(@maPhong char(10) , @maQL char(10),@tenPhong nvarchar(30))
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


--khác
create proc sp_SearchDonHangByCC
(@CCCD char(12))
as
select * from DONHANG
where @CCCD = '' or CCCDGui like '%' +@CCCD + '%';
go

create proc sp_SearchDonHangByCCnhan
(@CCCD char(12))
as
select * from DONHANG
where @CCCD = '' or CCCDNhan like '%' +@CCCD + '%';
go

create proc sp_Reprt
as
select DONHANG.MaDH, NHANVIEN.HoVaTen,KHACHHANG.HoVaTen,KHACHHANG.HoVaTen,DONHANG.DiaChiGui,DONHANG.DiaChiNhan,DONHANG.KhoiLuong,DONHANG.KichThuoc,DONHANG.Cuoc
from DONHANG, NHANVIEN,KHACHHANG
where
DONHANG.MaNV = NHANVIEN.MaNV and KHACHHANG.CCCD = DONHANG.CCCDGui and KHACHHANG.CCCD = DONHANG.CCCDNhan
go
