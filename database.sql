/* Table: NHANVIEN */

CREATE TABLE NHANVIEN
(
    MaNV VARCHAR2(5) NOT NULL,
    MaQL VARCHAR2(5) ,
    TenNV VARCHAR2(40) NOT NULL,
    ChucVu VARCHAR2(40) NOT NULL,
    NgaySinh date NOT NULL,
    GioiTinh VARCHAR2(20) NOT NULL,
    DiaChi VARCHAR2(40) NOT NULL,
    SDT NUMBER NOT NULL,
    NgayVaoLam DATE NOT NULL,
    CONSTRAINT PK_MaNV PRIMARY KEY(MaNV)

);
/* Index: NHANVIEN_PK */

/* Table: KHACHHANG */

CREATE TABLE KHACHHANG
(
    MaKH VARCHAR2(5) NOT NULL,
    TenKH VARCHAR2(40) NOT NULL,
    GioiTinh VARCHAR2(20) NOT NULL,
    Email VARCHAR2(40) NOT NULL,
    SDT NUMBER NOT NULL,
    NgSinh DATE NOT NULL,
    CONSTRAINT PK_MaKH PRIMARY KEY(MaKH)

);

/* Index: KHACHHANG_PK */

/* Table: HOADON */

CREATE TABLE HOADON
(
    MaHD VARCHAR2(5) NOT NULL,
    MaKM VARCHAR2(5),
    MaNV VARCHAR2(5) NOT NULL,
    MaKH VARCHAR2(5) NOT NULL,
    ThoiGianLap DATE NOT NULL,
    SoLuongSP NUMBER NOT NULL,
    TienChuaTru NUMBER NOT NULL,
    TienKM NUMBER ,
    TongTien NUMBER NOT NULL,
    GhiChu VARCHAR2(40),
    CONSTRAINT PK_MAHD PRIMARY KEY(MaHD)
);

/* Table: CTHD */

CREATE TABLE CTHD
(
    MaSP VARCHAR2(5) NOT NULL,
    MaHD VARCHAR2(5) NOT NULL,
    SoLuongSP NUMBER NOT NULL,
    TienSP NUMBER NOT NULL,
    CONSTRAINT PK_ctHD PRIMARY KEY(MaSP,MaHD)
);


/* Table: SANPHAM */

CREATE TABLE SANPHAM
(
    MaSP VARCHAR2(5) NOT NULL,
    TenSP VARCHAR2(40) NOT NULL,
    SLTon NUMBER NOT NULL,
    DonGia NUMBER NOT NULL,
    CONSTRAINT PK_MASP PRIMARY KEY(MaSP)
);

/* Table: DICHVU */

CREATE TABLE DICHVU
(
    MaDV VARCHAR2(5) NOT NULL,
    TenDV VARCHAR2(40) NOT NULL,
    TienDV number NOT NULL,
    CONSTRAINT PK_MADV PRIMARY KEY(MaDV)
);

/* Table: PHIEUDV */

CREATE TABLE PHIEUDV
(
    MaPDV VARCHAR2(5) NOT NULL,
    MaNV VARCHAR2(5) NOT NULL,
    MaKH VARCHAR2(5) NOT NULL,
    NgayLap DATE NOT NULL,
    SoLuongDV NUMBER NOT NULL,
    TongTien NUMBER NOT NULL,
    ThanhToanTruoc NUMBER ,
    TienConLai NUMBER NOT NULL,
    TinhTrang VARCHAR2(20) NOT NULL,
    CONSTRAINT PK_MAPDV PRIMARY KEY(MaPDV)
);

/* Table: CHITIETDV */

CREATE table CHITIETDV
(
    MaDV VARCHAR2(5) NOT NULL,
    MaPDV VARCHAR2(5) NOT NULL,
    MaNV VARCHAR2(5) NOT NULL,
    NgayLap DATE NOT NULL,
    SoLuongDV NUMBER NOT NULL,
    NgayGiao date NOT NULL,
    DonGiaDuocTinh NUMBER,
    ThanhTien NUMBER NOT NULL,
    TinhTrang VARCHAR2(20) NOT NULL,
    TraTruoc NUMBER NOT NULL,
    ConLai NUMBER NOT NULL,
    CONSTRAINT PK_ctdv PRIMARY KEY(MaPDV, MaDV)
);

/* Table: TAIKHOAN */

CREATE TABLE TAIKHOAN(
    TenTK VARCHAR2(40) NOT NULL,
    MatKhau VARCHAR2(40) NOT NULL,
    MaNV  VARCHAR2(5) NOT NULL,
    CONSTRAINT PK_tk PRIMARY KEY(TenTK)
);

/* Table: KHUYENMAI */

CREATE TABLE KHUYENMAI(
	MaKM VARCHAR2(5) NOT NULL,
	TenKM VARCHAR2(40) NOT NULL,
	TienKM number NOT NULL,
    CONSTRAINT PK_KM PRIMARY KEY(MaKM)
);

/* Table: PHIEUNHAP */

CREATE TABLE PHIEUNHAP(
    MaPH VARCHAR2(5) NOT NULL,
    MaNV VARCHAR2(5) NOT NULL,
    NgNSP date,
    TongNSP number NOT NULL,
    CONSTRAINT PK_MAPH PRIMARY KEY(MaPH)
);

/* Table: CHITIETNSP */

CREATE TABLE CHITIETNSP(
       MaPH VARCHAR2(5) NOT NULL,
       MaSP VARCHAR2(5) NOT NULL,
       SoLuongNhap number NOT NULL,
       DonGiaNhap number NOT NULL,
       ThanhTien number NOT NULL,
       CONSTRAINT PK_ChiTiet PRIMARY KEY(MaPH,MaSP)    
);
 

ALTER TABLE PHIEUDV
ADD CONSTRAINT FK_MAKH_PDV FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH);

ALTER TABLE PHIEUDV
ADD CONSTRAINT FK_MANV_PDV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV);

ALTER TABLE CHITIETNSP
ADD CONSTRAINT FK_MASP_CTN FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP);

