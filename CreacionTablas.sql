create database MCVill_Empleados;

use MCVill_Empleados;

create table Empleados(
IDEmp			varchar(8) primary key not null,
NomEmp			varchar(50),
ApeEmp			varchar(50),
FechaIngreso	varchar(50)
);

create table Fecha_Empleado(
IDEmp			varchar(8),
VacAct			varchar(50),
DiasXtomar		int,
VacTom			varchar(4),
Periodo			varchar(50),
foreign key (IDEmp) references Empleados(IDEmp)
);


use MCVill_Empleados;
INSERT INTO Empleados(IDEmp, NomEmp, ApeEmp, FechaIngreso)
values			('201829',	'Josefina',		'Hernandez',	'17/05/2020'),
				('131510',	'Adrian',		'Dominguez',	'30/07/2021'),
				('125482',	'Sebastian',	'Ruvalcaba',	'25/06/2018'),
				('250670',	'Juan Jose',	'Perez',		'20/02/2020'),
				('114510',	'Mauricio',		'Medina',		'15/07/2021')
 			