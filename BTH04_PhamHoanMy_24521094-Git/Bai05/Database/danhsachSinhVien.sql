if not exists (select * from sys.databases where name = 'QLSINHVIEN')
begin
	create database QLSINHVIEN
end
go 

use QLSINHVIEN
go

if not exists (select * from sys.tables where name = 'SINHVIEN')
begin
	create table SINHVIEN
	(
		MSSV nvarchar(8) primary key, 
		TenSV nvarchar(50) not null, 
		Khoa nvarchar(80),
		DiemTB float
	)

	insert into SINHVIEN (MSSV, TenSV, Khoa, DiemTB)
	values ('24501094',N'Phạm Hoàn Mỹ', N'Khoa Công Phần Mềm', 4.9);
	insert into SINHVIEN (MSSV, TenSV, Khoa, DiemTB)
	values ('24500001',N'Con Nhà Người Ta', N'Khoa Công Phần Mềm', 9.9);
end




