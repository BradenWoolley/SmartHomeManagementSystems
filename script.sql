USE [master]
GO
/****** Object:  Database [SMSManagementSystem]    Script Date: 5/25/2020 5:33:15 PM ******/
CREATE DATABASE [SMSManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMSManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMSManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMSManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMSManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMSManagementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMSManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMSManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMSManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMSManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMSManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMSManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMSManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SMSManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMSManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMSManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMSManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMSManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMSManagementSystem] SET QUERY_STORE = OFF
GO
USE [SMSManagementSystem]
GO
/****** Object:  Table [dbo].[tblComponent]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblComponent](
	[ID] [int] IDENTITY(101,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ComponentType] [int] NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_tblComponent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerDetails]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerDetails](
	[CustomerID] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Telephone] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblCustomerDetails] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerPayment]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerPayment](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[BankingDetails] [nchar](10) NOT NULL,
	[AmountDue] [money] NOT NULL,
 CONSTRAINT [PK_tblCustomerPayment] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerProduct]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerProduct](
	[CustomerProductID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL,
 CONSTRAINT [PK_tblCustomerProduct] PRIMARY KEY CLUSTERED 
(
	[CustomerProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductCatalogue]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductCatalogue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductSuite] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblProductCatalogue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductComponents]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductComponents](
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTechSupport]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTechSupport](
	[SupportID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerProductID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Cost] [money] NOT NULL,
	[ScheduledDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblTechSupport] PRIMARY KEY CLUSTERED 
(
	[SupportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblComponent] ADD  CONSTRAINT [DF_tblComponent_Cost]  DEFAULT ((0)) FOR [Cost]
GO
ALTER TABLE [dbo].[tblCustomerDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerDetails_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerDetails] CHECK CONSTRAINT [FK_tblCustomerDetails_tblCustomer]
GO
ALTER TABLE [dbo].[tblCustomerPayment]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerPayment_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerPayment] CHECK CONSTRAINT [FK_tblCustomerPayment_tblCustomer]
GO
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblComponent] FOREIGN KEY([ComponentID])
REFERENCES [dbo].[tblComponent] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblComponent]
GO
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblCustomer1] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblCustomer1]
GO
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblCustomerProduct] FOREIGN KEY([CustomerProductID])
REFERENCES [dbo].[tblCustomerProduct] ([CustomerProductID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblCustomerProduct]
GO
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblProductCatalogue1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tblProductCatalogue] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblProductCatalogue1]
GO
ALTER TABLE [dbo].[tblProductComponents]  WITH CHECK ADD  CONSTRAINT [FK_tblProductComponents_tblComponent] FOREIGN KEY([ComponentID])
REFERENCES [dbo].[tblComponent] ([ID])
GO
ALTER TABLE [dbo].[tblProductComponents] CHECK CONSTRAINT [FK_tblProductComponents_tblComponent]
GO
ALTER TABLE [dbo].[tblProductComponents]  WITH CHECK ADD  CONSTRAINT [FK_tblProductComponents_tblProductCatalogue] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tblProductCatalogue] ([ID])
GO
ALTER TABLE [dbo].[tblProductComponents] CHECK CONSTRAINT [FK_tblProductComponents_tblProductCatalogue]
GO
ALTER TABLE [dbo].[tblTechSupport]  WITH CHECK ADD  CONSTRAINT [FK_tblTechSupport_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblTechSupport] CHECK CONSTRAINT [FK_tblTechSupport_tblCustomer]
GO
ALTER TABLE [dbo].[tblTechSupport]  WITH CHECK ADD  CONSTRAINT [FK_tblTechSupport_tblCustomerProduct] FOREIGN KEY([CustomerProductID])
REFERENCES [dbo].[tblCustomerProduct] ([CustomerProductID])
GO
ALTER TABLE [dbo].[tblTechSupport] CHECK CONSTRAINT [FK_tblTechSupport_tblCustomerProduct]
GO
/****** Object:  StoredProcedure [dbo].[DeleteComponent]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteComponent] @ID int
AS

DELETE FROM tblProductComponents
WHERE ComponentID = @ID

DELETE FROM tblComponent
WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[GetComponent]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetComponent] @ProductID int, @ComponentType int
AS
SELECT tblComponent.ID, tblComponent.Name, tblComponent.Cost
FROM tblComponent
INNER JOIN tblProductComponents
ON tblComponent.ID = tblProductComponents.ComponentID
WHERE tblProductComponents.ProductID = @ProductID AND tblComponent.ComponentType = @ComponentType;

/*EXEC GetActors @ProductID = 1;*/
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomers]
AS
SELECT tblCustomer.ID, tblCustomer.Name, tblCustomer.Surname, 
tblCustomerDetails.Email, tblCustomerDetails.Address, tblCustomerDetails.Telephone,
tblCustomerPayment.BankingDetails, tblCustomerPayment.AmountDue
FROM ((tblCustomer 
INNER JOIN tblCustomerDetails ON tblCustomer.ID = tblCustomerDetails.CustomerID)
INNER JOIN tblCustomerPayment ON tblCustomer.ID = tblCustomerPayment.CustomerID);
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomer]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewCustomer] @Name varchar(50), @Surname varchar(50)
AS
INSERT INTO tblCustomer(Name, Surname)
VALUES(@Name, @Surname);
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomerOrder]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewCustomerOrder] @CustomerID int, @ProductID int, @ComponentID int
AS
INSERT INTO tblCustomerProduct(CustomerID, ProductID, ComponentID)
VALUES(@CustomerID, @ProductID, @ComponentID);
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomerWithDetails]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewCustomerWithDetails] @name varchar(50), @surname varchar(50), @email nvarchar(50), 
@address nvarchar(50), @telephone nchar(10)
AS
INSERT INTO tblCustomer
VALUES(@name, @surname)

