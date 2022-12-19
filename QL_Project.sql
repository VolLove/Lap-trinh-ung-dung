
--DROP DATABASE PROJECT
go
CREATE DATABASE PROJECT
go
USE PROJECT
go


CREATE TABLE DONHANG(
	MaDH char(10) not null PRIMARY KEY,
	MaNV char(10) not null,
	CCCDGui char(12) not null,
	CCCDNhan char(12) not null,
	DiaChiGui nvarchar(100),
	DiaChiNhan nvarchar(100),
	MieuTa nvarchar(200),
	KhoiLuong float,
	KichThuoc float,
	Cuoc float
)
go

CREATE TABLE KHACHHANG(
	CCCD char(12) not null primary KEY,
	Phai nvarchar(5),
	HoVaTen nvarchar(50),
	DiaChi nvarchar(50) ,
	SDT char(10)
)
go


CREATE TABLE NHANVIEN(
	MaNV char(10) not null primary key,
	HoVaTen nvarchar(50),
	NgSinh date ,
	DiaChi nvarchar(50),
	CCCD char(12) ,
	SDT char(10),
	Phai nvarchar(5),
	Luong float,
	MaPhong char(10) not null

)
GO
CREATE TABLE PHONGBAN(
	MaPhong char(10) not null primary key,
	MaQL char(10) not null,
	TenPhong nvarchar(30),
)
GO


insert into PHONGBAN(MaPhong,MaQL,TenPhong)
values('PB001','NV001',N'Phòng nhân sự')
go
insert into PHONGBAN(MaPhong,MaQL,TenPhong)
values('PB002','NV002',N'Phòng bảo vệ')
go
insert into PHONGBAN(MaPhong,MaQL,TenPhong)
values('PB003','NV003',N'Phòng giám đốc')
go
insert into PHONGBAN(MaPhong,MaQL,TenPhong)
values('PB004','NV004',N'Phòng tài chính')
        
go

insert into NHANVIEN(MaNV,HoVaTen,CCCD,MaPhong,DiaChi,NgSinh,Phai,SDT,Luong)
values('NV001',N'Nguyển Văn Tâm','2003GD3483','PB001',N'Quận Thủ Đức, TP.HCM','1998-5-23',N'Nam','0234323298',3400000)
go

insert into NHANVIEN(MaNV,HoVaTen,CCCD,MaPhong,DiaChi,NgSinh,Phai,SDT,Luong)
values('NV002',N'Võ Hoàng Đức','38KDME0323','PB002',N'Quận 9, TP.HCM','1998-10-7',N'Nam','0234323298',3500000)
go
insert into NHANVIEN(MaNV,HoVaTen,CCCD,MaPhong,DiaChi,NgSinh,Phai,SDT,Luong)
values('NV003',N'Trần Thị Thuỳ Linh','374832ew33','PB003',N'Quận Thủ Đức, TP.HCM','1992-8-2',N'Nữ','023343438',30000000)
go
insert into NHANVIEN(MaNV,HoVaTen,CCCD,MaPhong,DiaChi,NgSinh,Phai,SDT,Luong)
values('NV004',N'Đào Xuân Mạnh','36DN48DE34','PB004',N'Quận Thủ Đức, TP.HCM','1997-11-15',N'Nam','0374673839',2000000)
go



insert into KHACHHANG(CCCD,HoVaTen,DiaChi,Phai,SDT)
values('38743HDUEH',N'Nguyễn Thành Thái',N'Quận 7. TP.HCM',N'Nam','0374834345')
go
insert into KHACHHANG(CCCD,HoVaTen,DiaChi,Phai,SDT)
values('743NDFNI32',N'Trần Ngọc Châu',N'Quận 9. TP.HCM',N'Nữ','0934345789')
go
insert into KHACHHANG(CCCD,HoVaTen,DiaChi,Phai,SDT)
values('67HG7883UC',N'Nguyễn Thanh Tú',N'Quận Thủ Đức. TP.HCM',N'Nam','0856224999')
go
insert into KHACHHANG(CCCD,HoVaTen,DiaChi,Phai,SDT)
values('87UK98DMK3',N'Võ Lâm Kim',N'Quận 7. TP.HCM',N'Nam','0374234479')
go


insert into DONHANG(MaDH,MaNV,CCCDGui ,CCCDNhan ,DiaChiGui,DiaChiNhan,MieuTa,KhoiLuong,KichThuoc,Cuoc)
values('DH001','NV001','38743HDUEH','67HG7883UC',N'Ba Đình, Hà Nội',N'Quận 7, TP.HCM',N'Áo ba lỗ NIKE',0.2,0.1,10000)
go

--CREATE FOREIGN KEY
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_NVHD FOREIGN KEY(MaNV) REFERENCES dbo.NHANVIEN(MaNV)
go
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_KHNhan FOREIGN KEY(CCCDNhan) REFERENCES dbo.KHACHHANG(CCCD)
go
ALTER TABLE dbo.DONHANG ADD CONSTRAINT FK_KHGUI FOREIGN KEY(CCCDGui) REFERENCES dbo.KHACHHANG(CCCD)
go
ALTER TABLE dbo.PHONGBAN ADD CONSTRAINT FK_MQL FOREIGN KEY(MaQL) REFERENCES dbo.NHANVIEN(MaNV)
go
alter table dbo.NHANVIEN ADD CONSTRAINT FK_Phong foreign key(MaPhong) references dbo.PHONGBAN(MaPhong)
go
