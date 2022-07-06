-- create database Catalogo;

create table Filme (
	id int primary key identity(1,1),
	nome varchar(60) not null,
	data_lancamento int not null,
	duracao int not null
);

create table Ator(
	id int primary key identity(1,1),
	nome varchar(60) not null,
	sobrename varchar(60) not null
);

insert into Filme (nome, data_lancamento, duracao) values ('Thor: amor e trovao',2022,120),('O Homem do Norte',2022,137),('O Homem nas Trevas',2016,88);

insert into Ator (nome, sobrename) values
('Stephen','Lang'),
('Jane ','Levy'),
('Dylan','Minnette'),
('Daniel ','Zavatto'),
('Natalie ','Portman'),
('Christian','Bale'),
('Chris','Hemsworth'),
('Matt','Damon'),
('Russel','Crowe'),
('Anya','Taylor-Joy'),
('Alexander','Skarsgard'),
('Willian','Defoe'),
('Nicole','Kidman');

create table Filme_Ator(
	id int primary key identity(1,1),
	idFilme int not null,
	idAtor int not null,

	constraint FK_FILME_ID foreign key (idFilme) references Filme(id),
	constraint FK_ATOR_ID foreign key (idAtor) references Ator(id)
);

select * from Filme order by nome;
select * from Filme order by data_lancamento desc;
select nome,sobrename from Ator order by nome,sobrename;

