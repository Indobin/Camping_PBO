CREATE TABLE admin (
    id_admin  SERIAL NOT NULL primary key,
    namaadmin VARCHAR(50) NOT NULL,
    username  VARCHAR(20) NOT NULL,
    password  VARCHAR(25) NOT NULL,
    no_hp     VARCHAR(14) NOT NULL
);

CREATE TABLE alat_camping (
    id_alatcamping                    SERIAL NOT NULL PRIMARY KEY,
    namaalatcamping                   VARCHAR(60) NOT NULL,
    hargaalatcamping                  INTEGER NOT NULL,
    jumlahalatcamping                 INTEGER NOT NULL,
    deskripsi                         TEXT NOT NULL,
    id_pemilik                SERIAL NOT NULL, 
    id_kategori SERIAL NOT NULL
);

CREATE TABLE detail_transaksi (
    id_detail_transaksi         SERIAL NOT NULL PRIMARY KEY,
    id_peminjaman    SERIAL NOT NULL,
    id_alatcamping SERIAL NOT NULL
);

CREATE TABLE "E-wallet" (
    id_ewallet         SERIAL NOT NULL PRIMARY KEY,
    "nomor_e-wallet"   VARCHAR(25) NOT NULL,
    "Jenis_E-Wallet"   VARCHAR(14) NOT NULL,
    id_pemilik SERIAL NOT NULL
);

CREATE UNIQUE INDEX "E-wallet__IDX" ON
    "E-wallet" (
        id_pemilik
    ASC );

CREATE TABLE kategori_alat_camping (
    id_kategori  SERIAL NOT NULL PRIMARY KEY,
    namakategori VARCHAR(20) NOT NULL
);

CREATE TABLE laporan (
    id_laporan         SERIAL NOT NULL PRIMARY KEY,
    isi_laporan        TEXT NOT NULL,
    status_akun        VARCHAR (12) NOT NULL,
    tanggallaporan     TIMESTAMP NOT NULL,
    statuslaporan      VARCHAR(12) NOT NULL,
    isi_tanggapan      TEXT NOT NULL,
    id_penyewa SERIAL NOT NULL,
    id_admin     SERIAL NOT NULL
);

CREATE TABLE pemilik (
    id_pemilik        SERIAL NOT NULL PRIMARY KEY,
    namapemilik       VARCHAR(50) NOT NULL,
    username          VARCHAR(20) NOT NULL,
    password          VARCHAR(20) NOT NULL,
    no_teleponpemilik INTEGER NOT NULL,
    alamat_pemilik    TEXT NOT NULL
);

CREATE TABLE peminjaman (
    id_peminjaman      SERIAL NOT NULL PRIMARY KEY,
    tanggalpeminjaman  TIMESTAMP NOT NULL,
    tanggaljatuhtempo  TIMESTAMP NOT NULL,
    status             VARCHAR(20) NOT NULL,
    keterangan         TEXT,
	id_penyewa SERIAL NOT NULL
);

CREATE TABLE pengembalian (
    id_pengembalian                      SERIAL NOT NULL PRIMARY KEY,
    tanggalpengembalian                  TIMESTAMP NOT NULL,
    denda                                decimal,
    keterangan                           TEXT, 
	id_detail_transaksi SERIAL NOT NULL
);

CREATE UNIQUE INDEX pengembalian__idx ON
    pengembalian (
        id_detail_transaksi
    ASC );

CREATE TABLE penyewa (
    id_penyewa        SERIAL NOT NULL PRIMARY KEY,
    namapenyewa       VARCHAR(50) NOT NULL,
    username          VARCHAR(20) NOT NULL,
    password          VARCHAR(20) NOT NULL,
    no_teleponpenyewa VARCHAR(14) NOT NULL,
    alamat_penyewa    TEXT NOT NULL
);

ALTER TABLE alat_camping
    ADD CONSTRAINT alat_camping_kategori_alat_camping_fk FOREIGN KEY ( id_kategori )
        REFERENCES kategori_alat_camping ( id_kategori );

ALTER TABLE alat_camping
    ADD CONSTRAINT alat_camping_pemilik_fk FOREIGN KEY ( id_pemilik )
        REFERENCES pemilik ( id_pemilik );

ALTER TABLE detail_transaksi
    ADD CONSTRAINT detail_transaksi_alat_camping_fk FOREIGN KEY ( id_alatcamping )
        REFERENCES alat_camping ( id_alatcamping );

ALTER TABLE detail_transaksi
    ADD CONSTRAINT detail_transaksi_peminjaman_fk FOREIGN KEY ( id_peminjaman )
        REFERENCES peminjaman ( id_peminjaman );

ALTER TABLE "E-wallet"
    ADD CONSTRAINT "E-wallet_Pemilik_FK" FOREIGN KEY ( id_pemilik )
        REFERENCES pemilik ( id_pemilik );

ALTER TABLE laporan
    ADD CONSTRAINT laporan_admin_fk FOREIGN KEY ( id_admin )
        REFERENCES admin ( id_admin );

ALTER TABLE laporan
    ADD CONSTRAINT laporan_penyewa_fk FOREIGN KEY ( id_penyewa )
        REFERENCES penyewa ( id_penyewa );

ALTER TABLE peminjaman
    ADD CONSTRAINT peminjaman_penyewa_fk FOREIGN KEY ( id_penyewa )
        REFERENCES penyewa ( id_penyewa );

ALTER TABLE pengembalian
    ADD CONSTRAINT pengembalian_detail_transaksi_fk FOREIGN KEY ( id_detail_transaksi )
        REFERENCES detail_transaksi ( id_detail_transaksi );
