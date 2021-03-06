USE [master]
GO
/****** Object:  Database [SMSManagementSystem]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblCallLogs]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCallLogs](
	[CallID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CallStarted] [smalldatetime] NOT NULL,
	[CallEnded] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblCallLogs] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblComponent]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblCustomerDetails]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblCustomerPayment]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblCustomerProduct]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerProduct](
	[CustomerProductID] [varchar](50) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL,
 CONSTRAINT [PK_tblCustomerProduct] PRIMARY KEY CLUSTERED 
(
	[CustomerProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJob]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJob](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
 CONSTRAINT [PK_tblJob] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJobDescription]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJobDescription](
	[JobID] [int] NOT NULL,
	[JobDescription] [nvarchar](50) NULL,
	[JobStatus] [int] NOT NULL,
	[Cost] [money] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_tblJobDescription] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductCatalogue]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  Table [dbo].[tblProductComponents]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductComponents](
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTechnicians]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTechnicians](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblTechnicians] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTechSupport]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTechSupport](
	[SupportID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerProductID] [varchar](50) NOT NULL,
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
ALTER TABLE [dbo].[tblCallLogs]  WITH CHECK ADD  CONSTRAINT [FK_tblCallLogs_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblCallLogs] CHECK CONSTRAINT [FK_tblCallLogs_tblCustomer]
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
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblCustomerProduct1] FOREIGN KEY([CustomerProductID])
REFERENCES [dbo].[tblCustomerProduct] ([CustomerProductID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblCustomerProduct1]
GO
ALTER TABLE [dbo].[tblCustomerProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomerProduct_tblProductCatalogue1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tblProductCatalogue] ([ID])
GO
ALTER TABLE [dbo].[tblCustomerProduct] CHECK CONSTRAINT [FK_tblCustomerProduct_tblProductCatalogue1]
GO
ALTER TABLE [dbo].[tblJob]  WITH CHECK ADD  CONSTRAINT [FK_tblJob_tblJob] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([ID])
GO
ALTER TABLE [dbo].[tblJob] CHECK CONSTRAINT [FK_tblJob_tblJob]
GO
ALTER TABLE [dbo].[tblJob]  WITH CHECK ADD  CONSTRAINT [FK_tblJob_tblTechnicians] FOREIGN KEY([EmpID])
REFERENCES [dbo].[tblTechnicians] ([EmpID])
GO
ALTER TABLE [dbo].[tblJob] CHECK CONSTRAINT [FK_tblJob_tblTechnicians]
GO
ALTER TABLE [dbo].[tblJobDescription]  WITH CHECK ADD  CONSTRAINT [FK_tblJobDescription_tblJob1] FOREIGN KEY([JobID])
REFERENCES [dbo].[tblJob] ([ID])
GO
ALTER TABLE [dbo].[tblJobDescription] CHECK CONSTRAINT [FK_tblJobDescription_tblJob1]
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
/****** Object:  StoredProcedure [dbo].[DeletCustomer]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeletCustomer] @ID int
as

DELETE FROM tblCustomerProduct
WHERE tblCustomerProduct.CustomerID = @ID;

DELETE FROM tblCallLogs
WHERE tblCallLogs.CustomerID = @ID;

DELETE FROM tblCustomerPayment
WHERE tblCustomerPayment.CustomerID = @ID;

DELETE FROM tblCustomerDetails
WHERE tblCustomerDetails.CustomerID = @ID;

DELETE FROM tblCustomer
WHERE tblCustomer.ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer] @ID int
as
DELETE FROM tblCustomerProduct
WHERE tblCustomerProduct.CustomerID = @ID

DELETE FROM tblCustomerPayment
WHERE tblCustomerPayment.CustomerID = @ID

DELETE FROM tblCustomerDetails
WHERE tblCustomerDetails.CustomerID = @ID

DELETE FROM tblCustomer
WHERE tblCustomer.ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupport]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSupport] @ID int
AS
DELETE FROM tblJobDescription
WHERE JobID = @ID;

DELETE FROM tblJob
WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[GetComponent]    Script Date: 7/13/2020 3:28:27 AM ******/
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
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerComponents]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerComponents] @CustomerID int, @ComponentType int
AS
SELECT tblComponent.ID, tblComponent.Name, tblComponent.Cost, tblComponent.ComponentType
FROM tblComponent
INNER JOIN tblCustomerProduct ON tblComponent.ID = tblCustomerProduct.ComponentID
INNER JOIN tblCustomer ON tblCustomerProduct.CustomerID = tblCustomer.ID
WHERE tblCustomer.ID = @CustomerID AND tblComponent.ComponentType = @ComponentType;
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerProducts]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerProducts] @CustomerID int
AS
SELECT DISTINCT tblProductCatalogue.ID, tblProductCatalogue.ProductSuite
FROM tblProductCatalogue
INNER JOIN tblCustomerProduct ON tblProductCatalogue.ID = tblCustomerProduct.ProductID
WHERE tblCustomerProduct.CustomerID = @CustomerID
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetJobs]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetJobs]
AS
SELECT tblJob.ID, tblJobDescription.JobDescription, tblJob.EmpID ,tblJobDescription.JobStatus, tblJob.CustomerID,
tblJobDescription.Cost, tblJobDescription.Date
FROM (((tblJob
INNER JOIN tblJobDescription ON tblJob.ID = tblJobDescription.JobID)
INNER JOIN tblTechnicians ON tblJob.EmpID = tblTechnicians.EmpID)
INNER JOIN tblCustomer ON tblJob.CustomerID = tblCustomer.ID);
GO
/****** Object:  StoredProcedure [dbo].[GetTechJobs]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTechJobs] @EmpID int
AS
SELECT tblJob.ID, tblJobDescription.JobDescription, tblJobDescription.JobStatus
FROM tblJob
INNER JOIN tblJobDescription ON tblJob.ID = tblJobDescription.JobID
WHERE tblJob.EmpID = @EmpID;
GO
/****** Object:  StoredProcedure [dbo].[GetTechnicians]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTechnicians]
AS
SELECT * 
FROM tblTechnicians;
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCustomer]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertNewCustomer] @Name varchar(50), @Surname varchar(50), @Email nvarchar(50),
@Address nvarchar(50), @Telephone nchar(10), @Banking nchar(10), @Amount money
AS
INSERT INTO tblCustomer(Name, Surname)
VALUES (@Name, @Surname);

INSERT INTO tblCustomerDetails(CustomerID, Email, Address, Telephone)
VALUES ((SELECT tblCustomer.ID FROM tblCustomer WHERE Name = @Name AND Surname = @Surname),
@Email, @Address, @Telephone);

INSERT INTO tblCustomerPayment(CustomerID, BankingDetails, AmountDue)
VALUES ((SELECT tblCustomer.ID FROM tblCustomer WHERE Name = @Name AND Surname = @Surname),
@Banking, @Amount);
GO
/****** Object:  StoredProcedure [dbo].[LogCalls]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LogCalls] @CustomerID int, @CallInitiated smalldatetime, @CallEnded smalldatetime
as
INSERT INTO tblCallLogs
VALUES(@CustomerID, @CallInitiated, @CallEnded);
GO
/****** Object:  StoredProcedure [dbo].[NewComponent]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  StoredProcedure [dbo].[NewCustomerProduct]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewCustomerProduct] @Serial varchar(50), @CustomerID int, @ProductID int,
@ComponentID int
AS

INSERT INTO tblCustomerProduct
VALUES(@Serial, @CustomerID, @ProductID, @ComponentID);
GO
/****** Object:  StoredProcedure [dbo].[NewSupport]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSupport] @EmpID int, @Description nvarchar(50), 
@CustomerID int, @Status int, @Date datetime, @Cost money
AS

INSERT INTO tblJob
VALUES (@EmpID, @CustomerID);

INSERT INTO tblJobDescription
VALUES ((SELECT tblJob.ID FROM tblJob WHERE tblJob.ID=(SELECT max(tblJob.ID) FROM tblJob)) 
,@Description, @Status, @Cost, @Date);

GO
/****** Object:  StoredProcedure [dbo].[UpdateComponent]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateComponent] @ID int, @Name varchar(50), @Type int, @Cost money, @ProductID int
AS
UPDATE tblProductComponents 
SET ProductID = @ProductID
WHERE ComponentID = @ID

UPDATE tblComponent
SET Name = @Name, ComponentType = @Type, Cost = @Cost
WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer] @ID int, @Name varchar(50), @Surname varchar(50),
@Email nvarchar(50), @Address nvarchar(50), @Phone nchar(10), @Banking nchar(10)
AS

UPDATE tblCustomer
SET Name = @Name, Surname = @Surname
WHERE ID = @ID;

UPDATE tblCustomerDetails
SET Email = @Email, Address = @Address, Telephone = @Phone
WHERE CustomerID = @ID;

UPDATE tblCustomerPayment
SET BankingDetails = @Banking
WHERE CustomerID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerEmail]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateCustomerName]    Script Date: 7/13/2020 3:28:27 AM ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateSupport]    Script Date: 7/13/2020 3:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSupport] @JobID int, @EmpID int, @Description nvarchar(50), 
@CustomerID int, @Status int, @Date datetime, @Cost money
AS


UPDATE tblJob
SET EmpID = @EmpID
WHERE ID = @JobID;

Update tblJobDescription
SET JobDescription = @Description, JobStatus = @Status, Date = @Date, Cost = @Cost
WHERE JobID = @JobID;
GO
USE [master]
GO
ALTER DATABASE [SMSManagementSystem] SET  READ_WRITE 
GO
