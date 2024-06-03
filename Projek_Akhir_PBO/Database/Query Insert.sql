
insert into alat_camping (namaalatcamping,hargaalatcamping,jumlahalatcamping,deskripsi,dihentikan,id_pemilik,id_kategori)
values ('Kamera Cannon','20000','8','spesifikasi bisa zoom 1000x',false,1,1)
insert into alat_camping (namaalatcamping,hargaalatcamping,jumlahalatcamping,deskripsi,dihentikan,id_pemilik,id_kategori)
values ('Powebank','15000','6','baterai 120000 MAH',false,1,1)

Tidak disetujui
insert into pembayaran_ewallet(nomor_ewallet,jenis_ewallet)
values ('089685032962','Gopay')

insert into peminjaman(id_penyewa,tanggal_peminjaman,status_pinjam,id_ewallet)
values (1,'2024-10-21',false,1)

insert into detail_transaksi(id_peminjaman,id_alatcamping,lama_sewa,quantity)
values (1,1,10,5)
insert into detail_transaksi(id_peminjaman,id_alatcamping,lama_sewa,quantity)
values (1,2,10,5)

Disetujui
insert into pembayaran_ewallet(nomor_ewallet,jenis_ewallet)
values ('08134546782','Dana')

insert into peminjaman(id_penyewa,tanggal_peminjaman,status_pinjam,id_ewallet)
values (1,'2024-11-09',true,2)

insert into detail_transaksi(id_peminjaman,id_alatcamping,lama_sewa,quantity)
values (2,1,5,3)
insert into detail_transaksi(id_peminjaman,id_alatcamping,lama_sewa,quantity)
values (2,2,5,3)
-----
insert into pengembalian(tanggalpengembalian,denda,status_kembali,id_peminjaman)
values ('2024-12-09',10000,false,2)

select * from peminjaman