/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     05/01/2023 1:06:01 CH                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ChiTietHDB') and o.name = 'FK_CHITIETH_CHITIETHD_MAYTINH')
alter table ChiTietHDB
   drop constraint FK_CHITIETH_CHITIETHD_MAYTINH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ChiTietHDB') and o.name = 'FK_CHITIETH_CHITIETHD_HOADONBA')
alter table ChiTietHDB
   drop constraint FK_CHITIETH_CHITIETHD_HOADONBA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ChiTietNhap') and o.name = 'FK_CHITIETN_CHITIETNH_MAYTINH')
alter table ChiTietNhap
   drop constraint FK_CHITIETN_CHITIETNH_MAYTINH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ChiTietNhap') and o.name = 'FK_CHITIETN_CHITIETNH_HOADONNH')
alter table ChiTietNhap
   drop constraint FK_CHITIETN_CHITIETNH_HOADONNH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONBANHANG') and o.name = 'FK_HOADONBA_LAP_NHANVIEN')
alter table HOADONBANHANG
   drop constraint FK_HOADONBA_LAP_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONBANHANG') and o.name = 'FK_HOADONBA_NHAN_KHACHHAN')
alter table HOADONBANHANG
   drop constraint FK_HOADONBA_NHAN_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONNHAPHANG') and o.name = 'FK_HOADONNH_XUAT_NHANVIEN')
alter table HOADONNHAPHANG
   drop constraint FK_HOADONNH_XUAT_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MAYTINH') and o.name = 'FK_MAYTINH_CUNGCAP_NHACUNGC')
alter table MAYTINH
   drop constraint FK_MAYTINH_CUNGCAP_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MAYTINH') and o.name = 'FK_MAYTINH_THUOCLOAI_LOAIMAYT')
alter table MAYTINH
   drop constraint FK_MAYTINH_THUOCLOAI_LOAIMAYT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUBAOHANH') and o.name = 'FK_PHIEUBAO_VIET_NHANVIEN')
alter table PHIEUBAOHANH
   drop constraint FK_PHIEUBAO_VIET_NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ChiTietHDB')
            and   name  = 'ChiTietHDB2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ChiTietHDB.ChiTietHDB2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ChiTietHDB')
            and   name  = 'ChiTietHDB_FK'
            and   indid > 0
            and   indid < 255)
   drop index ChiTietHDB.ChiTietHDB_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ChiTietHDB')
            and   type = 'U')
   drop table ChiTietHDB
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ChiTietNhap')
            and   name  = 'ChiTietNhap2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ChiTietNhap.ChiTietNhap2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ChiTietNhap')
            and   name  = 'ChiTietNhap_FK'
            and   indid > 0
            and   indid < 255)
   drop index ChiTietNhap.ChiTietNhap_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ChiTietNhap')
            and   type = 'U')
   drop table ChiTietNhap
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONBANHANG')
            and   name  = 'Nhan_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONBANHANG.Nhan_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONBANHANG')
            and   name  = 'Lap_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONBANHANG.Lap_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONBANHANG')
            and   type = 'U')
   drop table HOADONBANHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONNHAPHANG')
            and   name  = 'Xuat_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONNHAPHANG.Xuat_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONNHAPHANG')
            and   type = 'U')
   drop table HOADONNHAPHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAIMAYTINH')
            and   type = 'U')
   drop table LOAIMAYTINH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MAYTINH')
            and   name  = 'CungCap_FK'
            and   indid > 0
            and   indid < 255)
   drop index MAYTINH.CungCap_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MAYTINH')
            and   name  = 'ThuocLoaiMayTinh_FK'
            and   indid > 0
            and   indid < 255)
   drop index MAYTINH.ThuocLoaiMayTinh_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MAYTINH')
            and   type = 'U')
   drop table MAYTINH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHACUNGCAP')
            and   type = 'U')
   drop table NHACUNGCAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUBAOHANH')
            and   name  = 'Viet_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUBAOHANH.Viet_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUBAOHANH')
            and   type = 'U')
   drop table PHIEUBAOHANH
