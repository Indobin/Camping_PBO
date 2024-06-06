toc.dat                                                                                             0000600 0004000 0002000 00000101250 14626567672 0014463 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP       6                |            Camping    16.2    16.2 i    [           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         \           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         ]           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         ^           1262    42409    Camping    DATABASE     �   CREATE DATABASE "Camping" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "Camping";
                postgres    false         �            1259    42564    admin    TABLE     �   CREATE TABLE public.admin (
    id_admin integer NOT NULL,
    nama_admin character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_admin character varying(13) NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false         �            1259    42563    admin_id_admin_seq    SEQUENCE     �   CREATE SEQUENCE public.admin_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.admin_id_admin_seq;
       public          postgres    false    220         _           0    0    admin_id_admin_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.admin_id_admin_seq OWNED BY public.admin.id_admin;
          public          postgres    false    219         �            1259    42728    alat_camping    TABLE     N  CREATE TABLE public.alat_camping (
    id_alatcamping integer NOT NULL,
    namaalatcamping character varying(60) NOT NULL,
    hargaalatcamping integer NOT NULL,
    jumlahalatcamping integer NOT NULL,
    deskripsi text NOT NULL,
    dihentikan boolean NOT NULL,
    id_pemilik integer NOT NULL,
    id_kategori integer NOT NULL
);
     DROP TABLE public.alat_camping;
       public         heap    postgres    false         �            1259    42725    alat_camping_id_alatcamping_seq    SEQUENCE     �   CREATE SEQUENCE public.alat_camping_id_alatcamping_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.alat_camping_id_alatcamping_seq;
       public          postgres    false    237         `           0    0    alat_camping_id_alatcamping_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.alat_camping_id_alatcamping_seq OWNED BY public.alat_camping.id_alatcamping;
          public          postgres    false    234         �            1259    42727    alat_camping_id_kategori_seq    SEQUENCE     �   CREATE SEQUENCE public.alat_camping_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.alat_camping_id_kategori_seq;
       public          postgres    false    237         a           0    0    alat_camping_id_kategori_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.alat_camping_id_kategori_seq OWNED BY public.alat_camping.id_kategori;
          public          postgres    false    236         �            1259    42726    alat_camping_id_pemilik_seq    SEQUENCE     �   CREATE SEQUENCE public.alat_camping_id_pemilik_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.alat_camping_id_pemilik_seq;
       public          postgres    false    237         b           0    0    alat_camping_id_pemilik_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.alat_camping_id_pemilik_seq OWNED BY public.alat_camping.id_pemilik;
          public          postgres    false    235         �            1259    42739    detail_transaksi    TABLE     �   CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_peminjaman integer NOT NULL,
    id_alatcamping integer NOT NULL,
    lama_sewa integer NOT NULL,
    quantity integer NOT NULL
);
 $   DROP TABLE public.detail_transaksi;
       public         heap    postgres    false         �            1259    42738 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE     �   CREATE SEQUENCE public.detail_transaksi_id_detail_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ?   DROP SEQUENCE public.detail_transaksi_id_detail_transaksi_seq;
       public          postgres    false    239         c           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE OWNED BY     u   ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNED BY public.detail_transaksi.id_detail_transaksi;
          public          postgres    false    238         �            1259    42704    kategori_alat_camping    TABLE     �   CREATE TABLE public.kategori_alat_camping (
    id_kategori integer NOT NULL,
    namakategori character varying(20) NOT NULL,
    id_pemilik integer NOT NULL,
    dihentikan boolean NOT NULL
);
 )   DROP TABLE public.kategori_alat_camping;
       public         heap    postgres    false         �            1259    42703 %   kategori_alat_camping_id_kategori_seq    SEQUENCE     �   CREATE SEQUENCE public.kategori_alat_camping_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 <   DROP SEQUENCE public.kategori_alat_camping_id_kategori_seq;
       public          postgres    false    233         d           0    0 %   kategori_alat_camping_id_kategori_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE public.kategori_alat_camping_id_kategori_seq OWNED BY public.kategori_alat_camping.id_kategori;
          public          postgres    false    232         �            1259    42692    laporan    TABLE     '  CREATE TABLE public.laporan (
    id_laporan integer NOT NULL,
    isi_laporan text NOT NULL,
    tanggallaporan date NOT NULL,
    statuslaporan character(1) NOT NULL,
    isi_tanggapan text,
    id_penyewa integer NOT NULL,
    id_admin integer NOT NULL,
    id_peminjaman integer NOT NULL
);
    DROP TABLE public.laporan;
       public         heap    postgres    false         �            1259    42690    laporan_id_admin_seq    SEQUENCE     �   CREATE SEQUENCE public.laporan_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.laporan_id_admin_seq;
       public          postgres    false    231         e           0    0    laporan_id_admin_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.laporan_id_admin_seq OWNED BY public.laporan.id_admin;
          public          postgres    false    230         �            1259    42688    laporan_id_laporan_seq    SEQUENCE     �   CREATE SEQUENCE public.laporan_id_laporan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.laporan_id_laporan_seq;
       public          postgres    false    231         f           0    0    laporan_id_laporan_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.laporan_id_laporan_seq OWNED BY public.laporan.id_laporan;
          public          postgres    false    228         �            1259    42689    laporan_id_penyewa_seq    SEQUENCE     �   CREATE SEQUENCE public.laporan_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.laporan_id_penyewa_seq;
       public          postgres    false    231         g           0    0    laporan_id_penyewa_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.laporan_id_penyewa_seq OWNED BY public.laporan.id_penyewa;
          public          postgres    false    229         �            1259    42682    pembayaran_ewallet    TABLE     �   CREATE TABLE public.pembayaran_ewallet (
    id_ewallet integer NOT NULL,
    nomor_ewallet character varying(25) NOT NULL,
    jenis_ewallet character varying(14) NOT NULL
);
 &   DROP TABLE public.pembayaran_ewallet;
       public         heap    postgres    false         �            1259    42681 !   pembayaran_ewallet_id_ewallet_seq    SEQUENCE     �   CREATE SEQUENCE public.pembayaran_ewallet_id_ewallet_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 8   DROP SEQUENCE public.pembayaran_ewallet_id_ewallet_seq;
       public          postgres    false    227         h           0    0 !   pembayaran_ewallet_id_ewallet_seq    SEQUENCE OWNED BY     g   ALTER SEQUENCE public.pembayaran_ewallet_id_ewallet_seq OWNED BY public.pembayaran_ewallet.id_ewallet;
          public          postgres    false    226         �            1259    42411    pemilik    TABLE     %  CREATE TABLE public.pemilik (
    id_pemilik integer NOT NULL,
    nama_pemilik character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_pemilik character varying(13) NOT NULL,
    alamat_pemilik text NOT NULL
);
    DROP TABLE public.pemilik;
       public         heap    postgres    false         �            1259    42410    pemilik_id_pemilik_seq    SEQUENCE     �   CREATE SEQUENCE public.pemilik_id_pemilik_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.pemilik_id_pemilik_seq;
       public          postgres    false    216         i           0    0    pemilik_id_pemilik_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.pemilik_id_pemilik_seq OWNED BY public.pemilik.id_pemilik;
          public          postgres    false    215         �            1259    42655 
   peminjaman    TABLE     �   CREATE TABLE public.peminjaman (
    id_peminjaman integer NOT NULL,
    id_penyewa integer NOT NULL,
    tanggal_peminjaman date NOT NULL,
    id_ewallet integer NOT NULL,
    status_pinjam boolean NOT NULL
);
    DROP TABLE public.peminjaman;
       public         heap    postgres    false         �            1259    42653    peminjaman_id_peminjaman_seq    SEQUENCE     �   CREATE SEQUENCE public.peminjaman_id_peminjaman_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public.peminjaman_id_peminjaman_seq;
       public          postgres    false    223         j           0    0    peminjaman_id_peminjaman_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public.peminjaman_id_peminjaman_seq OWNED BY public.peminjaman.id_peminjaman;
          public          postgres    false    221         �            1259    42654    peminjaman_id_penyewa_seq    SEQUENCE     �   CREATE SEQUENCE public.peminjaman_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.peminjaman_id_penyewa_seq;
       public          postgres    false    223         k           0    0    peminjaman_id_penyewa_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.peminjaman_id_penyewa_seq OWNED BY public.peminjaman.id_penyewa;
          public          postgres    false    222         �            1259    42673    pengembalian    TABLE     �   CREATE TABLE public.pengembalian (
    id_pengembalian integer NOT NULL,
    tanggalpengembalian date NOT NULL,
    denda character varying(10),
    status_kembali boolean NOT NULL,
    id_peminjaman integer NOT NULL
);
     DROP TABLE public.pengembalian;
       public         heap    postgres    false         �            1259    42671     pengembalian_id_pengembalian_seq    SEQUENCE     �   CREATE SEQUENCE public.pengembalian_id_pengembalian_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.pengembalian_id_pengembalian_seq;
       public          postgres    false    225         l           0    0     pengembalian_id_pengembalian_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.pengembalian_id_pengembalian_seq OWNED BY public.pengembalian.id_pengembalian;
          public          postgres    false    224         �            1259    42420    penyewa    TABLE     %  CREATE TABLE public.penyewa (
    id_penyewa integer NOT NULL,
    nama_penyewa character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_penyewa character varying(13) NOT NULL,
    alamat_penyewa text NOT NULL
);
    DROP TABLE public.penyewa;
       public         heap    postgres    false         �            1259    42419    penyewa_id_penyewa_seq    SEQUENCE     �   CREATE SEQUENCE public.penyewa_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.penyewa_id_penyewa_seq;
       public          postgres    false    218         m           0    0    penyewa_id_penyewa_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.penyewa_id_penyewa_seq OWNED BY public.penyewa.id_penyewa;
          public          postgres    false    217         �           2604    42567    admin id_admin    DEFAULT     p   ALTER TABLE ONLY public.admin ALTER COLUMN id_admin SET DEFAULT nextval('public.admin_id_admin_seq'::regclass);
 =   ALTER TABLE public.admin ALTER COLUMN id_admin DROP DEFAULT;
       public          postgres    false    219    220    220         �           2604    42731    alat_camping id_alatcamping    DEFAULT     �   ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_alatcamping SET DEFAULT nextval('public.alat_camping_id_alatcamping_seq'::regclass);
 J   ALTER TABLE public.alat_camping ALTER COLUMN id_alatcamping DROP DEFAULT;
       public          postgres    false    237    234    237         �           2604    42732    alat_camping id_pemilik    DEFAULT     �   ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_pemilik SET DEFAULT nextval('public.alat_camping_id_pemilik_seq'::regclass);
 F   ALTER TABLE public.alat_camping ALTER COLUMN id_pemilik DROP DEFAULT;
       public          postgres    false    237    235    237         �           2604    42733    alat_camping id_kategori    DEFAULT     �   ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_kategori SET DEFAULT nextval('public.alat_camping_id_kategori_seq'::regclass);
 G   ALTER TABLE public.alat_camping ALTER COLUMN id_kategori DROP DEFAULT;
       public          postgres    false    236    237    237         �           2604    42742 $   detail_transaksi id_detail_transaksi    DEFAULT     �   ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail_transaksi SET DEFAULT nextval('public.detail_transaksi_id_detail_transaksi_seq'::regclass);
 S   ALTER TABLE public.detail_transaksi ALTER COLUMN id_detail_transaksi DROP DEFAULT;
       public          postgres    false    238    239    239         �           2604    42707 !   kategori_alat_camping id_kategori    DEFAULT     �   ALTER TABLE ONLY public.kategori_alat_camping ALTER COLUMN id_kategori SET DEFAULT nextval('public.kategori_alat_camping_id_kategori_seq'::regclass);
 P   ALTER TABLE public.kategori_alat_camping ALTER COLUMN id_kategori DROP DEFAULT;
       public          postgres    false    232    233    233         �           2604    42695    laporan id_laporan    DEFAULT     x   ALTER TABLE ONLY public.laporan ALTER COLUMN id_laporan SET DEFAULT nextval('public.laporan_id_laporan_seq'::regclass);
 A   ALTER TABLE public.laporan ALTER COLUMN id_laporan DROP DEFAULT;
       public          postgres    false    231    228    231         �           2604    42696    laporan id_penyewa    DEFAULT     x   ALTER TABLE ONLY public.laporan ALTER COLUMN id_penyewa SET DEFAULT nextval('public.laporan_id_penyewa_seq'::regclass);
 A   ALTER TABLE public.laporan ALTER COLUMN id_penyewa DROP DEFAULT;
       public          postgres    false    229    231    231         �           2604    42697    laporan id_admin    DEFAULT     t   ALTER TABLE ONLY public.laporan ALTER COLUMN id_admin SET DEFAULT nextval('public.laporan_id_admin_seq'::regclass);
 ?   ALTER TABLE public.laporan ALTER COLUMN id_admin DROP DEFAULT;
       public          postgres    false    230    231    231         �           2604    42685    pembayaran_ewallet id_ewallet    DEFAULT     �   ALTER TABLE ONLY public.pembayaran_ewallet ALTER COLUMN id_ewallet SET DEFAULT nextval('public.pembayaran_ewallet_id_ewallet_seq'::regclass);
 L   ALTER TABLE public.pembayaran_ewallet ALTER COLUMN id_ewallet DROP DEFAULT;
       public          postgres    false    226    227    227         �           2604    42414    pemilik id_pemilik    DEFAULT     x   ALTER TABLE ONLY public.pemilik ALTER COLUMN id_pemilik SET DEFAULT nextval('public.pemilik_id_pemilik_seq'::regclass);
 A   ALTER TABLE public.pemilik ALTER COLUMN id_pemilik DROP DEFAULT;
       public          postgres    false    216    215    216         �           2604    42658    peminjaman id_peminjaman    DEFAULT     �   ALTER TABLE ONLY public.peminjaman ALTER COLUMN id_peminjaman SET DEFAULT nextval('public.peminjaman_id_peminjaman_seq'::regclass);
 G   ALTER TABLE public.peminjaman ALTER COLUMN id_peminjaman DROP DEFAULT;
       public          postgres    false    223    221    223         �           2604    42659    peminjaman id_penyewa    DEFAULT     ~   ALTER TABLE ONLY public.peminjaman ALTER COLUMN id_penyewa SET DEFAULT nextval('public.peminjaman_id_penyewa_seq'::regclass);
 D   ALTER TABLE public.peminjaman ALTER COLUMN id_penyewa DROP DEFAULT;
       public          postgres    false    223    222    223         �           2604    42676    pengembalian id_pengembalian    DEFAULT     �   ALTER TABLE ONLY public.pengembalian ALTER COLUMN id_pengembalian SET DEFAULT nextval('public.pengembalian_id_pengembalian_seq'::regclass);
 K   ALTER TABLE public.pengembalian ALTER COLUMN id_pengembalian DROP DEFAULT;
       public          postgres    false    224    225    225         �           2604    42423    penyewa id_penyewa    DEFAULT     x   ALTER TABLE ONLY public.penyewa ALTER COLUMN id_penyewa SET DEFAULT nextval('public.penyewa_id_penyewa_seq'::regclass);
 A   ALTER TABLE public.penyewa ALTER COLUMN id_penyewa DROP DEFAULT;
       public          postgres    false    217    218    218         E          0    42564    admin 
   TABLE DATA           [   COPY public.admin (id_admin, nama_admin, username, password, no_telepon_admin) FROM stdin;
    public          postgres    false    220       4933.dat V          0    42728    alat_camping 
   TABLE DATA           �   COPY public.alat_camping (id_alatcamping, namaalatcamping, hargaalatcamping, jumlahalatcamping, deskripsi, dihentikan, id_pemilik, id_kategori) FROM stdin;
    public          postgres    false    237       4950.dat X          0    42739    detail_transaksi 
   TABLE DATA           s   COPY public.detail_transaksi (id_detail_transaksi, id_peminjaman, id_alatcamping, lama_sewa, quantity) FROM stdin;
    public          postgres    false    239       4952.dat R          0    42704    kategori_alat_camping 
   TABLE DATA           b   COPY public.kategori_alat_camping (id_kategori, namakategori, id_pemilik, dihentikan) FROM stdin;
    public          postgres    false    233       4946.dat P          0    42692    laporan 
   TABLE DATA           �   COPY public.laporan (id_laporan, isi_laporan, tanggallaporan, statuslaporan, isi_tanggapan, id_penyewa, id_admin, id_peminjaman) FROM stdin;
    public          postgres    false    231       4944.dat L          0    42682    pembayaran_ewallet 
   TABLE DATA           V   COPY public.pembayaran_ewallet (id_ewallet, nomor_ewallet, jenis_ewallet) FROM stdin;
    public          postgres    false    227       4940.dat A          0    42411    pemilik 
   TABLE DATA           s   COPY public.pemilik (id_pemilik, nama_pemilik, username, password, no_telepon_pemilik, alamat_pemilik) FROM stdin;
    public          postgres    false    216       4929.dat H          0    42655 
   peminjaman 
   TABLE DATA           n   COPY public.peminjaman (id_peminjaman, id_penyewa, tanggal_peminjaman, id_ewallet, status_pinjam) FROM stdin;
    public          postgres    false    223       4936.dat J          0    42673    pengembalian 
   TABLE DATA           r   COPY public.pengembalian (id_pengembalian, tanggalpengembalian, denda, status_kembali, id_peminjaman) FROM stdin;
    public          postgres    false    225       4938.dat C          0    42420    penyewa 
   TABLE DATA           s   COPY public.penyewa (id_penyewa, nama_penyewa, username, password, no_telepon_penyewa, alamat_penyewa) FROM stdin;
    public          postgres    false    218       4931.dat n           0    0    admin_id_admin_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.admin_id_admin_seq', 2, true);
          public          postgres    false    219         o           0    0    alat_camping_id_alatcamping_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.alat_camping_id_alatcamping_seq', 2, true);
          public          postgres    false    234         p           0    0    alat_camping_id_kategori_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public.alat_camping_id_kategori_seq', 1, false);
          public          postgres    false    236         q           0    0    alat_camping_id_pemilik_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.alat_camping_id_pemilik_seq', 1, false);
          public          postgres    false    235         r           0    0 (   detail_transaksi_id_detail_transaksi_seq    SEQUENCE SET     V   SELECT pg_catalog.setval('public.detail_transaksi_id_detail_transaksi_seq', 4, true);
          public          postgres    false    238         s           0    0 %   kategori_alat_camping_id_kategori_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.kategori_alat_camping_id_kategori_seq', 1, true);
          public          postgres    false    232         t           0    0    laporan_id_admin_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.laporan_id_admin_seq', 1, false);
          public          postgres    false    230         u           0    0    laporan_id_laporan_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.laporan_id_laporan_seq', 1, false);
          public          postgres    false    228         v           0    0    laporan_id_penyewa_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.laporan_id_penyewa_seq', 1, false);
          public          postgres    false    229         w           0    0 !   pembayaran_ewallet_id_ewallet_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.pembayaran_ewallet_id_ewallet_seq', 2, true);
          public          postgres    false    226         x           0    0    pemilik_id_pemilik_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.pemilik_id_pemilik_seq', 1, true);
          public          postgres    false    215         y           0    0    peminjaman_id_peminjaman_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.peminjaman_id_peminjaman_seq', 2, true);
          public          postgres    false    221         z           0    0    peminjaman_id_penyewa_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.peminjaman_id_penyewa_seq', 1, false);
          public          postgres    false    222         {           0    0     pengembalian_id_pengembalian_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.pengembalian_id_pengembalian_seq', 1, true);
          public          postgres    false    224         |           0    0    penyewa_id_penyewa_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.penyewa_id_penyewa_seq', 1, true);
          public          postgres    false    217         �           2606    42569    admin admin_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id_admin);
 :   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_pkey;
       public            postgres    false    220         �           2606    42737    alat_camping alat_camping_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_pkey PRIMARY KEY (id_alatcamping);
 H   ALTER TABLE ONLY public.alat_camping DROP CONSTRAINT alat_camping_pkey;
       public            postgres    false    237         �           2606    42744 &   detail_transaksi detail_transaksi_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);
 P   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_pkey;
       public            postgres    false    239         �           2606    42711 <   kategori_alat_camping kategori_alat_camping_namakategori_key 
   CONSTRAINT        ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_namakategori_key UNIQUE (namakategori);
 f   ALTER TABLE ONLY public.kategori_alat_camping DROP CONSTRAINT kategori_alat_camping_namakategori_key;
       public            postgres    false    233         �           2606    42709 0   kategori_alat_camping kategori_alat_camping_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_pkey PRIMARY KEY (id_kategori);
 Z   ALTER TABLE ONLY public.kategori_alat_camping DROP CONSTRAINT kategori_alat_camping_pkey;
       public            postgres    false    233         �           2606    42702    laporan laporan_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_pkey PRIMARY KEY (id_laporan);
 >   ALTER TABLE ONLY public.laporan DROP CONSTRAINT laporan_pkey;
       public            postgres    false    231         �           2606    42687 *   pembayaran_ewallet pembayaran_ewallet_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.pembayaran_ewallet
    ADD CONSTRAINT pembayaran_ewallet_pkey PRIMARY KEY (id_ewallet);
 T   ALTER TABLE ONLY public.pembayaran_ewallet DROP CONSTRAINT pembayaran_ewallet_pkey;
       public            postgres    false    227         �           2606    42418    pemilik pemilik_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.pemilik
    ADD CONSTRAINT pemilik_pkey PRIMARY KEY (id_pemilik);
 >   ALTER TABLE ONLY public.pemilik DROP CONSTRAINT pemilik_pkey;
       public            postgres    false    216         �           2606    42661    peminjaman peminjaman_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT peminjaman_pkey PRIMARY KEY (id_peminjaman);
 D   ALTER TABLE ONLY public.peminjaman DROP CONSTRAINT peminjaman_pkey;
       public            postgres    false    223         �           2606    42679    pengembalian pengembalian_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.pengembalian
    ADD CONSTRAINT pengembalian_pkey PRIMARY KEY (id_pengembalian);
 H   ALTER TABLE ONLY public.pengembalian DROP CONSTRAINT pengembalian_pkey;
       public            postgres    false    225         �           2606    42427    penyewa penyewa_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.penyewa
    ADD CONSTRAINT penyewa_pkey PRIMARY KEY (id_penyewa);
 >   ALTER TABLE ONLY public.penyewa DROP CONSTRAINT penyewa_pkey;
       public            postgres    false    218         �           2606    42760 !   peminjaman Peminjaman_E-wallet_FK    FK CONSTRAINT     �   ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT "Peminjaman_E-wallet_FK" FOREIGN KEY (id_ewallet) REFERENCES public.pembayaran_ewallet(id_ewallet);
 M   ALTER TABLE ONLY public.peminjaman DROP CONSTRAINT "Peminjaman_E-wallet_FK";
       public          postgres    false    4764    223    227         �           2606    42745 2   alat_camping alat_camping_kategori_alat_camping_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_kategori_alat_camping_fk FOREIGN KEY (id_kategori) REFERENCES public.kategori_alat_camping(id_kategori);
 \   ALTER TABLE ONLY public.alat_camping DROP CONSTRAINT alat_camping_kategori_alat_camping_fk;
       public          postgres    false    237    233    4770         �           2606    42750 $   alat_camping alat_camping_pemilik_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_pemilik_fk FOREIGN KEY (id_pemilik) REFERENCES public.pemilik(id_pemilik);
 N   ALTER TABLE ONLY public.alat_camping DROP CONSTRAINT alat_camping_pemilik_fk;
       public          postgres    false    237    4754    216         �           2606    42755 1   detail_transaksi detail_transaksi_alat_camping_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_alat_camping_fk FOREIGN KEY (id_alatcamping) REFERENCES public.alat_camping(id_alatcamping);
 [   ALTER TABLE ONLY public.detail_transaksi DROP CONSTRAINT detail_transaksi_alat_camping_fk;
       public          postgres    false    239    4772    237         �           2606    42790 6   kategori_alat_camping kategori_alat_camping_pemilik_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_pemilik_fk FOREIGN KEY (id_pemilik) REFERENCES public.pemilik(id_pemilik);
 `   ALTER TABLE ONLY public.kategori_alat_camping DROP CONSTRAINT kategori_alat_camping_pemilik_fk;
       public          postgres    false    4754    233    216         �           2606    42765    laporan laporan_admin_fk    FK CONSTRAINT     ~   ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_admin_fk FOREIGN KEY (id_admin) REFERENCES public.admin(id_admin);
 B   ALTER TABLE ONLY public.laporan DROP CONSTRAINT laporan_admin_fk;
       public          postgres    false    231    220    4758         �           2606    42801 !   laporan laporan_detail_peminjaman    FK CONSTRAINT     �   ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_detail_peminjaman FOREIGN KEY (id_peminjaman) REFERENCES public.peminjaman(id_peminjaman);
 K   ALTER TABLE ONLY public.laporan DROP CONSTRAINT laporan_detail_peminjaman;
       public          postgres    false    4760    223    231         �           2606    42775    laporan laporan_penyewa_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_penyewa_fk FOREIGN KEY (id_penyewa) REFERENCES public.penyewa(id_penyewa);
 D   ALTER TABLE ONLY public.laporan DROP CONSTRAINT laporan_penyewa_fk;
       public          postgres    false    218    4756    231         �           2606    42780     peminjaman peminjaman_penyewa_fk    FK CONSTRAINT     �   ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT peminjaman_penyewa_fk FOREIGN KEY (id_penyewa) REFERENCES public.penyewa(id_penyewa);
 J   ALTER TABLE ONLY public.peminjaman DROP CONSTRAINT peminjaman_penyewa_fk;
       public          postgres    false    4756    223    218         �           2606    42796 $   pengembalian pengembalian_peminjaman    FK CONSTRAINT     �   ALTER TABLE ONLY public.pengembalian
    ADD CONSTRAINT pengembalian_peminjaman FOREIGN KEY (id_peminjaman) REFERENCES public.peminjaman(id_peminjaman);
 N   ALTER TABLE ONLY public.pengembalian DROP CONSTRAINT pengembalian_peminjaman;
       public          postgres    false    223    225    4760                                                                                                                                                                                                                                                                                                                                                                4933.dat                                                                                            0000600 0004000 0002000 00000000105 14626567672 0014275 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	rogi	rogi123	123	089685858585
2	rodan	rodan321	321	0897858585
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                           4950.dat                                                                                            0000600 0004000 0002000 00000000153 14626567672 0014277 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Kamera Cannon	20000	8	spesifikasi bisa zoom 1000x	f	1	1
2	Powebank	15000	6	baterai 120000 MAH	f	1	1
\.


                                                                                                                                                                                                                                                                                                                                                                                                                     4952.dat                                                                                            0000600 0004000 0002000 00000000057 14626567672 0014304 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	1	1	10	5
2	1	2	10	5
3	2	1	5	3
4	2	2	5	3
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 4946.dat                                                                                            0000600 0004000 0002000 00000000026 14626567672 0014303 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Elektronik	1	f
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          4944.dat                                                                                            0000600 0004000 0002000 00000000005 14626567672 0014276 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        \.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           4940.dat                                                                                            0000600 0004000 0002000 00000000055 14626567672 0014277 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	089685032962	Gopay
2	08134546782	Dana
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   4929.dat                                                                                            0000600 0004000 0002000 00000000074 14626567672 0014307 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	satya	satya123	123	089685042861	jalan singosari no32
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                    4936.dat                                                                                            0000600 0004000 0002000 00000000053 14626567672 0014302 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	1	2024-10-21	1	f
2	1	2024-11-09	2	t
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     4938.dat                                                                                            0000600 0004000 0002000 00000000034 14626567672 0014303 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	2024-12-09	10000	f	2
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    4931.dat                                                                                            0000600 0004000 0002000 00000000100 14626567672 0014266 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Bintang	Bintang123	123	089685042999	jalan singosari no34
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                restore.sql                                                                                         0000600 0004000 0002000 00000064330 14626567672 0015417 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "Camping";
--
-- Name: Camping; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Camping" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';


ALTER DATABASE "Camping" OWNER TO postgres;

\connect "Camping"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: admin; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.admin (
    id_admin integer NOT NULL,
    nama_admin character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_admin character varying(13) NOT NULL
);


ALTER TABLE public.admin OWNER TO postgres;

--
-- Name: admin_id_admin_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.admin_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.admin_id_admin_seq OWNER TO postgres;

--
-- Name: admin_id_admin_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.admin_id_admin_seq OWNED BY public.admin.id_admin;


--
-- Name: alat_camping; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.alat_camping (
    id_alatcamping integer NOT NULL,
    namaalatcamping character varying(60) NOT NULL,
    hargaalatcamping integer NOT NULL,
    jumlahalatcamping integer NOT NULL,
    deskripsi text NOT NULL,
    dihentikan boolean NOT NULL,
    id_pemilik integer NOT NULL,
    id_kategori integer NOT NULL
);


ALTER TABLE public.alat_camping OWNER TO postgres;

--
-- Name: alat_camping_id_alatcamping_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.alat_camping_id_alatcamping_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.alat_camping_id_alatcamping_seq OWNER TO postgres;

--
-- Name: alat_camping_id_alatcamping_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.alat_camping_id_alatcamping_seq OWNED BY public.alat_camping.id_alatcamping;


--
-- Name: alat_camping_id_kategori_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.alat_camping_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.alat_camping_id_kategori_seq OWNER TO postgres;

--
-- Name: alat_camping_id_kategori_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.alat_camping_id_kategori_seq OWNED BY public.alat_camping.id_kategori;


--
-- Name: alat_camping_id_pemilik_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.alat_camping_id_pemilik_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.alat_camping_id_pemilik_seq OWNER TO postgres;

--
-- Name: alat_camping_id_pemilik_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.alat_camping_id_pemilik_seq OWNED BY public.alat_camping.id_pemilik;


--
-- Name: detail_transaksi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detail_transaksi (
    id_detail_transaksi integer NOT NULL,
    id_peminjaman integer NOT NULL,
    id_alatcamping integer NOT NULL,
    lama_sewa integer NOT NULL,
    quantity integer NOT NULL
);


ALTER TABLE public.detail_transaksi OWNER TO postgres;

--
-- Name: detail_transaksi_id_detail_transaksi_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.detail_transaksi_id_detail_transaksi_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNER TO postgres;

--
-- Name: detail_transaksi_id_detail_transaksi_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.detail_transaksi_id_detail_transaksi_seq OWNED BY public.detail_transaksi.id_detail_transaksi;


--
-- Name: kategori_alat_camping; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategori_alat_camping (
    id_kategori integer NOT NULL,
    namakategori character varying(20) NOT NULL,
    id_pemilik integer NOT NULL,
    dihentikan boolean NOT NULL
);


ALTER TABLE public.kategori_alat_camping OWNER TO postgres;

--
-- Name: kategori_alat_camping_id_kategori_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.kategori_alat_camping_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.kategori_alat_camping_id_kategori_seq OWNER TO postgres;

--
-- Name: kategori_alat_camping_id_kategori_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.kategori_alat_camping_id_kategori_seq OWNED BY public.kategori_alat_camping.id_kategori;


--
-- Name: laporan; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.laporan (
    id_laporan integer NOT NULL,
    isi_laporan text NOT NULL,
    tanggallaporan date NOT NULL,
    statuslaporan character(1) NOT NULL,
    isi_tanggapan text,
    id_penyewa integer NOT NULL,
    id_admin integer NOT NULL,
    id_peminjaman integer NOT NULL
);


ALTER TABLE public.laporan OWNER TO postgres;

--
-- Name: laporan_id_admin_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.laporan_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.laporan_id_admin_seq OWNER TO postgres;

--
-- Name: laporan_id_admin_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.laporan_id_admin_seq OWNED BY public.laporan.id_admin;


--
-- Name: laporan_id_laporan_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.laporan_id_laporan_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.laporan_id_laporan_seq OWNER TO postgres;

--
-- Name: laporan_id_laporan_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.laporan_id_laporan_seq OWNED BY public.laporan.id_laporan;


--
-- Name: laporan_id_penyewa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.laporan_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.laporan_id_penyewa_seq OWNER TO postgres;

--
-- Name: laporan_id_penyewa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.laporan_id_penyewa_seq OWNED BY public.laporan.id_penyewa;


--
-- Name: pembayaran_ewallet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pembayaran_ewallet (
    id_ewallet integer NOT NULL,
    nomor_ewallet character varying(25) NOT NULL,
    jenis_ewallet character varying(14) NOT NULL
);


ALTER TABLE public.pembayaran_ewallet OWNER TO postgres;

--
-- Name: pembayaran_ewallet_id_ewallet_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pembayaran_ewallet_id_ewallet_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pembayaran_ewallet_id_ewallet_seq OWNER TO postgres;

--
-- Name: pembayaran_ewallet_id_ewallet_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pembayaran_ewallet_id_ewallet_seq OWNED BY public.pembayaran_ewallet.id_ewallet;


--
-- Name: pemilik; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pemilik (
    id_pemilik integer NOT NULL,
    nama_pemilik character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_pemilik character varying(13) NOT NULL,
    alamat_pemilik text NOT NULL
);


ALTER TABLE public.pemilik OWNER TO postgres;

--
-- Name: pemilik_id_pemilik_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pemilik_id_pemilik_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pemilik_id_pemilik_seq OWNER TO postgres;

--
-- Name: pemilik_id_pemilik_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pemilik_id_pemilik_seq OWNED BY public.pemilik.id_pemilik;


--
-- Name: peminjaman; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.peminjaman (
    id_peminjaman integer NOT NULL,
    id_penyewa integer NOT NULL,
    tanggal_peminjaman date NOT NULL,
    id_ewallet integer NOT NULL,
    status_pinjam boolean NOT NULL
);


ALTER TABLE public.peminjaman OWNER TO postgres;

--
-- Name: peminjaman_id_peminjaman_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.peminjaman_id_peminjaman_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.peminjaman_id_peminjaman_seq OWNER TO postgres;

--
-- Name: peminjaman_id_peminjaman_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.peminjaman_id_peminjaman_seq OWNED BY public.peminjaman.id_peminjaman;


--
-- Name: peminjaman_id_penyewa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.peminjaman_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.peminjaman_id_penyewa_seq OWNER TO postgres;

--
-- Name: peminjaman_id_penyewa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.peminjaman_id_penyewa_seq OWNED BY public.peminjaman.id_penyewa;


--
-- Name: pengembalian; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pengembalian (
    id_pengembalian integer NOT NULL,
    tanggalpengembalian date NOT NULL,
    denda character varying(10),
    status_kembali boolean NOT NULL,
    id_peminjaman integer NOT NULL
);


ALTER TABLE public.pengembalian OWNER TO postgres;

--
-- Name: pengembalian_id_pengembalian_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pengembalian_id_pengembalian_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pengembalian_id_pengembalian_seq OWNER TO postgres;

--
-- Name: pengembalian_id_pengembalian_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pengembalian_id_pengembalian_seq OWNED BY public.pengembalian.id_pengembalian;


--
-- Name: penyewa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.penyewa (
    id_penyewa integer NOT NULL,
    nama_penyewa character varying(60) NOT NULL,
    username character varying(60) NOT NULL,
    password character varying(60) NOT NULL,
    no_telepon_penyewa character varying(13) NOT NULL,
    alamat_penyewa text NOT NULL
);


ALTER TABLE public.penyewa OWNER TO postgres;

--
-- Name: penyewa_id_penyewa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.penyewa_id_penyewa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.penyewa_id_penyewa_seq OWNER TO postgres;

--
-- Name: penyewa_id_penyewa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.penyewa_id_penyewa_seq OWNED BY public.penyewa.id_penyewa;


--
-- Name: admin id_admin; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admin ALTER COLUMN id_admin SET DEFAULT nextval('public.admin_id_admin_seq'::regclass);


--
-- Name: alat_camping id_alatcamping; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_alatcamping SET DEFAULT nextval('public.alat_camping_id_alatcamping_seq'::regclass);


--
-- Name: alat_camping id_pemilik; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_pemilik SET DEFAULT nextval('public.alat_camping_id_pemilik_seq'::regclass);


--
-- Name: alat_camping id_kategori; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping ALTER COLUMN id_kategori SET DEFAULT nextval('public.alat_camping_id_kategori_seq'::regclass);


--
-- Name: detail_transaksi id_detail_transaksi; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_transaksi ALTER COLUMN id_detail_transaksi SET DEFAULT nextval('public.detail_transaksi_id_detail_transaksi_seq'::regclass);


--
-- Name: kategori_alat_camping id_kategori; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori_alat_camping ALTER COLUMN id_kategori SET DEFAULT nextval('public.kategori_alat_camping_id_kategori_seq'::regclass);


--
-- Name: laporan id_laporan; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan ALTER COLUMN id_laporan SET DEFAULT nextval('public.laporan_id_laporan_seq'::regclass);


--
-- Name: laporan id_penyewa; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan ALTER COLUMN id_penyewa SET DEFAULT nextval('public.laporan_id_penyewa_seq'::regclass);


--
-- Name: laporan id_admin; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan ALTER COLUMN id_admin SET DEFAULT nextval('public.laporan_id_admin_seq'::regclass);


--
-- Name: pembayaran_ewallet id_ewallet; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pembayaran_ewallet ALTER COLUMN id_ewallet SET DEFAULT nextval('public.pembayaran_ewallet_id_ewallet_seq'::regclass);


--
-- Name: pemilik id_pemilik; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pemilik ALTER COLUMN id_pemilik SET DEFAULT nextval('public.pemilik_id_pemilik_seq'::regclass);


--
-- Name: peminjaman id_peminjaman; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peminjaman ALTER COLUMN id_peminjaman SET DEFAULT nextval('public.peminjaman_id_peminjaman_seq'::regclass);


--
-- Name: peminjaman id_penyewa; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peminjaman ALTER COLUMN id_penyewa SET DEFAULT nextval('public.peminjaman_id_penyewa_seq'::regclass);


--
-- Name: pengembalian id_pengembalian; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pengembalian ALTER COLUMN id_pengembalian SET DEFAULT nextval('public.pengembalian_id_pengembalian_seq'::regclass);


--
-- Name: penyewa id_penyewa; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.penyewa ALTER COLUMN id_penyewa SET DEFAULT nextval('public.penyewa_id_penyewa_seq'::regclass);


--
-- Data for Name: admin; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.admin (id_admin, nama_admin, username, password, no_telepon_admin) FROM stdin;
\.
COPY public.admin (id_admin, nama_admin, username, password, no_telepon_admin) FROM '$$PATH$$/4933.dat';

--
-- Data for Name: alat_camping; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.alat_camping (id_alatcamping, namaalatcamping, hargaalatcamping, jumlahalatcamping, deskripsi, dihentikan, id_pemilik, id_kategori) FROM stdin;
\.
COPY public.alat_camping (id_alatcamping, namaalatcamping, hargaalatcamping, jumlahalatcamping, deskripsi, dihentikan, id_pemilik, id_kategori) FROM '$$PATH$$/4950.dat';

--
-- Data for Name: detail_transaksi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detail_transaksi (id_detail_transaksi, id_peminjaman, id_alatcamping, lama_sewa, quantity) FROM stdin;
\.
COPY public.detail_transaksi (id_detail_transaksi, id_peminjaman, id_alatcamping, lama_sewa, quantity) FROM '$$PATH$$/4952.dat';

--
-- Data for Name: kategori_alat_camping; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.kategori_alat_camping (id_kategori, namakategori, id_pemilik, dihentikan) FROM stdin;
\.
COPY public.kategori_alat_camping (id_kategori, namakategori, id_pemilik, dihentikan) FROM '$$PATH$$/4946.dat';

--
-- Data for Name: laporan; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.laporan (id_laporan, isi_laporan, tanggallaporan, statuslaporan, isi_tanggapan, id_penyewa, id_admin, id_peminjaman) FROM stdin;
\.
COPY public.laporan (id_laporan, isi_laporan, tanggallaporan, statuslaporan, isi_tanggapan, id_penyewa, id_admin, id_peminjaman) FROM '$$PATH$$/4944.dat';

--
-- Data for Name: pembayaran_ewallet; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pembayaran_ewallet (id_ewallet, nomor_ewallet, jenis_ewallet) FROM stdin;
\.
COPY public.pembayaran_ewallet (id_ewallet, nomor_ewallet, jenis_ewallet) FROM '$$PATH$$/4940.dat';

--
-- Data for Name: pemilik; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pemilik (id_pemilik, nama_pemilik, username, password, no_telepon_pemilik, alamat_pemilik) FROM stdin;
\.
COPY public.pemilik (id_pemilik, nama_pemilik, username, password, no_telepon_pemilik, alamat_pemilik) FROM '$$PATH$$/4929.dat';

--
-- Data for Name: peminjaman; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.peminjaman (id_peminjaman, id_penyewa, tanggal_peminjaman, id_ewallet, status_pinjam) FROM stdin;
\.
COPY public.peminjaman (id_peminjaman, id_penyewa, tanggal_peminjaman, id_ewallet, status_pinjam) FROM '$$PATH$$/4936.dat';

--
-- Data for Name: pengembalian; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pengembalian (id_pengembalian, tanggalpengembalian, denda, status_kembali, id_peminjaman) FROM stdin;
\.
COPY public.pengembalian (id_pengembalian, tanggalpengembalian, denda, status_kembali, id_peminjaman) FROM '$$PATH$$/4938.dat';

--
-- Data for Name: penyewa; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.penyewa (id_penyewa, nama_penyewa, username, password, no_telepon_penyewa, alamat_penyewa) FROM stdin;
\.
COPY public.penyewa (id_penyewa, nama_penyewa, username, password, no_telepon_penyewa, alamat_penyewa) FROM '$$PATH$$/4931.dat';

--
-- Name: admin_id_admin_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.admin_id_admin_seq', 2, true);


--
-- Name: alat_camping_id_alatcamping_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.alat_camping_id_alatcamping_seq', 2, true);


--
-- Name: alat_camping_id_kategori_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.alat_camping_id_kategori_seq', 1, false);


--
-- Name: alat_camping_id_pemilik_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.alat_camping_id_pemilik_seq', 1, false);


--
-- Name: detail_transaksi_id_detail_transaksi_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detail_transaksi_id_detail_transaksi_seq', 4, true);


--
-- Name: kategori_alat_camping_id_kategori_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.kategori_alat_camping_id_kategori_seq', 1, true);


--
-- Name: laporan_id_admin_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.laporan_id_admin_seq', 1, false);


--
-- Name: laporan_id_laporan_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.laporan_id_laporan_seq', 1, false);


--
-- Name: laporan_id_penyewa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.laporan_id_penyewa_seq', 1, false);


--
-- Name: pembayaran_ewallet_id_ewallet_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pembayaran_ewallet_id_ewallet_seq', 2, true);


--
-- Name: pemilik_id_pemilik_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pemilik_id_pemilik_seq', 1, true);


--
-- Name: peminjaman_id_peminjaman_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.peminjaman_id_peminjaman_seq', 2, true);


--
-- Name: peminjaman_id_penyewa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.peminjaman_id_penyewa_seq', 1, false);


--
-- Name: pengembalian_id_pengembalian_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pengembalian_id_pengembalian_seq', 1, true);


--
-- Name: penyewa_id_penyewa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.penyewa_id_penyewa_seq', 1, true);


--
-- Name: admin admin_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id_admin);


