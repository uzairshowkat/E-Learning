create table tbl_admin(
ID int identity(1,1),
email varchar(100),
password varchar(50),
)
drop proc adminlogin
create proc adminlogin @user varchar(100),@password varchar(50)
as 
begin
select * from tbl_faculty where email=@user AND password=@password
end

create proc addmat @subject varchar(200),@name varchar(200),@path varchar(300),@author varchar(100),
@upload int,@extension varchar(20)
as
begin
insert into tbl_mat values((select s_id from tbl_sub where s_name=@subject),@name,@path,@author,(select ID from tbl_faculty where id=@upload),@extension)
end

insert into tbl_admin values('abc@gmail.com','12345');
drop proc adminlogin
drop table tbl_user
create table tbl_user
(
ID int identity(1,1) PRIMARY KEY,
Name varchar(50),
email varchar(100),
password varchar(100),
degree varchar(100),
role varchar(50),
status varchar(30) default 'inactive'
)

create table tbl_dep
(
ID int identity,
dep_name varchar(200) UNIQUE NOT NULL
)
create table tbl_faculty
(
id int identity(1,1) Primary Key,
name varchar(100),
email varchar(100),
password varchar(100),
role varchar(30),
status varchar(30) default 'inactive'
)
insert into tbl_faculty values('abc','abc@gmail.com','12345','admin','active')
delete from tbl_user
select * from tbl_user
drop table tbl_faculty
create table tbl_mat
(
ID int identity,
sub_id bigint,
topic varchar(200),
filepath varchar(300),
auth_name varchar(100),
uploaded_by int,
FOREIGN KEY(uploaded_by) REFERENCES tbl_faculty(id),
FOREIGN KEY(sub_id) REFERENCES tbl_sub(s_id)
)
create table tbl_sub
(
s_id bigint identity primary key,
s_name varchar(200),
d_id bigint
foreign key(d_id) REFERENCES tbl_dep(dep_id)
)
create table tbl_dep
(
dep_id bigint identity(1,1) Primary key,
dep_name varchar(100)
)
create table tbl_feed
(
f_id int identity(1,1) Primary key,
user_id int NOT NULL,
query varchar(4000),
FOREIGN KEY(user_id) REFERENCES tbl_user(ID)
)
create table tbl_ans
(
a_id int identity(1,1) Primary key,
q_id int,
answer varchar(4000),
FOREIGN KEY(q_id) REFERENCES tbl_feed(f_id)
)
create table tbl_art
(
art_id int primary key identity(1,1),
Title varchar(400),
art_by int,
body varchar(5000),
dep varchar(100),
foreign key(art_by) References tbl_faculty(id),
)