go

/*==============================================================*/
/* Table: ChiTietHDB                                            */
/*==============================================================*/
create table ChiTietHDB (
   MaMT                 varchar(10)          not null,
   MaHDB                varchar(10)          not null,
   SLBan                int                  null,
   GiaBan               int                  null,
   MaNVBan              varchar(10)          null,
   constraint PK_CHITIETHDB primary key (MaMT, MaHDB)
)
go

/*==============================================================*/
/* Index: ChiTietHDB_FK                                         */
/*==============================================================*/
create index ChiTietHDB_FK on ChiTietHDB (
MaMT ASC
)
go

/*==============================================================*/
/* Index: ChiTietHDB2_FK                                        */
/*==============================================================*/
create index ChiTietHDB2_FK on ChiTietHDB (
MaHDB ASC
)
go

/*==============================================================*/
/* Table: ChiTietNhap                                           */
/*==============================================================*/
create table ChiTietNhap (
   MaMT                 varchar(10)          not null,
   MaHDN                varchar(10)          not null,
   SLNhap               int                  null,
   GiaNhap              int                  null,
   constraint PK_CHITIETNHAP primary key (MaMT, MaHDN)
)
go

/*==============================================================*/
/* Index: ChiTietNhap_FK                                        */
/*==============================================================*/
create index ChiTietNhap_FK on ChiTietNhap (
MaMT ASC
)
go

/*==============================================================*/
/* Index: ChiTietNhap2_FK                                       */
/*==============================================================*/
create index ChiTietNhap2_FK on ChiTietNhap (
MaHDN ASC
)
go

/*==============================================================*/
/* Table: HOADONBANHANG                                         */
/*==============================================================*/
create table HOADONBANHANG (
   MaHDB                varchar(10)          not null,
   MaNV                 varchar(10)          not null,
   MaKH                 varchar(10)          not null,
   NgayXuatHDB          datetime             null,
   TongTienBan          int                  null,
   ChiPhiKhac           int                  null,
   constraint PK_HOADONBANHANG primary key nonclustered (MaHDB)
)
go

/*==============================================================*/
/* Index: Lap_FK                                                */
/*==============================================================*/
create index Lap_FK on HOADONBANHANG (
MaNV ASC
)
go

/*==============================================================*/
/* Index: Nhan_FK                                               */
/*==============================================================*/
create index Nhan_FK on HOADONBANHANG (
MaKH ASC
)
go

/*==============================================================*/
/* Table: HOADONNHAPHANG                                        */
/*==============================================================*/
create table HOADONNHAPHANG (
   MaHDN                varchar(10)          not null,
   MaNV                 varchar(10)          not null,
   NgayXuatHDN          datetime             null,
   TongTienNhap         int                  null,
   constraint PK_HOADONNHAPHANG primary key nonclustered (MaHDN)
)
go

/*==============================================================*/
/* Index: Xuat_FK                                               */
/*==============================================================*/
create index Xuat_FK on HOADONNHAPHANG (
MaNV ASC
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MaKH                 varchar(10)          not null,
   TenKH                varchar(150)         null,
   DiaChiKH             varchar(150)         null,
   SDT_KH               varchar(10)          null,
   GioiTinhKH           varchar(5)           null,
   constraint PK_KHACHHANG primary key nonclustered (MaKH)
)
go

/*==============================================================*/
/* Table: LOAIMAYTINH                                           */
/*==============================================================*/
create table LOAIMAYTINH (
   MaLMT                varchar(20)          not null,
   TenLMT               varchar(150)         null,
   MoTa                 varchar(150)         null,
   constraint PK_LOAIMAYTINH primary key nonclustered (MaLMT)
)
go

/*==============================================================*/
/* Table: MAYTINH                                               */
/*==============================================================*/
create table MAYTINH (
   MaMT                 varchar(10)          not null,
   MaNCC                varchar(10)          not null,
   MaLMT                varchar(20)          not null,
   TenMT                varchar(150)         null,
   SoLuongMT            int                  null,
   HinhAnh              image                null,
   GiaMT                int                  null,
   constraint PK_MAYTINH primary key nonclustered (MaMT)
)
go

