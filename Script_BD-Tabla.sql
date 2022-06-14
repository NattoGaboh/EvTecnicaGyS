---BD:MySQL
create database if not exists adm;
use adm;
create table if not exists Adm.Client(
CodCliente varchar(10) not null,
NombreCompleto varchar(200) not null,
NombreCorto varchar(40) not null,
Abreviatura varchar(40) not null,
Ruc varchar(11) not null,
Estado char(1) not null,
GrupoFacturacion varchar(100),
InactivoDesde datetime,
CodigoSAP varchar(20),
primary key(CodCliente)
);
