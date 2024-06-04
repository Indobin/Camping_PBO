CREATE TABLE admin (
    id_admin  SERIAL NOT NULL PRIMARY KEY,
    namaadmin VARCHAR(50) NOT NULL,
    username  VARCHAR(20) NOT NULL UNIQUE,
    password  VARCHAR(25) NOT NULL,
    no_hp     VARCHAR(14) NOT NULL
);

CREATE TABLE alat_camping (
    id_alatcamping                    SERIAL NOT NULL PRIMARY KEY,
    namaalatcamping                   VARCHAR(60) NOT NULL,
    hargaalatcamping                  INTEGER NOT NULL,
    jumlahalatcamping                 INTEGER NOT NULL,
    deskripsi                         TEXT NOT NULL,
	dihentikan bool not null,
    id_pemilik                SERIAL NOT NULL, 
    id_kategori SERIAL NOT NULL
);

CREATE TABLE detail_transaksi (
    id_detail_transaksi         SERIAL NOT NULL PRIMARY KEY,
    id_peminjaman int NOT NULL,
    id_alatcamping int NOT NULL,
    lama_sewa                   INTEGER NOT NULL,
    quantity                    INTEGER NOT NULL
);

CREATE TABLE kategori_alat_camping (
    id_kategori  SERIAL NOT NULL PRIMARY KEY,
    namakategori VARCHAR(20) NOT NULL UNIQUE,
	id_pemilik int NOT NULL,
	dihentikan bool not null
);

CREATE TABLE laporan (
    id_laporan                           SERIAL NOT NULL PRIMARY KEY,
    isi_laporan                          TEXT NOT NULL,
    tanggallaporan                       DATE NOT NULL,
    statuslaporan                        CHAR(1) NOT NULL,
    isi_tanggapan                        TEXT NULL,
    id_penyewa                   SERIAL NOT NULL,
    id_admin                       SERIAL NOT NULL, 
    id_peminjaman int not null
);

CREATE UNIQUE INDEX laporan__idx ON
    laporan (
        id_detail_transaksi
    ASC );

CREATE TABLE pembayaran_ewallet (
    id_ewallet       SERIAL NOT NULL PRIMARY KEY,
    "nomor_e-wallet" VARCHAR(25) NOT NULL,
    "Jenis_E-Wallet" VARCHAR(14) NOT NULL
);

CREATE TABLE pemilik (
    id_pemilik        SERIAL NOT NULL PRIMARY KEY,
    namapemilik       VARCHAR(50) NOT NULL,
    username          VARCHAR(20) NOT NULL UNIQUE,
    password          VARCHAR(20) NOT NULL,
    no_teleponpemilik INTEGER NOT NULL,
    alamat_pemilik    TEXT NOT NULL
);

CREATE TABLE peminjaman (
    id_peminjaman      SERIAL NOT NULL PRIMARY KEY,
    id_penyewa SERIAL NOT NULL,
    tanggal_peminjaman DATE NOT NULL,
    status_pinjam      CHAR(1) NOT NULL,
	id_ewallet int NOT NULL
);

CREATE TABLE pengembalian (
    id_pengembalian                      SERIAL NOT NULL PRIMARY KEY,
    tanggalpengembalian                  DATE NOT NULL,
    denda varchar(10), 
    id_peminjaman int not null,
    status_kembali boolean NOT NULL
);

CREATE UNIQUE INDEX pengembalian__idx ON
    pengembalian (
        id_detail_transaksi
    ASC );

CREATE TABLE penyewa (
    id_penyewa        SERIAL NOT NULL PRIMARY KEY,
    namapenyewa       VARCHAR(50) NOT NULL,
    username          VARCHAR(20) NOT NULL UNIQUE,
    password          VARCHAR(20) NOT NULL,
    no_teleponpenyewa VARCHAR(14) NOT NULL,
    alamat_penyewa    TEXT NOT NULL
);

CREATE SEQUENCE id_penyewa_seq;
CREATE SEQUENCE id_pemilik_seq;
--ALTER TABLE penyewa ALTER COLUMN id_penyewa SET DEFAULT nextval('id_penyewa_seq');
--ALTER TABLE pemilik ALTER COLUMN id_pemilik SET DEFAULT nextval('id_pemilik_seq');
ALTER TABLE kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_pemilik_fk FOREIGN KEY ( id_pemilik )
        REFERENCES pemilik ( id_pemilik );

ALTER TABLE alat_camping
    ADD CONSTRAINT alat_camping_kategori_alat_camping_fk FOREIGN KEY ( id_kategori )
        REFERENCES kategori_alat_camping ( id_kategori );

ALTER TABLE alat_camping
    ADD CONSTRAINT alat_camping_pemilik_fk FOREIGN KEY ( id_pemilik )
        REFERENCES pemilik ( id_pemilik );

ALTER TABLE detail_transaksi
    ADD CONSTRAINT detail_transaksi_alat_camping_fk FOREIGN KEY ( id_alatcamping )
        REFERENCES alat_camping ( id_alatcamping );

ALTER TABLE peminjaman
    ADD CONSTRAINT "Peminjaman_E-wallet_FK" FOREIGN KEY ( id_ewallet )
        REFERENCES pembayaran_ewallet ( id_ewallet );

ALTER TABLE detail_transaksi
    ADD CONSTRAINT detail_transaksi_peminjaman_fk FOREIGN KEY ( id_peminjaman )
        REFERENCES peminjaman ( peminjaman );

ALTER TABLE laporan
    ADD CONSTRAINT laporan_admin_fk FOREIGN KEY ( id_admin )
        REFERENCES admin ( id_admin );

ALTER TABLE laporan
    ADD CONSTRAINT laporan_detail_peminjaman foreign key (id_peminjaman)
        REFERENCES peminjaman (id_peminjaman)

ALTER TABLE laporan
    ADD CONSTRAINT laporan_penyewa_fk FOREIGN KEY ( id_penyewa )
        REFERENCES penyewa ( id_penyewa );

ALTER TABLE peminjaman
    ADD CONSTRAINT peminjaman_penyewa_fk FOREIGN KEY ( id_penyewa )
        REFERENCES penyewa ( id_penyewa );

ALTER TABLE pengembalian
    ADD CONSTRAINT pengembalian_peminjaman foreign key (id_peminjaman)
        REFERENCES peminjaman (id_peminjaman)