INSERT INTO tblCustomerDetails(CustomerID, Email, Address, Telephone)
VALUES((SELECT ID AS custID FROM tblCustomer WHERE Name = @name AND Surname = @surname), @email, @address, @telephone);
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomerWithDetailsAndBank]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewCustomerWithDetailsAndBank] @Name varchar(50), @Surname varchar(50), @Email nvarchar(50), 
@Address nvarchar(50), @Telephone nchar(10), @Banking nchar(10), @Amount money
AS
INSERT INTO tblCustomer
VALUES(@Name, @Surname)

INSERT INTO tblCustomerDetails(CustomerID, Email, Address, Telephone)
VALUES((SELECT ID AS custID FROM tblCustomer WHERE Name = @Name AND Surname = @Surname), @Email, @Address, @Telephone);

INSERT INTO tblCustomerPayment(CustomerID, BankingDetails, AmountDue)
VALUES((SELECT ID AS custID FROM tblCustomer WHERE Name = @Name AND Surname = @Surname), @Banking, @Amount);
GO
/****** Object:  StoredProcedure [dbo].[NewComponent]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewComponent] @Name varchar(50), @Type int, @Cost money, @ProductID int
AS

INSERT INTO tblComponent(Name, ComponentType, Cost)
VALUES(@Name, @Type, @Cost)

INSERT INTO tblProductComponents(ProductID, ComponentID)
VALUES(@ProductID, (SELECT tblComponent.ID FROM tblComponent
WHERE Name = @Name AND ComponentType = @Type AND Cost = @Cost)
);
GO
/****** Object:  StoredProcedure [dbo].[ScheduleSupport]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ScheduleSupport] @customerProductID int, @customerID int, @cost money, @date smalldatetime
AS
INSERT INTO tblTechSupport(CustomerProductID, CustomerID, Cost, ScheduledDate)
VALUES(@customerProductID, @customerID, @cost, @date);
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerEmail]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerEmail] @CustomerID int, @Email nvarchar(50)
AS 
UPDATE tblCustomerDetails
SET Email = @Email
WHERE CustomerID = @CustomerID;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerName]    Script Date: 5/25/2020 5:33:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerName] @CustomerID int, @Name varchar(50), @Surname varchar(50)
AS 
UPDATE tblCustomer
SET Name = @Name, Surname = @Surname
WHERE ID = @CustomerID;
GO
USE [master]
GO
ALTER DATABASE [SMSManagementSystem] SET  READ_WRITE 
GO
