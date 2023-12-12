drop database dbPdv

create database dbPdv
use dbPdv


create table Cliente -- 1
(
	Id int auto_increment primary key,
	Nome varchar(100) not null,
	Logradouro varchar(100),
	Bairro varchar(100),
	Cidade varchar(100),
	NumeroCasa varchar(10),
	Email varchar(100),
	Contato varchar(15) not null,
	Cpf varchar(15),
    
    UNIQUE KEY Contato (Contato)
)

create table Fornecedor -- 2
(
	Id int auto_increment primary key,
	Nome varchar(100) not null,
	Logradouro varchar(100),
	Bairro varchar(100),
	Cidade varchar(100),
	Numero varchar(10) not null,
	Email varchar(100),
	Contato varchar(15) not null,
	Cnpj varchar(20) not null,
    
    UNIQUE KEY Contato (Contato),
    UNIQUE KEY Cnpj (Cnpj)    
)

create table Categoria -- 3
(
	Id int auto_increment primary key,
    Nome varchar(50),
    descricao varchar(300)
)

create table Produto -- 4
(
	Id int auto_increment primary key,
    IdCategoria int,
	NomeProduto varchar(50),
	ValorUnitario decimal(7,2),
    
    UNIQUE KEY NomeProduto (NomeProduto),
    FOREIGN KEY (IdCategoria) REFERENCES Categoria(Id)
)

create table Pedido -- 5
(
	Id int auto_increment primary key,
    NomeCliente varchar(100),
	EntregaRetirada varchar(50),
    Endereco varchar(100),
    Contato varchar(50),
	TotalVenda decimal(7,2),
	DataVenda date    
) 

create table ItemCompra -- 6
(
	Id int auto_increment primary key,
	IdProduto int not null,
	IdFornecedor int not null,
	Quantidade float,
	ValorUnitario float,
	DataCompra date,
    
    FOREIGN KEY (IdProduto) REFERENCES Produto(Id),
    FOREIGN KEY (IdFornecedor) REFERENCES Fornecedor(Id)
)

create table FormaPagamentoPedido -- 7
(
	Id int auto_increment primary key,
    IdPedido int ,
    Pix decimal(7,2),
	Dinheiro decimal(7,2),
    Debito decimal(7,2),
    credito decimal(7,2)
)


create table ItemPedido -- 8
(
	Id int auto_increment primary key,
	IdProduto int,
	IdPedido int ,
	quantidade decimal(7,2),
	SubTotal decimal(7,2),
    DataVenda date,
    
    FOREIGN KEY (IdProduto) REFERENCES Produto(Id)
)

create table Fluxo -- 9
(
	Id int auto_increment primary key,
	SaldoInicial decimal(7,2),
	SaldoFinal decimal(7,2),
    DataOpen date,
    DataClose date
)