--
-- Name: alat_camping alat_camping_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_pkey PRIMARY KEY (id_alatcamping);


--
-- Name: detail_transaksi detail_transaksi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi);


--
-- Name: kategori_alat_camping kategori_alat_camping_namakategori_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_namakategori_key UNIQUE (namakategori);


--
-- Name: kategori_alat_camping kategori_alat_camping_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_pkey PRIMARY KEY (id_kategori);


--
-- Name: laporan laporan_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_pkey PRIMARY KEY (id_laporan);


--
-- Name: pembayaran_ewallet pembayaran_ewallet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pembayaran_ewallet
    ADD CONSTRAINT pembayaran_ewallet_pkey PRIMARY KEY (id_ewallet);


--
-- Name: pemilik pemilik_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pemilik
    ADD CONSTRAINT pemilik_pkey PRIMARY KEY (id_pemilik);


--
-- Name: peminjaman peminjaman_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT peminjaman_pkey PRIMARY KEY (id_peminjaman);


--
-- Name: pengembalian pengembalian_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pengembalian
    ADD CONSTRAINT pengembalian_pkey PRIMARY KEY (id_pengembalian);


--
-- Name: penyewa penyewa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.penyewa
    ADD CONSTRAINT penyewa_pkey PRIMARY KEY (id_penyewa);