ALTER TABLE CHITIETNSP
ADD CONSTRAINT FK_MAPH_CTN FOREIGN KEY (MaPH) REFERENCES PHIEUNHAP(MaPH);


ALTER TABLE PHIEUNHAP
ADD CONSTRAINT FK_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV);

ALTER TABLE HOADON
ADD CONSTRAINT FK_MANV_HD FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV);

ALTER TABLE HOADON
ADD CONSTRAINT FK_MAKH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH);

ALTER TABLE HOADON
ADD CONSTRAINT FK_MAKM FOREIGN KEY (MaKM) REFERENCES KHUYENMAI(MaKM);

ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_MANV_TK FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV);

ALTER TABLE CHITIETDV
ADD CONSTRAINT FK_MANV_CTDV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV);

ALTER TABLE CHITIETDV
ADD CONSTRAINT FK_MADV_CTDV FOREIGN KEY (MaDV) REFERENCES DICHVU(MaDV);

ALTER TABLE CHITIETDV
ADD CONSTRAINT FK_MAPDV_CTDV FOREIGN KEY (MaPDV) REFERENCES PhieuDV(MaPDV);

ALTER TABLE CTHD
ADD CONSTRAINT FK_MAHD_CTHD FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD);

ALTER TABLE CTHD
ADD CONSTRAINT FK_MASP_CTHD FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NV_QL FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV);



---BANG DICHVU---
INSERT INTO DICHVU VALUES('DV01','Cài Windows',150000);
INSERT INTO DICHVU VALUES('DV02','Cài ứng dụng đồ họa',100000);
INSERT INTO DICHVU VALUES('DV03','Sửa lỗi cơ bản',100000);
INSERT INTO DICHVU VALUES('DV04','Vệ sinh máy',150000);
INSERT INTO DICHVU VALUES('DV05','Nâng cấp, thay thế linh kiện',20000);
INSERT INTO DICHVU VALUES('DV11','Khôi phục dữ liệu',120000);
INSERT INTO DICHVU VALUES('DV12','Sửa lỗi nâng cao',200000);
INSERT INTO DICHVU VALUES('DV13','Diệt virus',100000);
INSERT INTO DICHVU VALUES('DV14','Sửa lỗi kết nối Internet',680000);
INSERT INTO DICHVU VALUES('DV15','Cài ứng dụng văn phòng',90000);
INSERT INTO DICHVU VALUES('DV16','Tra keo tản nhiệt',20000);
INSERT INTO DICHVU VALUES('DV17','Đổi sản phẩm có phụ thu',50000);
INSERT INTO DICHVU VALUES('DV18','Hoàn trả sản phẩm có phụ thu',50000);
INSERT INTO DICHVU VALUES('DV19','Bảo hành sản phẩm',0);
INSERT INTO DICHVU VALUES('DV20','Đổi sản phẩm do lỗi NSX',0);

