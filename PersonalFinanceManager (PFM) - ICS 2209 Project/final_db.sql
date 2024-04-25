CREATE DATABASE PFM;
USE PFM;

CREATE TABLE User (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    OfficialName VARCHAR(255),
    Username VARCHAR(50) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    Password VARCHAR(255)
);

CREATE TABLE Account (
	AccountID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT,
    Username VARCHAR(50),
    AccountBalance DECIMAL(10, 2) DEFAULT 0.00,
    DateCreated DATE,
    FOREIGN KEY (UserID) REFERENCES User(UserID)
);

CREATE TABLE Loans (
    LoanID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    LoanerName VARCHAR(255),
    LoanAmount DECIMAL(10, 2) DEFAULT 0.00,
    InterestRate DECIMAL(5, 2),
    DateTaken DATE,
    PaymentDeadline DATE,
    AmountReturned DECIMAL(10, 2) DEFAULT 0.00,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

CREATE TABLE Debts (
    DebtID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    DebtorName VARCHAR(255),
    DebtAmount DECIMAL(10, 2) DEFAULT 0.00,
    DateDebtTaken DATE,
    DebtPaymentDeadline DATE,
    AmountRefunded DECIMAL(10, 2) DEFAULT 0.00,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

CREATE TABLE Income (
    IncomeID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    SourceName VARCHAR(255),
    Amount DECIMAL(10, 2) DEFAULT 0.00,
    DateReceived DATE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

CREATE TABLE Expenses (
    ExpenseID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    ExpenseType VARCHAR(255),
    Amount DECIMAL(10, 2) DEFAULT 0.00,
    DateSpent DATE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);

CREATE TABLE Transaction (
    TransactionID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    TransactionType VARCHAR(50),
    Amount DECIMAL(10, 2) DEFAULT 0.00,
    Origin VARCHAR(255),
    Destination VARCHAR(255),
    TransactionDate DATE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);


CREATE TABLE Goals (
    GoalID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT,
    StartingDate DATE,
    TargetDate DATE,
    StartingAmount DECIMAL(10, 2) DEFAULT 0.00,
    TargetAmount DECIMAL(10, 2) DEFAULT 0.00,
    CurrentAmount DECIMAL(10, 2) DEFAULT 0.00,
    Description VARCHAR(255) UNIQUE,
    FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);