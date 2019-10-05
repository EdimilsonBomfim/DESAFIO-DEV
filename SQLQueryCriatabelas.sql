
CREATE DATABASE DESAFIOBUREAU

USE DESAFIOBUREAU
go

DROP TABLE PRODUTOS

CREATE TABLE PRODUTOS( 
       Id int IDENTITY(1,1) PRIMARY KEY,
	   Nome varchar(30),
	   Descricao varchar(100),
	   Valor decimal(15,2)
)


USE DESAFIOBUREAU
go
select * from PRODUTOS

insert into PRODUTOS( Nome,Descricao,Valor ) values ( 'Cotovelo de 45','Cotovelo de 45 graus',  12.50)
insert into PRODUTOS( Nome,Descricao,Valor ) values ( 'Tubo soldado','Tubo SWoldado com flage de 45 graus',  123.00)
insert into PRODUTOS( Nome,Descricao,Valor ) values ( 'Flange de inox','Flange de Inox para acoplamento no teto',  340.35)
insert into PRODUTOS( Nome,Descricao,Valor ) values ( 'Arruela de 1/2','Arruela de 1/2 ',  0.98)
insert into PRODUTOS( Nome,Descricao,Valor ) values ( 'Porca de ajuste','Porca de Ajuste de reducao ',  0.38)

select * from produtos