----BANG NHAN VIEN---
INSERT INTO NHANVIEN VALUES('NV01','QL','NGUYỄN LÊ DUY','QL',TO_DATE('1/5/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0761433296',TO_DATE('07/1/2017','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV02','','NGUYỄN VĂN TOÀN','KT',TO_DATE('8/9/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0392327834',TO_DATE('07/1/2017','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV03','','VŨ VIỆT HÙNG','BH',TO_DATE('03/12/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0928537116',TO_DATE('07/1/2017','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV04','','NGUYỄN THỊ THỦY TIÊN','TN',TO_DATE('13/8/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','0928475515',TO_DATE('7/1/2017','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV05','QL','HOÀNG THANH TÚ','QL',TO_DATE('18/05/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','0369276223',TO_DATE('21/01/2018','DD/MM/YYYY')); 
INSERT INTO NHANVIEN VALUES('NV06','','NGUYỄN TRẦN NHẬT QUANG','TN',TO_DATE('23/3/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0945237455',TO_DATE('7/2/2018','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV07','QL','NGUYỄN THÁI CÔNG','QL',TO_DATE('27/2/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','0779880707',TO_DATE('20/2/2018','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV08','','MAI NAM HẢI','BH',TO_DATE('22/5/1999','DD/MM/YYYY'),'Nam','Đồng Nai','071649322',TO_DATE('20/2/2018','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV09','','VŨ NGỌC TRINH','BH',TO_DATE('1/11/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','0369587723',TO_DATE('07/03/2019','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV10','','THÁI HUY HOÀNG','BH',TO_DATE('8/10/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0392616399',TO_DATE('3/9/2019','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV11','','ÐOÀN VĂN CƯỜNG','TN',TO_DATE('03/11/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0925753185',TO_DATE('30/06/2019','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV12','','BÙI THỊ THANH THANH','TN',TO_DATE('11/3/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','036115770',TO_DATE('9/10/2020','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV13','QL','LÊ DUY KHÁNH','QL',TO_DATE('15/6/1999','DD/MM/YYYY'),'Nam','Đồng Nai','036499150',TO_DATE('11/10/2020','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV14','','NGUYỄN THỊ THANH TRÚC','BH',TO_DATE('16/4/1999','DD/MM/YYYY'),'Nữ','Đồng Nai','036493470',TO_DATE('11/10/2020','DD/MM/YYYY'));
INSERT INTO NHANVIEN VALUES('NV15','','ĐỖ VIỆT BÁCH','BH',TO_DATE('17/2/1999','DD/MM/YYYY'),'Nam','Đồng Nai','0394931550',TO_DATE('13/10/2020','DD/MM/YYYY'));

----BANG KHACH HANG---

INSERT INTO KHACHHANG VALUES('KH01','Bạc Thu Thuận','NỮ','bacthuthuan41@microsoft.com','0963486201',TO_DATE('10/02/1985','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH02','Bảo Tâm Trang', 'NỮ','baotamtrang188@naver.com','0882391765',TO_DATE('03/08/1980','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH03','Kha Nguyên Bảo','NAM','khanguyenbao307@naver.com','0938597366',TO_DATE('11/06/1987','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH04','Diệp Tú Quyên ','NỮ','dieptuquyen705@hotmail.com','0584879251',TO_DATE('16/05/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH05','Tôn Trung Hải','NAM','tontrunghai962@yahoo.com','0937851329',TO_DATE('30/05/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH06','Trình Hoàng Cúc','NỮ','trinhhoangcuc938@microsoft.com','0834689170',TO_DATE('14/10/1998','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH07','Mạch Phượng Vũ','NỮ','machphuongvu91@icloud.com','0354673015',TO_DATE('12/04/1979','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH08','Quản Diệu Hằng','NỮ','quandieuhang141@naver.com','0838249713',TO_DATE('17/07/1974','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH09','Lư Hùng Phong','NAM','luhungphong651@naver.com','0365967031',TO_DATE('08/01/2000','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH10','Dã Mạnh Dũng','NAM','damanhdung719@gmail.com','0581695478',TO_DATE('20/10/1984','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH11','Hàn Phụng Việt','NAM','hanphungviet925@gmail.com','0344710952',TO_DATE('17/06/1996','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH12','Đào Phương Trâm', 'NỮ','daophuongtram553@yahoo.com','0849407613',TO_DATE('01/05/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH13','Bá Ðức Siêu','NAM','baucsieu718@hotmail.com','0814271058',TO_DATE('11/05/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH14','Nhan Trúc Loan','NỮ','nhantrucloan885@facebook.com','0888360579',TO_DATE('19/08/1990','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH15','Bùi Nhã Yến','NỮ','buinhayen305@naver.com','0902549738',TO_DATE('31/07/1994','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH16','Lộ Tuyết Thanh','NỮ','lotuyetthanh352@microsoft.com','0782407356',TO_DATE('22/10/1989','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH17','Võ Tuyết Chi','NỮ','votuyetchi410@icloud.com','0819602384',TO_DATE('14/05/1988','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH18','Đỗ Vũ Anh Đào','NỮ','dovuanhdao783@gmail.com','0590564179',TO_DATE('01/01/1991','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH19','Phong Ðức Khiêm','NAM','phonguckhiem75@facebook.com','0949078165',TO_DATE('30/04/1985','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH20','Cai Thế Phương','NAM','caithephuong161@google.com','0355783012',TO_DATE('24/05/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH21','Anh Việt Duy','NAM','anhvietduy704@microsoft.com','0785127048',TO_DATE('22/05/1999','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH22','Giang Mộng Tuyền','NỮ','giangmongtuyen555@icloud.com','0842498160',TO_DATE('04/09/2002','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH23','Tôn Mạnh Hùng','NAM','tonmanhhung499@gmail.com','0882973658',TO_DATE('22/05/1999','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH24','Ngạc Việt Trinh','NỮ','ngacviettrinh805@hotmail.com','0789207561',TO_DATE('12/06/1999','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH25','Thành Lan Thương','NỮ','thanhlanthuong23@naver.com','0359406821',TO_DATE('12/06/1985','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH26','Trần Như Loan','NỮ','trannhuloan421@icloud.com','0928431609',TO_DATE('01/09/1995','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH27','Võ Ngọc Quỳnh','NỮ','vongocquynh379@hotmail.com','0332306879',TO_DATE('12/09/1999','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH28','Liễu Anh Tuấn','NAM','	lieuanhtuan713@gmail.com','0332185470',TO_DATE('15/09/1999','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH29','Lương Hồng Việt','NAM','luonghongviet633@hotmail.com','0582168345',TO_DATE('22/03/1998','DD/MM/YYYY'));
INSERT INTO KHACHHANG VALUES('KH30','Đào Thị Cẩm Hạnh','NỮ','daocamhanh529@naver.com','0828304276',TO_DATE('12/06/1994','DD/MM/YYYY'));


-- BANG SAN PHAM
INSERT INTO SANPHAM VALUES('SP01','LAPTOP HP 240 G8 617K5PA',15,12900000);
INSERT INTO SANPHAM VALUES('SP02','LAPTOP GAMING MSI GF63',20,23000000);
INSERT INTO SANPHAM VALUES('SP03','LAPTOP GAMING ASUS TUF',20,19000000);
INSERT INTO SANPHAM VALUES('SP04','LAPTOP GAMING HP VICTUS',20,22000000);
INSERT INTO SANPHAM VALUES('SP05','LAPTOP DELL VOSTRO',20,18000000);
INSERT INTO SANPHAM VALUES('SP06','LAPTOP GAMING ACER TRITON',20,35000000);
INSERT INTO SANPHAM VALUES('SP07','LAPTOP GAMING LENOVO LEGION',20,34590000);
INSERT INTO SANPHAM VALUES('SP08','LAPTOP ASUS GAMING ROG',20,27500000);
INSERT INTO SANPHAM VALUES('SP09','LAPTOP HP PAVILION X360',20,23600000);
INSERT INTO SANPHAM VALUES('SP10','LAPTOP ASUS ZENBOOK FLIP',20,3200000);
INSERT INTO SANPHAM VALUES('SP11','VGA ASUS TUF GTX 1660 SUPER',15,8200000);
INSERT INTO SANPHAM VALUES('SP12','CPU AMD RYZEN 7 5800X',20,9600000);
INSERT INTO SANPHAM VALUES('SP13','VGA MSI RADEON RX 6600',20,10900000);
INSERT INTO SANPHAM VALUES('SP14','SSD ADATA GAMMIX S11 PRO',20,3900000);
INSERT INTO SANPHAM VALUES('SP15','MAIN ASUS B460-F ROG STRIX',20,3600000);
INSERT INTO SANPHAM VALUES('SP16','RAM DDR4 32GB ADATA XPG',20,4400000);
INSERT INTO SANPHAM VALUES('SP17','NGUỒN AEROCOOL 500W',20,500000);
INSERT INTO SANPHAM VALUES('SP18','CASE AEROCOOL STREAK - LED RGB',20,500000);
INSERT INTO SANPHAM VALUES('SP19','HDD SEAGATE/WD 500GB',20,520000);
INSERT INTO SANPHAM VALUES('SP20','PSU CORSAIR 650W CV650',20,1550000);
INSERT INTO SANPHAM VALUES('SP21','MÀN HÌNH LCD PHILIPS 24INCH',15,3500000);
INSERT INTO SANPHAM VALUES('SP22','MÀN HÌNH LCD AOC 20 INCH',20,2500000);
INSERT INTO SANPHAM VALUES('SP23','MÀN HÌNH LCD HKC MB20S1 19.5INCH',20,2400000);
INSERT INTO SANPHAM VALUES('SP24','MÀN HÌNH LCD DELL P2722H 27INCH',20,4000000);
INSERT INTO SANPHAM VALUES('SP25','MÀN HÌNH LCD ASUS 27INCH ProArt',20,9000000);
INSERT INTO SANPHAM VALUES('SP26','CHUỘT ASUS TUF M3',20,500000);
INSERT INTO SANPHAM VALUES('SP27','CHUỘT LOGITECH G903 HERO',20,3200000);
INSERT INTO SANPHAM VALUES('SP28','CHUỘT RAZER VIPER MINI RGB',20,1200000);
INSERT INTO SANPHAM VALUES('SP29','CHUỘT ADATA XPG PRIMER GAMING',20,1100000);
INSERT INTO SANPHAM VALUES('SP30','TAI NGHE DAREU EH722X',20,650000);
INSERT INTO SANPHAM VALUES('SP31','BÀN PHÍM CƠ E-DRA EK387',15,699000);
INSERT INTO SANPHAM VALUES('SP32','BÀN PHÍM CƠ DAREU EK87',20,640000);
INSERT INTO SANPHAM VALUES('SP33','BÀN PHÍM CƠ CORSAIR K68 RGB',20,2990000);
INSERT INTO SANPHAM VALUES('SP34','TAI NGHE ASUS TUF H3 GAMING',20,900000);
INSERT INTO SANPHAM VALUES('SP35','TAI NGHE CORSAIR HS35 Carbon',20,960000);
INSERT INTO SANPHAM VALUES('SP36','TAI NGHE LOGITECH G431',20,1400000);
INSERT INTO SANPHAM VALUES('SP37','MOUSE PAD ASUS TUF P1',20,150000);
INSERT INTO SANPHAM VALUES('SP38','MOUSE PAD HAVIT MP901 RGB',20,2990000);
INSERT INTO SANPHAM VALUES('SP39','LOA LOGITECH Z313',20,800000);
INSERT INTO SANPHAM VALUES('SP40','TAY CẦM GAME MICROSOFT XBOX',20,1800000);


---BANG KHUYEN MAI
INSERT INTO KHUYENMAI VALUES('KM01','KM CUỐI TUẦN', 20000);
INSERT INTO KHUYENMAI VALUES('KM02','KM GIỮA THÁNG', 50000);
INSERT INTO KHUYENMAI VALUES('KM03','KM SINH NHẬT', 50000);
INSERT INTO KHUYENMAI VALUES('KM04','KM NGÀY ĐẸP', 30000);
INSERT INTO KHUYENMAI VALUES('KM05','KM CÁC DỊP LỄ', 50000);
INSERT INTO KHUYENMAI VALUES('KM06','KM BLACK FRIDAY', 200000);
INSERT INTO KHUYENMAI VALUES('KM07','KM KHÁCH VIP', 1000000);


--- BANG PHIEUNHAP

INSERT INTO PHIEUNHAP VALUES('PH01','NV01',TO_DATE('1/6/2021','DD/MM/YYYY'),149000000);
INSERT INTO PHIEUNHAP VALUES('PH02','NV01',TO_DATE('2/6/2021','DD/MM/YYYY'),149000000);
INSERT INTO PHIEUNHAP VALUES('PH03','NV02',TO_DATE('3/6/2021','DD/MM/YYYY'),149000000);
INSERT INTO PHIEUNHAP VALUES('PH04','NV02',TO_DATE('4/6/2021','DD/MM/YYYY'),149000000);
INSERT INTO PHIEUNHAP VALUES('PH05','NV05',TO_DATE('5/6/2021','DD/MM/YYYY'),149000000);

--- BANG CHITIETNSP
INSERT INTO CHITIETNSP VALUES('PH01','SP01',10,2700000, 0);
INSERT INTO CHITIETNSP VALUES('PH01','SP02',5,30000000,0);
INSERT INTO CHITIETNSP VALUES('PH01','SP03',3,3500000,0);
INSERT INTO CHITIETNSP VALUES('PH01','SP04',15,2000000,0);
INSERT INTO CHITIETNSP VALUES('PH01','SP11',8,2700000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP12',20,2800000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP07',25,2900000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP04',16,2000000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP08',10,3200000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP02',18,3000000,0);
INSERT INTO CHITIETNSP VALUES('PH02','SP03',12,2800000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP04',20,2700000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP01',15,5000000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP02',30,2500000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP03',6,4000000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP06',15,4800000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP07',12,1500000,0);
INSERT INTO CHITIETNSP VALUES('PH03','SP16',25,3800000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP03',23,4800000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP04',17,2500000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP01',22,3800000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP02',20,4200000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP09',30,5500000,0);
INSERT INTO CHITIETNSP VALUES('PH04','SP08',10,2300000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP01',10,4000000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP02',20,3800000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP03',15,2600000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP04',12,1200000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP07',22,2500000,0);
INSERT INTO CHITIETNSP VALUES('PH05','SP23',30,1700000, 0);
INSERT INTO CHITIETNSP VALUES('PH05','SP19',10,4000000,0);

----BANG PHIEUDV-----
INSERT INTO PHIEUDV VALUES ('PDV01', 'NV01', 'KH01', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 5600000, 3600000, 2000000, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV02', 'NV01', 'KH02', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 5650000, 5000000, 650000, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV03', 'NV01', 'KH03', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 100000, 100000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV04', 'NV01', 'KH04', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 250000, 250000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV05', 'NV01', 'KH05', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 300000, 300000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV06', 'NV01', 'KH06', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 5600000, 5600000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV07', 'NV01', 'KH07', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 5650000, 5650000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV08', 'NV01', 'KH08', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 100000, 100000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV09', 'NV01', 'KH09', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 500000, 500000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV10', 'NV01', 'KH10', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 300000, 300000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV11', 'NV01', 'KH11', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 350000, 150000, 200000, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV12', 'NV01', 'KH12', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 70000, 70000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV13', 'NV01', 'KH13', TO_DATE('11/02/2021','DD/MM/YYYY'), 1, 950000, 450000, 400000, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV14', 'NV01', 'KH14', TO_DATE('11/02/2021','DD/MM/YYYY'), 2, 68000, 68000, 0, 'HOAN THANH');
INSERT INTO PHIEUDV VALUES ('PDV15', 'NV01', 'KH15', TO_DATE('11/02/2021','DD/MM/YYYY'), 2, 170000, 170000, 0, 'HOAN THANH');


--- BANG CHITIETDV
INSERT INTO CHITIETDV VALUES('DV01', 'PDV01','NV01',TO_DATE('11/02/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),5600000, 5600000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV02', 'PDV02','NV01',TO_DATE('12/03/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),5650000,5650000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV03', 'PDV03','NV02',TO_DATE('08/03/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),100000,100000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV04', 'PDV04','NV02',TO_DATE('11/05/2019','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),250000,250000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV05', 'PDV05','NV03',TO_DATE('27/05/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),300000,300000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV01', 'PDV06','NV03',TO_DATE('29/03/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),5600000,5600000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV02', 'PDV07','NV04',TO_DATE('08/10/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),5650000,5650000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV03', 'PDV08','NV04',TO_DATE('25/07/2019','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),100000,100000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV04', 'PDV09','NV05',TO_DATE('01/12/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),250000,250000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV05', 'PDV10','NV05',TO_DATE('06/02/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),300000,300000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV11', 'PDV06','NV06',TO_DATE('29/12/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),350000,350000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV12', 'PDV07','NV06',TO_DATE('08/10/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),700000,700000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV13', 'PDV08','NV07',TO_DATE('25/11/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),950000,950000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV14', 'PDV09','NV07',TO_DATE('30/12/2020','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),68000,68000, 'DA GIAO', 0, 0);
INSERT INTO CHITIETDV VALUES('DV15', 'PDV10','NV06',TO_DATE('08/02/2021','DD/MM/YYYY'),1,TO_DATE('11/02/2021','DD/MM/YYYY'),170000,170000, 'DA GIAO', 0, 0);

-- BANG HOADON---------
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD01','KM03','NV04','KH01',TO_DATE('01/05/2020','DD/MM/YYYY'),4,15800000,500000,15300000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD02','KM01','NV02','KH02',TO_DATE('01/05/2020','DD/MM/YYYY'),5,10200000,200000,10000000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD03','KM03','NV05','KH03',TO_DATE('01/05/2020','DD/MM/YYYY'),6,18000000,500000,17500000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD04','KM03','NV02','KH04',TO_DATE('23/05/2020','DD/MM/YYYY'),4,20000000,500000,19500000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD05','KM01','NV01','KH05',TO_DATE('30/05/2020','DD/MM/YYYY'),2,8000000,200000,7800000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD06','KM01','NV02','KH06',TO_DATE('04/05/2020','DD/MM/YYYY'),10,40000000,200000,39800000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD07','KM01','NV04','KH07',TO_DATE('09/05/2020','DD/MM/YYYY'),8,36720000,200000,36520000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD08','KM03','NV05','KH08',TO_DATE('18/05/2020','DD/MM/YYYY'),6,15000000,500000,14500000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD09','KM02','NV08','KH09',TO_DATE('03/05/2020','DD/MM/YYYY'),4,18400000,100000,18300000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD10','KM02','NV04','KH10',TO_DATE('20/05/2020','DD/MM/YYYY'),2,6400000,100000,6300000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD11','KM04','NV04','KH10',TO_DATE('1/6/2021','DD/MM/YYYY'),3,8700000,300000,8400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TienKM,TongTien)VALUES('HD12','KM06','NV04','KH10',TO_DATE('20/10/2021','DD/MM/YYYY'),6,15000000,500000,14500000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD13', '', 'NV04','KH10',TO_DATE('1/05/2020','DD/MM/YYYY'),4,18400000,18400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD21', '', 'NV04','KH21',TO_DATE('4/3/2019','DD/MM/YYYY'),2,8000000,8000000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD22', '', 'NV04','KH21',TO_DATE('11/12/2020','DD/MM/YYYY'),6,15000000,15000000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD23', '', 'NV04','KH21',TO_DATE('7/1/2021','DD/MM/YYYY'),4,18400000,18400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD24', '', 'NV04','KH22',TO_DATE('4/3/2019','DD/MM/YYYY'),2,5200000,5200000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD25', '', 'NV04','KH22',TO_DATE('11/2/2020','DD/MM/YYYY'),2,8000000,8000000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD26', '', 'NV04','KH22',TO_DATE('7/1/2021','DD/MM/YYYY'),2,5200000,5200000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD27', '', 'NV04','KH23',TO_DATE('24/5/2019','DD/MM/YYYY'),3,8700000,8700000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD28', '', 'NV04','KH23',TO_DATE('3/11/2020','DD/MM/YYYY'),1,4000000,4000000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD29', '', 'NV04','KH23',TO_DATE('14/5/2021','DD/MM/YYYY'),4,12800000,12800000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD30', '', 'NV04','KH24',TO_DATE('15/5/2019','DD/MM/YYYY'),2,9180000,9180000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD31', '', 'NV06','KH24',TO_DATE('16/6/2019','DD/MM/YYYY'),1,2900000,2900000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD32', '', 'NV06','KH25',TO_DATE('17/8/2019','DD/MM/YYYY'),1,2400000,2400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD33', '', 'NV11','KH26',TO_DATE('18/3/2019','DD/MM/YYYY'),1,3600000,3600000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD34', '', 'NV11','KH27',TO_DATE('19/2/2019','DD/MM/YYYY'),1,1200000,1200000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD35', '', 'NV12','KH28',TO_DATE('20/1/2019','DD/MM/YYYY'),1,1400000,1400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD36', '', 'NV12','KH29',TO_DATE('21/1/2019','DD/MM/YYYY'),1,4400000,4400000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD37', '', 'NV11','KH15',TO_DATE('21/5/2019','DD/MM/YYYY'),2,3200000,3200000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD38', '', 'NV11','KH22',TO_DATE('11/7/2019','DD/MM/YYYY'),2,3200000,3200000);
INSERT INTO HOADON(MaHD,MaKM,MaNV,MaKH,ThoiGianLap,SoLuongSP,TienChuaTru,TongTien)VALUES('HD39', '', 'NV12','KH30',TO_DATE('11/3/2019','DD/MM/YYYY'),1,1500000,1500000);

--- BANG CTHD------
INSERT INTO CTHD VALUES('SP01','HD01',1,2900000);
INSERT INTO CTHD VALUES('SP29','HD01',1,6000000);
INSERT INTO CTHD VALUES('SP12','HD01',1,2900000);
INSERT INTO CTHD VALUES('SP19','HD01',1,4000000);
INSERT INTO CTHD VALUES('SP02','HD02',2,6000000);
INSERT INTO CTHD VALUES('SP32','HD02',1,2400000);
INSERT INTO CTHD VALUES('SP39','HD02',2,1800000);
INSERT INTO CTHD VALUES('SP03','HD03',6,18000000);
INSERT INTO CTHD VALUES('SP04','HD04',4,20000000);
INSERT INTO CTHD VALUES('SP05','HD05',2,8000000);
INSERT INTO CTHD VALUES('SP06','HD06',10,40000000);
INSERT INTO CTHD VALUES('SP07','HD07',8,36720000);
INSERT INTO CTHD VALUES('SP08','HD08',6,15000000);
INSERT INTO CTHD VALUES('SP09','HD09',4,18400000);
INSERT INTO CTHD VALUES('SP10','HD10',2,6400000);
INSERT INTO CTHD VALUES('SP01','HD11',3,8700000);
INSERT INTO CTHD VALUES('SP08','HD12',6,15000000);
INSERT INTO CTHD VALUES('SP09','HD13',4,18400000);
INSERT INTO CTHD VALUES('SP05','HD21',2,8000000);
INSERT INTO CTHD VALUES('SP08','HD22',6,15000000);
INSERT INTO CTHD VALUES('SP09','HD23',4,18400000);
INSERT INTO CTHD VALUES('SP10','HD24',2,5200000);
INSERT INTO CTHD VALUES('SP05','HD25',2,8000000);
INSERT INTO CTHD VALUES('SP10','HD26',2,5200000);
INSERT INTO CTHD VALUES('SP01','HD27',3,8700000);
INSERT INTO CTHD VALUES('SP06','HD28',1,4000000);
INSERT INTO CTHD VALUES('SP11','HD29',4,12800000);
INSERT INTO CTHD VALUES('SP07','HD30',2,9180000);
INSERT INTO CTHD VALUES('SP31','HD31',1,2900000);
INSERT INTO CTHD VALUES('SP32','HD32',1,2400000);
INSERT INTO CTHD VALUES('SP33','HD33',1,3600000);
INSERT INTO CTHD VALUES('SP34','HD34',1,1200000);
INSERT INTO CTHD VALUES('SP35','HD35',1,1400000);
INSERT INTO CTHD VALUES('SP36','HD36',1,4400000);
INSERT INTO CTHD VALUES('SP15','HD37',2,3200000);
INSERT INTO CTHD VALUES('SP16','HD38',2,3200000);
INSERT INTO CTHD VALUES('SP22','HD39',1,1500000);

----BANG TAIKHOAN---
INSERT INTO TAIKHOAN VALUES ('NV01', '123', 'NV01');
INSERT INTO TAIKHOAN VALUES ('NV02', '123', 'NV02');
INSERT INTO TAIKHOAN VALUES ('NV03', '456', 'NV03');
INSERT INTO TAIKHOAN VALUES ('NV04', '129', 'NV04');
INSERT INTO TAIKHOAN VALUES ('NV05', '124', 'NV05');
INSERT INTO TAIKHOAN VALUES ('NV06', '154', 'NV06');
INSERT INTO TAIKHOAN VALUES ('NV07', '113', 'NV07');
INSERT INTO TAIKHOAN VALUES ('NV08', '173', 'NV08');
INSERT INTO TAIKHOAN VALUES ('NV09', '153', 'NV09');
INSERT INTO TAIKHOAN VALUES ('NV10', '157', 'NV10');
INSERT INTO TAIKHOAN VALUES ('NV11', '423', 'NV11');
INSERT INTO TAIKHOAN VALUES ('NV12', '983', 'NV12');

COMMIT;

/* TRIGGER: Trigger_Update_NhanVien_NgaySinh_NgayVaoLam */
CREATE OR REPLACE TRIGGER Trigger_Update_NhanVien_NgaySinh_NgayVaoLam 
BEFORE INSERT OR UPDATE OF NgaySinh,NgayVaoLam ON NHANVIEN 
FOR EACH ROW
BEGIN
    IF (floor(months_between(:NEW.NgayVaoLam, :NEW.NgaySinh) /12) <= 18)
    THEN
        RAISE_APPLICATION_ERROR(-20000, 'Không hợp lệ. Ngày vào làm của nhân viên phải lớn hon ngày sinh từ 18 năm trở lên!');
    END IF;
END;

/* TRIGGER: Trigger_Update_HoaDon_ThoiGianLap_NgSinh */
CREATE OR REPLACE TRIGGER Trigger_Update_HoaDon_ThoiGianLap_NgSinh
BEFORE INSERT OR UPDATE OF ThoiGianLap ON HOADON
FOR EACH ROW
DECLARE
input_ngsinh_kh KHACHHANG.NGSINH%TYPE;
BEGIN
    SELECT NgSinh INTO input_ngsinh_kh FROM KHACHHANG K
    WHERE K.MaKH = :NEW.MaKH;
    IF :NEW.ThoiGianLap < input_ngsinh_kh THEN
        RAISE_APPLICATION_ERROR(-20000,'Không hợp lệ. Ngày lập hóa đơn phải lớn hơn ngày sinh!');
    END IF;
END;

/* TRIGGER: Trigger_Update_HoaDon_ThoiGianLap_NgayVaoLam */
CREATE OR REPLACE TRIGGER Trigger_Update_HoaDon_ThoiGianLap_NgayVaoLam
BEFORE INSERT OR UPDATE OF ThoiGianLap ON HOADON
FOR EACH ROW
DECLARE
    input_ngayvaolam DATE;
BEGIN
    SELECT NgayVaoLam INTO input_ngayvaolam FROM NHANVIEN N
    WHERE N.MaNV = :NEW.MaNV;
    IF (input_ngayvaolam > :NEW.ThoiGianLap)
    THEN
        RAISE_APPLICATION_ERROR(-20000, 'Không hợp lệ. Ngày vào làm phải nhỏ hơn ngày lập hóa đơn!');
    END IF;
END;

/* TRIGGER: Trigger_Update_HoaDon_TongTien */
CREATE OR REPLACE TRIGGER Trigger_Update_HoaDon_TongTien
BEFORE INSERT OR UPDATE ON HOADON
FOR EACH ROW
DECLARE 
    input_TienSP CTHD.TienSP%TYPE;
    input_TienKM KHUYENMAI.TienKM%TYPE;
BEGIN
    SELECT SUM(TienSP) INTO input_TienSP 
    FROM CTHD 
    WHERE MaHD = :NEW.MaHD;
    
    SELECT TienKM INTO input_TienKM
    FROM KHUYENMAI
    WHERE MaKM = :NEW.MaKM;
    IF (input_TienSP - input_TienKM < 0) THEN
        :NEW.TongTien := 0;
    ELSE
        :NEW.TongTien := input_TienSP - input_TienKM;
    END IF;
END;

/* TRIGGER: Trigger_Update_NhanVien_ChucVu */
CREATE OR REPLACE TRIGGER Trigger_Update_NhanVien_ChucVu 
BEFORE INSERT OR UPDATE OF ChucVu ON NHANVIEN
FOR EACH ROW
BEGIN
  IF (:NEW.ChucVu NOT IN ('QL', 'KT','BH','TN'))
  THEN
    RAISE_APPLICATION_ERROR(-20000, 'Chức vụ phải là "Quản Lý"(QL), "Kế Toán"(KT), "Nhân Viên Bán Hàng"(BH) hoặc "Thu Ngân"(TN)!');
  END IF;
END;

/* TRIGGER: Trigger_Insert_KhachHang_GioiTinh */
CREATE OR REPLACE TRIGGER Trigger_Insert_KhachHang_GioiTinh 
BEFORE INSERT ON KHACHHANG
FOR EACH ROW
BEGIN
  IF (:NEW.GioiTinh NOT IN ('Nam','Nữ','Khác'))
  THEN
    RAISE_APPLICATION_ERROR(-20000, 'Giới tính khách hàng phải là "Nam", "Nữ" hoặc "Khác"!');
  END IF;
END;

/* TRIGGER: Trigger_Insert_NhanVien_GioiTinh */
CREATE OR REPLACE TRIGGER Trigger_Insert_NhanVien_GioiTinh 
BEFORE INSERT ON NHANVIEN
FOR EACH ROW
BEGIN
  IF (:NEW.GioiTinh NOT IN ('Nam', 'Nữ','Khác'))
  THEN
    RAISE_APPLICATION_ERROR(-20000, 'Giới tính nhân viên phải là "Nam", "Nữ" hoặc "Khác"!');
  END IF;
END;

/* PROCEDURE: Print_KhachHang */
CREATE OR REPLACE PROCEDURE Print_KhachHang (i_MAKH IN VARCHAR2)
AS
  output_TenKH      KHACHHANG.TenKH%TYPE; 
  output_GioiTinh   KHACHHANG.GioiTinh%TYPE;
  output_Email      KHACHHANG.Email%TYPE;
  output_SDT        KHACHHANG.SDT%TYPE;
  output_NgSinh     KHACHHANG.NgSinh%TYPE;
BEGIN
  SELECT TenKH, GioiTinh, Email, SDT, NgSinh
  INTO  output_TenKH, output_GioiTinh, output_Email, output_SDT, output_NgSinh
  FROM KHACHHANG
  WHERE KHACHHANG.MaKH = i_MAKH;
  dbms_output.put_line('Họ và tên: '|| output_TenKH);
  dbms_output.put_line('Giới tính: '|| output_GioiTinh);
  dbms_output.put_line('Email: '|| output_Email);
  dbms_output.put_line('SDT: '|| output_SDT);
  dbms_output.put_line('Ngày sinh: '|| output_NgSinh);
END Print_KhachHang;

/* PROCEDURE:Print_NhanVien */
CREATE OR REPLACE PROCEDURE Print_NhanVien (i_MaNV IN VARCHAR2) 
AS
  output_MaQL        NHANVIEN.MaQL%TYPE;
  output_TenNV       NHANVIEN.TenNV%TYPE; 
  output_ChucVu      NHANVIEN.ChucVu%TYPE;
  output_NgaySinh    NHANVIEN.NgaySinh%TYPE;
  output_GioiTinh    NHANVIEN.GioiTinh%TYPE;
  output_DiaChi      NHANVIEN.DiaChi%TYPE;
  output_SDT         NHANVIEN.SDT%TYPE;
  output_NgayVaoLam  NHANVIEN.NgayVaoLam%TYPE;
BEGIN
  SELECT MaQL, TenNV, ChucVu, NgaySinh, GioiTinh, DiaChi, SDT, NgayVaoLam
  INTO output_MaQL, output_TenNV, output_ChucVu, output_NgaySinh, output_GioiTinh, output_DiaChi, output_SDT, output_NgayVaoLam
  FROM NHANVIEN
  WHERE NHANVIEN.MaNV = i_MaNV;
  dbms_output.put_line('Thông tin nhân viên có mã số: '|| i_MaNV ||'......');
  dbms_output.put_line('Mã người quản lý: '|| output_MaQL);
  dbms_output.put_line('Họ và tên: '|| output_TenNV);
  dbms_output.put_line('Chức vụ: '|| output_ChucVu);
  dbms_output.put_line('Ngày sinh: '|| output_NgaySinh);
  dbms_output.put_line('Giới tính: '|| output_GioiTinh);
  dbms_output.put_line('Địa chỉ: '|| output_DiaChi);
  dbms_output.put_line('SDT: '|| output_SDT);
  dbms_output.put_line('Ngày vào làm: '|| output_NgayVaoLam);
END Print_NhanVien; 

/* PROCEDURE: Print_DoanhThu */
CREATE OR REPLACE PROCEDURE Print_DoanhThu (i_Year IN NUMBER ) 
AS
    CURSOR c_HoaDon IS
        SELECT EXTRACT(MONTH FROM ThoiGianLap), SUM(TongTien)
        FROM HOADON
        WHERE EXTRACT(YEAR FROM ThoiGianLap) = i_Year
        GROUP BY EXTRACT(MONTH FROM ThoiGianLap)
        ORDER BY EXTRACT(MONTH FROM ThoiGianLap) ASC;
    Total_Revenue NUMBER := 0;
    i_Month INT;
    Monthly_Revenue NUMBER;
BEGIN
  OPEN c_hoadon;
  LOOP
    FETCH c_hoadon INTO i_Month, Monthly_Revenue;
    EXIT WHEN c_hoadon%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE('Tháng ' || i_Month || ' có doanh thu là: ' || Monthly_Revenue);
    Total_Revenue := Total_Revenue + Monthly_Revenue;
  END LOOP;
  CLOSE c_hoadon;
  DBMS_OUTPUT.PUT_LINE('Tổng doanh thu năm ' || i_Year || ' là ' || Total_Revenue);
END Print_DoanhThu;

/* PROCEDURE: Update_DichVu */
CREATE OR REPLACE PROCEDURE Update_DichVu(i_MaDV IN DICHVU.MaDV%type, i_TenDV IN DICHVU.TenDV%type, i_TienDV IN DICHVU.TienDV%type) 
IS
BEGIN
  UPDATE DICHVU
  SET TenDV = i_TenDV, TienDV = i_TienDV
  WHERE MaDV = i_MaDV;
END Update_DichVu;

/* PROCEDURE: Update_KhuyenMai */
CREATE OR REPLACE PROCEDURE Update_KhuyenMai(i_MaKM IN KHUYENMAI.MaKM%type, i_TenKM IN KHUYENMAI.TenKM%type, i_TienKM IN KHUYENMAI.TienKM%type) 
IS
BEGIN
  UPDATE KHUYENMAI
  SET TenKM = i_TenKM, TienKM = i_TienKM
  WHERE MaKM = i_MaKM;
END Update_KhuyenMai;

/* PROCEDURE: SLEEP */
CREATE OR REPLACE PROCEDURE SLEEP(in_time NUMBER)
AS
    v_now date;
BEGIN
    SELECT SYSDATE
    INTO v_now
    FROM DUAL;
    LOOP
        EXIT WHEN v_now + (in_time * (1/86400)) <= SYSDATE;
    END LOOP;
END SLEEP;

/* PROCEDURE:Add_KhachHang */
SET SERVEROUTPUT ON;
CREATE OR REPLACE PROCEDURE Add_KhachHang(
i_CustomerID      IN KHACHHANG.MaKH%TYPE,
i_CustomerName     IN KHACHHANG.TenKH%TYPE,
i_CustomerGender  IN KHACHHANG.GioiTinh%TYPE,
i_CustomerEmail     IN KHACHHANG.Email%TYPE,  
i_CustomerPhone       IN KHACHHANG.SDT%TYPE, 
i_CustomerDOB    IN KHACHHANG.NgSinh%TYPE )
IS
BEGIN
    INSERT INTO KHACHHANG
    VALUES (i_CustomerID,i_CustomerName,i_CustomerGender,i_CustomerEmail,i_CustomerPhone,i_CustomerDOB);
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Thêm thành công!');
END Add_KhachHang;

/* FUNCTION: Analyze_KhachHang */
CREATE OR REPLACE FUNCTION Analyze_KhachHang
RETURN HoaDon.MaKH%TYPE
IS
    i_MaKH KhachHang.MaKH%TYPE;
    i_Total HoaDon.TongTien%TYPE;
BEGIN
    SELECT MaKH,SUM(TongTien) INTO i_MaKH, i_Total
    FROM HoaDon
    WHERE ROWNUM <= 1
    GROUP BY MaKH
    ORDER BY SUM(TongTien) DESC;
    RETURN i_MaKH;
END;

/* FUNCTION: Check_SDT */
CREATE OR REPLACE FUNCTION Check_SDT(sdt in VARCHAR2) 
RETURN NUMBER 
IS i_num NUMBER;
BEGIN
    BEGIN  
        i_num:=to_number(SDT);
        EXCEPTION
        WHEN invalid_number THEN
        RETURN null;
    END;
    RETURN i_num;
END;

create or replace PROCEDURE InsertKH
(MaKH in varchar2,TenKH in VARCHAR2,GioiTinh in VARCHAR2,Email in VARCHAR2,SDT in NUMBER,NgSinh in DATE)
as
begin

INSERT INTO KHACHHANG VALUES(MaKH,TenKH,GioiTinh,Email,SDT,NgSinh);
end;

create or replace PROCEDURE  insertSP 
(MaSP in varchar2,TenSP in varchar2,SLTon in number,DonGia in varchar2)
as
begin 
insert into SANPHAM values(MaSP,TenSP,SLTon,DonGia);
end;