/*==============================================================*/
/* Index: ThuocLoaiMayTinh_FK                                   */
/*==============================================================*/
create index ThuocLoaiMayTinh_FK on MAYTINH (
MaLMT ASC
)
go

/*==============================================================*/
/* Index: CungCap_FK                                            */
/*==============================================================*/
create index CungCap_FK on MAYTINH (
MaNCC ASC
)
go

/*==============================================================*/
/* Table: NHACUNGCAP                                            */
/*==============================================================*/
create table NHACUNGCAP (
   MaNCC                varchar(10)          not null,
   TenNCC               varchar(150)         null,
   DiaChiNCC            varchar(150)         null,
   SDTNCC               varchar(10)          null,
   constraint PK_NHACUNGCAP primary key nonclustered (MaNCC)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MaNV                 varchar(10)          not null,
   TenNV                varchar(150)         null,
   DiaChiNV             varchar(150)         null,
   SDT_NV               varchar(10)          null,
   ChucVu               varchar(50)          null,
   NgayVaoLam           datetime             null,
   GioiTinh             varchar(5)           null,
   PhanQuyen            bit                  null,
   MatKhau              varchar(32)          null,
   constraint PK_NHANVIEN primary key nonclustered (MaNV)
)
go

/*==============================================================*/
/* Table: PHIEUBAOHANH                                          */
/*==============================================================*/
create table PHIEUBAOHANH (
   MaPhieuBH            varchar(10)          not null,
   MaNV                 varchar(10)          not null,
   MoTaPhieuBH          varchar(250)         null,
   NgayLapPhieuBH       datetime             null,
   constraint PK_PHIEUBAOHANH primary key nonclustered (MaPhieuBH)
)
go

/*==============================================================*/
/* Index: Viet_FK                                               */
/*==============================================================*/
create index Viet_FK on PHIEUBAOHANH (
MaNV ASC
)
go

alter table ChiTietHDB
   add constraint FK_CHITIETH_CHITIETHD_MAYTINH foreign key (MaMT)
      references MAYTINH (MaMT)
go

alter table ChiTietHDB
   add constraint FK_CHITIETH_CHITIETHD_HOADONBA foreign key (MaHDB)
      references HOADONBANHANG (MaHDB)
go

alter table ChiTietNhap
   add constraint FK_CHITIETN_CHITIETNH_MAYTINH foreign key (MaMT)
      references MAYTINH (MaMT)
go

alter table ChiTietNhap
   add constraint FK_CHITIETN_CHITIETNH_HOADONNH foreign key (MaHDN)
      references HOADONNHAPHANG (MaHDN)
go

alter table HOADONBANHANG
   add constraint FK_HOADONBA_LAP_NHANVIEN foreign key (MaNV)
      references NHANVIEN (MaNV)
go

alter table HOADONBANHANG
   add constraint FK_HOADONBA_NHAN_KHACHHAN foreign key (MaKH)
      references KHACHHANG (MaKH)
go

alter table HOADONNHAPHANG
   add constraint FK_HOADONNH_XUAT_NHANVIEN foreign key (MaNV)
      references NHANVIEN (MaNV)
go

alter table MAYTINH
   add constraint FK_MAYTINH_CUNGCAP_NHACUNGC foreign key (MaNCC)
      references NHACUNGCAP (MaNCC)
go

alter table MAYTINH
   add constraint FK_MAYTINH_THUOCLOAI_LOAIMAYT foreign key (MaLMT)
      references LOAIMAYTINH (MaLMT)
go

alter table PHIEUBAOHANH
   add constraint FK_PHIEUBAO_VIET_NHANVIEN foreign key (MaNV)
      references NHANVIEN (MaNV)
go



create table TAIKHOAN (
   TenTaiKhoan          varchar(100)   primary key,
   TenHienThi           varchar(100)   not null default N'NTL',
   MatKhau		        varchar(1000)  not null default 0,
   Type INT not null default 0
)
go