create database sistema;
use sistema;
create table usuario(
id int primary key auto_increment,
nome varchar(60),
email varchar(100),
senha varchar(60)
);
select * from usuario;