Create database PRN211_Project;
use PRN211_Project ;

create table [Role] (
 role_id int PRIMARY KEY identity(1,1) not null,
 role_name varchar(55) not null

)
create table Account (
 username varchar(50) primary key not null ,
 [password] varchar(50) not null ,
 role_id int not null ,
 FOREIGN KEY (role_id) REFERENCES [Role](role_id)


)
go
CREATE TABLE Books (
    Id INT PRIMARY KEY identity(1,1) not null ,
	bName NVARCHAR(100) NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    NSX DATE NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
	price_buying DECIMAL(10,2) NOT NULL,
	CategoryId int not null
	FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
	
   
);
go
CREATE TABLE Categories (
    CategoryId INT identity(1,1) PRIMARY KEY NOT NULL,
    Name NVARCHAR(50) NOT NULL
);
go

CREATE TABLE Customers (
    CustomerId INT identity(1,1) PRIMARY KEY NOT NULL ,
    [Name] NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL
	FOREIGN KEY (username) REFERENCES Account(username)
);
go

CREATE TABLE Orders (
    OrderId INT identity(1,1) PRIMARY KEY NOT NULL,
    CustomerId INT,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);
CREATE TABLE OrderDetails (
    OrderId INT,
    BookId INT,
    Quantity INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (BookId) REFERENCES Books(Id),
    PRIMARY KEY (OrderId, BookId)
);



-- Thêm bảng Nhà xuất bản (Publishers)
CREATE TABLE Publishers (
    PublisherId INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
    PublisherName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL
);
CREATE TABLE PublisherSales (
    SaleId INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
    PublisherId INT NOT NULL,
    BookId INT NOT NULL,
    Quantity INT NOT NULL,
    SaleDate DATE NOT NULL,
    FOREIGN KEY (PublisherId) REFERENCES Publishers(PublisherId), -- Liên kết với bảng Publishers
    FOREIGN KEY (BookId) REFERENCES Books(Id) -- Liên kết với bảng Books
);


ALTER TABLE Orders
ALTER COLUMN OrderId INT IDENTITY  NOT NULL;


ALTER TABLE Books
ADD price_buying DECIMAL

ALTER TABLE Account
ADD CONSTRAINT FK_ID
FOREIGN KEY (role_id)
REFERENCES Role(role_id);