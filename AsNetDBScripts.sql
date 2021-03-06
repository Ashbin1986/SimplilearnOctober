USE [Session_23_08_2021DB]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTransactions]    Script Date: 28-10-2021 17:38:15 ******/
DROP PROCEDURE [dbo].[sp_GetTransactions]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTransaction]    Script Date: 28-10-2021 17:38:15 ******/
DROP PROCEDURE [dbo].[sp_DeleteTransaction]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTrasaction]    Script Date: 28-10-2021 17:38:15 ******/
DROP PROCEDURE [dbo].[sp_AddTrasaction]
GO
ALTER TABLE [dbo].[Emo_Project_Mapping] DROP CONSTRAINT [FK_Emo_Project_Mapping_Project]
GO
ALTER TABLE [dbo].[Emo_Project_Mapping] DROP CONSTRAINT [FK_Emo_Project_Mapping_Employee]
GO
ALTER TABLE [dbo].[UserLogin] DROP CONSTRAINT [DF_UserLogin_CreatedDate]
GO
ALTER TABLE [dbo].[TransactionDetails] DROP CONSTRAINT [DF_TransactionDetails_TransactionDate]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogin]') AND type in (N'U'))
DROP TABLE [dbo].[UserLogin]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransactionDetails]') AND type in (N'U'))
DROP TABLE [dbo].[TransactionDetails]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[EmployeeDetailsBatch]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeDetailsBatch]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeDetailsBatch]
GO
/****** Object:  Table [dbo].[EmployeeBatch]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeBatch]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeBatch]
GO
/****** Object:  Table [dbo].[Employee_Det]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee_Det]') AND type in (N'U'))
DROP TABLE [dbo].[Employee_Det]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[Emo_Project_Mapping]    Script Date: 28-10-2021 17:38:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Emo_Project_Mapping]') AND type in (N'U'))
DROP TABLE [dbo].[Emo_Project_Mapping]
GO
USE [master]
GO
/****** Object:  Database [Session_23_08_2021DB]    Script Date: 28-10-2021 17:38:15 ******/
DROP DATABASE [Session_23_08_2021DB]
GO
/****** Object:  Database [Session_23_08_2021DB]    Script Date: 28-10-2021 17:38:15 ******/
CREATE DATABASE [Session_23_08_2021DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Session_23_08_2021DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Session_23_08_2021DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Session_23_08_2021DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Session_23_08_2021DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Session_23_08_2021DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Session_23_08_2021DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Session_23_08_2021DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Session_23_08_2021DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Session_23_08_2021DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Session_23_08_2021DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Session_23_08_2021DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Session_23_08_2021DB] SET  MULTI_USER 
GO
ALTER DATABASE [Session_23_08_2021DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Session_23_08_2021DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Session_23_08_2021DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Session_23_08_2021DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Session_23_08_2021DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Session_23_08_2021DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Session_23_08_2021DB', N'ON'
GO
ALTER DATABASE [Session_23_08_2021DB] SET QUERY_STORE = OFF
GO
USE [Session_23_08_2021DB]
GO
/****** Object:  Table [dbo].[Emo_Project_Mapping]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emo_Project_Mapping](
	[Emp_Project_Mapping_ID] [int] NOT NULL,
	[EmpId] [int] NULL,
	[ProjectId] [int] NULL,
 CONSTRAINT [PK_Emo_Project_Mapping] PRIMARY KEY CLUSTERED 
(
	[Emp_Project_Mapping_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] NOT NULL,
	[EmployeeName] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_Det]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Det](
	[EmployeeId] [int] NOT NULL,
	[EmployeeName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeBatch]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeBatch](
	[EmpId] [int] NULL,
	[EmpName] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetailsBatch]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetailsBatch](
	[EmpId] [int] NULL,
	[EmpName] [varchar](20) NULL,
	[Salary] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [int] NOT NULL,
	[ProjectName] [varchar](20) NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[TransactionId] [int] IDENTITY(5001,1) NOT NULL,
	[TransferToAccount] [int] NULL,
	[TransferFromAccount] [int] NULL,
	[TransferAmount] [decimal](18, 0) NULL,
	[TransactionDate] [datetime] NULL,
 CONSTRAINT [PK_TransactionDetails] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[UserId] [int] IDENTITY(1001,1) NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[Password] [nvarchar](12) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Emo_Project_Mapping] ([Emp_Project_Mapping_ID], [EmpId], [ProjectId]) VALUES (100001, 101, 2)
INSERT [dbo].[Emo_Project_Mapping] ([Emp_Project_Mapping_ID], [EmpId], [ProjectId]) VALUES (100002, 101, 3)
INSERT [dbo].[Emo_Project_Mapping] ([Emp_Project_Mapping_ID], [EmpId], [ProjectId]) VALUES (100003, 102, 1)
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName]) VALUES (101, N'Dev1')
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName]) VALUES (102, N'Dev2')
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName]) VALUES (103, N'John')
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName]) VALUES (104, N'Dev3')
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName]) VALUES (105, N'Dev3')
GO
INSERT [dbo].[Employee_Det] ([EmployeeId], [EmployeeName]) VALUES (105, N'Dev3')
INSERT [dbo].[Employee_Det] ([EmployeeId], [EmployeeName]) VALUES (111, N'Test2')
GO
INSERT [dbo].[EmployeeBatch] ([EmpId], [EmpName]) VALUES (101, N'A')
INSERT [dbo].[EmployeeBatch] ([EmpId], [EmpName]) VALUES (102, N'B')
GO
INSERT [dbo].[EmployeeDetailsBatch] ([EmpId], [EmpName], [Salary]) VALUES (1001, N'X', NULL)
INSERT [dbo].[EmployeeDetailsBatch] ([EmpId], [EmpName], [Salary]) VALUES (1002, N'Y', NULL)
INSERT [dbo].[EmployeeDetailsBatch] ([EmpId], [EmpName], [Salary]) VALUES (101, N'A', NULL)
GO
INSERT [dbo].[Project] ([ProjectId], [ProjectName]) VALUES (1, N'Travel')
INSERT [dbo].[Project] ([ProjectId], [ProjectName]) VALUES (2, N'Insurance')
INSERT [dbo].[Project] ([ProjectId], [ProjectName]) VALUES (3, N'Hospitality')
GO
SET IDENTITY_INSERT [dbo].[TransactionDetails] ON 

INSERT [dbo].[TransactionDetails] ([TransactionId], [TransferToAccount], [TransferFromAccount], [TransferAmount], [TransactionDate]) VALUES (5001, 457845965, 24578451, CAST(10000 AS Decimal(18, 0)), CAST(N'2021-10-28T16:39:15.863' AS DateTime))
INSERT [dbo].[TransactionDetails] ([TransactionId], [TransferToAccount], [TransferFromAccount], [TransferAmount], [TransactionDate]) VALUES (5002, 554564564, 3453266, CAST(5000 AS Decimal(18, 0)), CAST(N'2021-10-28T16:39:25.047' AS DateTime))
INSERT [dbo].[TransactionDetails] ([TransactionId], [TransferToAccount], [TransferFromAccount], [TransferAmount], [TransactionDate]) VALUES (5004, 457845965, 54579589, CAST(5000 AS Decimal(18, 0)), CAST(N'2021-10-28T16:39:25.047' AS DateTime))
INSERT [dbo].[TransactionDetails] ([TransactionId], [TransferToAccount], [TransferFromAccount], [TransferAmount], [TransactionDate]) VALUES (5006, 278637, 97852, CAST(97853 AS Decimal(18, 0)), CAST(N'2021-10-28T17:29:19.297' AS DateTime))
SET IDENTITY_INSERT [dbo].[TransactionDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [CreatedDate]) VALUES (1001, N'admin', N'123456', CAST(N'2021-10-28T15:45:31.500' AS DateTime))
INSERT [dbo].[UserLogin] ([UserId], [UserName], [Password], [CreatedDate]) VALUES (1002, N'guest', N'123456', CAST(N'2021-10-28T15:45:52.067' AS DateTime))
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
GO
ALTER TABLE [dbo].[TransactionDetails] ADD  CONSTRAINT [DF_TransactionDetails_TransactionDate]  DEFAULT (getdate()) FOR [TransactionDate]
GO
ALTER TABLE [dbo].[UserLogin] ADD  CONSTRAINT [DF_UserLogin_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Emo_Project_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_Emo_Project_Mapping_Employee] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Emo_Project_Mapping] CHECK CONSTRAINT [FK_Emo_Project_Mapping_Employee]
GO
ALTER TABLE [dbo].[Emo_Project_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_Emo_Project_Mapping_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Emo_Project_Mapping] CHECK CONSTRAINT [FK_Emo_Project_Mapping_Project]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTrasaction]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Created Date : 2021-10-28
-- Created By  : Simplilearn
-- Purpose : Add transaction
Create Procedure [dbo].[sp_AddTrasaction]
@transferToAccount int ,
@transferFromAccount int,
@transferAmount decimal(18,2)
AS
Insert into TransactionDetails (TransferToAccount ,TransferFromAccount , TransferAmount )
values (@transferToAccount ,@transferFromAccount , @transferAmount)
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTransaction]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_DeleteTransaction]
@transactionId int
AS
Delete from [dbo].[TransactionDetails] where [TransactionId] = @transactionId


GO
/****** Object:  StoredProcedure [dbo].[sp_GetTransactions]    Script Date: 28-10-2021 17:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[sp_GetTransactions]
AS
Select * from [dbo].[TransactionDetails]


GO
USE [master]
GO
ALTER DATABASE [Session_23_08_2021DB] SET  READ_WRITE 
GO
