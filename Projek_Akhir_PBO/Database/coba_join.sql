perubahan relasinya
PK = primary key
PK pemilik ke kategori alat, agar data kategori yang ditampilkan sesuai pemilik yang input
PK peminjaman ke pengembalian, jadi bukan PK detail_transaksi ke pengembalian
PK pembayaran_ewallet ke peminjaman,  jadi bukan PK pembayaran_ewallet ke detail_transaksi
PK peminjaman ke laporan, jadi bukan PK detail_transaksi ke laporan
select * from pengembalian
select * from detail_transaksi
select * from laporan
select p.id_peminjaman, a.namaalatcamping, d.id_detail_transaksi, pm.id_pengembalian, e.nomor_ewallet
from pengembalian pm 
join peminjaman p on p.id_peminjaman=pm.id_peminjaman
join detail_transaksi d on p.id_peminjaman=d.id_peminjaman
join alat_camping a on a.id_alatcamping=d.id_alatcamping
join pembayaran_ewallet e on e.id_ewallet=p.id_ewallet
select * from penyewa
select * from admin
insert into pemilik(nama_pemilik, username, password, no_telepon_pemilik, alamat_pemilik)
values ('vika','vika123','123','0895684848','jalan singosari44')
insert into penyewa(nama_penyewa, username, password, no_telepon_penyewa, alamat_penyewa)
values ('feri','feri123','123','0895684999','jalan singosari44')