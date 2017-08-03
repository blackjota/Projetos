create database Escola
use Escola
create table  curso(
	codCur int primary key identity (1,1),
	nomeCurso varchar(50),
	nro_Vagas int,
)


create table disciplina(
	codDisc int primary key identity (1,1),
	nomeDisc varchar(50),
)

create table departamento(
	codDep int primary key identity (1,1),
	depto varchar (50),
)

create table pessoa(
	codPes int primary key identity (1,1),
	nomePes varchar (50)
)



create table livros(
	codLivro int primary key identity (1,1),
	nomeLivro varchar(50),
)

insert into pessoa
values
	('João'),
	('Maria'),
	('Jorge'),
	('Joana')

insert into departamento
values
	('Administração'),
	('Limpeza'),
	('TI'),
	('Contabilidade')

insert into livros
values
	('aaaaaa'),
	('bbbbbb'),
	('cccccc'),
	('dddddd')

insert into curso
values
	('Informatica',40),
	('Administração',40),
	('Contabilidade',30)

insert into disciplina
values
	('Matematica'),
	('Banco de Dados'),
	('Economia')

	
	update departamento set depto = 'Marketing'
		where codDep = 1

	update pessoa set nomePes = 'Ana'
		where codPes = 1
	update pessoa set nomePes = 'Eva'
		where codPes = 2
	update pessoa set nomePes = 'Ivo'
		where codPes = 3
	update pessoa set nomePes = 'Manoel'
		where codPes = 4

alter table curso
add foreign key (codDep) references departamento(codDep)