--
-- Name: peminjaman Peminjaman_E-wallet_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT "Peminjaman_E-wallet_FK" FOREIGN KEY (id_ewallet) REFERENCES public.pembayaran_ewallet(id_ewallet);


--
-- Name: alat_camping alat_camping_kategori_alat_camping_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_kategori_alat_camping_fk FOREIGN KEY (id_kategori) REFERENCES public.kategori_alat_camping(id_kategori);


--
-- Name: alat_camping alat_camping_pemilik_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alat_camping
    ADD CONSTRAINT alat_camping_pemilik_fk FOREIGN KEY (id_pemilik) REFERENCES public.pemilik(id_pemilik);


--
-- Name: detail_transaksi detail_transaksi_alat_camping_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_alat_camping_fk FOREIGN KEY (id_alatcamping) REFERENCES public.alat_camping(id_alatcamping);


--
-- Name: kategori_alat_camping kategori_alat_camping_pemilik_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori_alat_camping
    ADD CONSTRAINT kategori_alat_camping_pemilik_fk FOREIGN KEY (id_pemilik) REFERENCES public.pemilik(id_pemilik);


--
-- Name: laporan laporan_admin_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_admin_fk FOREIGN KEY (id_admin) REFERENCES public.admin(id_admin);


--
-- Name: laporan laporan_detail_peminjaman; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_detail_peminjaman FOREIGN KEY (id_peminjaman) REFERENCES public.peminjaman(id_peminjaman);


--
-- Name: laporan laporan_penyewa_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.laporan
    ADD CONSTRAINT laporan_penyewa_fk FOREIGN KEY (id_penyewa) REFERENCES public.penyewa(id_penyewa);


--
-- Name: peminjaman peminjaman_penyewa_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peminjaman
    ADD CONSTRAINT peminjaman_penyewa_fk FOREIGN KEY (id_penyewa) REFERENCES public.penyewa(id_penyewa);


--
-- Name: pengembalian pengembalian_peminjaman; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pengembalian
    ADD CONSTRAINT pengembalian_peminjaman FOREIGN KEY (id_peminjaman) REFERENCES public.peminjaman(id_peminjaman);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        