CREATE DATABASE QLInternet
GO

USE QLInternet
GO

-- mat khau mac dinh admin123

CREATE TABLE TaiKhoan
(
	TenTK CHAR(200) PRIMARY KEY,
	MatKhau VARCHAR(200) NOT NULL,
	TrangThai BIT DEFAULT 0 ,
	TongTG FLOAT DEFAULT 0,
	TGconLai FLOAT DEFAULT 0,
)
GO

CREATE TABLE ThongTinTK
(
	TenTK CHAR(200) PRIMARY KEY,
	SDT CHAR(10),
	Email CHAR(200),
	CONSTRAINT fk_ThongTinTK_TaiKhoan FOREIGN KEY(TenTK) REFERENCES dbo.TaiKhoan
)
GO

CREATE TABLE LichSu
(
	NgayGD DATETIME PRIMARY KEY,
	TenTK CHAR(200) ,
	TienThem FLOAT DEFAULT 0 ,
	TGThem FLOAT DEFAULT 0,
	--CONSTRAINT fk_LichSu_ThongTinTK FOREIGN KEY(TenTK) REFERENCES dbo.ThongTinTK
)
GO

CREATE TABLE DichVu
(
	TenDV CHAR(50) PRIMARY KEY,
	GiaDV FLOAT
)
GO

 
INSERT dbo.DichVu
(
    TenDV,
    GiaDV
)
VALUES
(   'GiaCuoc', -- TenDV - char(50)
    1000 -- GiaDV - float
    )
 
 INSERT dbo.TaiKhoan
 (
     TenTK,
     MatKhau,
     TrangThai,
     TongTG,
     TGconLai
 )
 VALUES
 (   'admin',   -- TenTK - char(200)
     '114625812318911537522240105223241810',   -- MatKhau - varchar(200)
     0, -- TrangThai - bit
     0.0,  -- TongTG - float
     0.0   -- TGconLai - float
     )

INSERT dbo.ThongTinTK
(
    TenTK,
    SDT,
    Email
)
VALUES
(   'admin', -- TenTK - char(200)
    '0354825649', -- SDT - char(10)
    'leminh2344@gmail.com'  -- Email - char(200)
    )


INSERT dbo.TaiKhoan
 (
     TenTK,
     MatKhau,
     TrangThai,
     TongTG,
     TGconLai
 )
 VALUES
 (   'taikhoan1',   -- TenTK - char(200)
     '114625812318911537522240105223241810',   -- MatKhau - varchar(200)
     0, -- TrangThai - bit
     7.6,  -- TongTG - float
     2.5   -- TGconLai - float
     )

INSERT dbo.ThongTinTK
(
    TenTK,
    SDT,
    Email
)
VALUES
(   'taikhoan1', -- TenTK - char(200)
    '0334825649', -- SDT - char(10)
    'lem2344@gmail.com'  -- Email - char(200)
    )


INSERT dbo.TaiKhoan
 (
     TenTK,
     MatKhau,
     TrangThai,
     TongTG,
     TGconLai
 )
 VALUES
 (   'taikhoan2',   -- TenTK - char(200)
     '114625812318911537522240105223241810',   -- MatKhau - varchar(200)
     0, -- TrangThai - bit
     6.5,  -- TongTG - float
     3.5   -- TGconLai - float
     )

INSERT dbo.ThongTinTK
(
    TenTK,
    SDT,
    Email
)
VALUES
(   'taikhoan2', -- TenTK - char(200)
    '0334825699', -- SDT - char(10)
    'lem23@gmail.com'  -- Email - char(200)
    )


INSERT dbo.TaiKhoan
 (
     TenTK,
     MatKhau,
     TrangThai,
     TongTG,
     TGconLai
 )
 VALUES
 (   'taikhoan3',   -- TenTK - char(200)
     '114625812318911537522240105223241810',   -- MatKhau - varchar(200)
     0, -- TrangThai - bit
     0.9,  -- TongTG - float
     0.5   -- TGconLai - float
     )

INSERT dbo.ThongTinTK
(
    TenTK,
    SDT,
    Email
)
VALUES
(   'taikhoan3', -- TenTK - char(200)
    '0334867649', -- SDT - char(10)
    'l4@gmail.com'  -- Email - char(200)
    )

INSERT dbo.TaiKhoan
 (
     TenTK,
     MatKhau,
     TrangThai,
     TongTG,
     TGconLai
 )
 VALUES
 (   'taikhoan4',   -- TenTK - char(200)
     '114625812318911537522240105223241810',   -- MatKhau - varchar(200)
     0, -- TrangThai - bit
     0.2,  -- TongTG - float
     2.5   -- TGconLai - float
     )

INSERT dbo.ThongTinTK
(
    TenTK,
    SDT,
    Email
)
VALUES
(   'taikhoan4', -- TenTK - char(200)
    '0334826649', -- SDT - char(10)
    'le44@gmail.com'  -- Email - char(200)
    )




