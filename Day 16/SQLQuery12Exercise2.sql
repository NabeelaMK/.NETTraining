
--Q1--
--Table1--

CREATE TABLE CLIENT_MASTER(
CLIENTNO VARCHAR(6) PRIMARY KEY CHECK(CLIENTNO LIKE 'C%'),
NAME VARCHAR(20) NOT NULL,
ADDRESS1 VARCHAR(30), 
ADDRESS2 VARCHAR(30), 
CITY VARCHAR(15), 
PINCODE NUMERIC(8), 
STATE VARCHAR(15), 
BALDUE NUMERIC(10,2)
);
SELECT * FROM CLIENT_MASTER

--Value Insertion--

INSERT INTO CLIENT_MASTER VALUES
('C00001', 'Ivan Bayross', 'ABC House','Gandhi Street','Mumbai', 400054, 'Maharashtra', 15000),
('C00002','Nobita Nob','Dora House','Xiong Street','Wuhan',506767,'Beiging',20000),
('C00003','Phineas Ferb','Candice House','White Field Street','London City',686503,'London',12000.00),
('C00004','Dennis','Chucky House','Chung Street','Manhattan',124356,'New York',40000.00),
('C00005','Aleena Joji','Kulathoor','Kurissummodu','Changassery',675834,'Kerala',5000.00);

--Table2--

CREATE TABLE PRODUCT_MASTER(
PRODUCTNO VARCHAR(6) PRIMARY KEY CHECK (PRODUCTNO LIKE '%P'), 
DESCRIPTION VARCHAR(15) NOT NULL, 
PROFITPERC NUMERIC(4,2) NOT NULL, 
UNITMEASURE VARCHAR(10) NOT NULL, 
QTYONHAND NUMERIC(8) NOT NULL, 
REORDERLVL NUMERIC(8) NOT NULL, 
SELLPRICE NUMERIC(8,2) NOT NULL CHECK (SELLPRICE <> 0),
COSTPRICE NUMERIC(8,2) NOT NULL CHECK (COSTPRICE <> 0));SELECT * FROM PRODUCT_MASTER

--Value Insertion--

INSERT INTO PRODUCT_MASTER VALUES
('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250),
('P00002','Jeans',3,'Piece',100,55,3500,4000),
('P00003','Lahanga',6,'Piece',110,30,800,850),
('P00004','1.44 drive',4,'Piece',55,36,1000,950);--Table3--CREATE TABLE SALESMAN_MASTER(
SALESMANNO VARCHAR(6) PRIMARY KEY CHECK (SALESMANNO LIKE'%S'),
SALESMANNAME VARCHAR(20) NOT NULL, 
ADDRESS1 VARCHAR(30) NOT NULL, 
ADDRESS2 VARCHAR(30), 
CITY VARCHAR(20), 
PINCODE NUMERIC(8), 
State VARCHAR(20), 
SALAMT NUMERIC(8,2) NOT NULL CHECK (SALAMT <> 0), 
TGTTOGET NUMERIC(6,2) NOT NULL, 
YTDSALES NUMERIC(6,2) NOT NULL, 
REMARKS VARCHAR(60));SELECT * FROM SALESMAN_MASTER --Value Insertion--INSERT INTO SALESMAN_MASTER VALUES
('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good'),
('S00002', 'Neerav', 'B/16', 'Alandur', 'Chennai', 509997, 'tamilnadu', 3500, 50, 55, 'Average'),
('S00003', 'Daksha', 'A/09', 'Pampady', 'Kottayam', 686589, 'Kerala', 1000, 200, 80, 'Excellent');--Table4--CREATE TABLE SALES_ORDER(ORDERNO VARCHAR(6) PRIMARY KEY CHECK (ORDERNO LIKE '%O'),
CLIENTNO VARCHAR(6) CONSTRAINT FK_SALES_ORDER_CLIENT REFERENCES CLIENT_MASTER (CLIENTNO), 
ORDERDATE DATE,
DELYADDR VARCHAR(25), 
SALESMANNO VARCHAR(6) CONSTRAINT FK_SALES_ORDER_SALESMAN REFERENCES SALESMAN_MASTER (SALESMANNO), 
DELYTYPE CHAR(1) CHECK (DELYTYPE IN ('P', 'F')),
BILLEDYN CHAR(1) CHECK (BILLEDYN IN ('Y', 'N')), 
DELYDATE DATE, 
ORDERSTATUS VARCHAR(10) CHECK (ORDERSTATUS IN ('In Process', 'Fulfilled', 'Backorder', 'Cancelled')));SELECT * FROM SALES_ORDER--Value Insertion--INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)
VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'In Process');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)
VALUES('O19002', '23-april-18', 'C00002', 'P', 'N', 'S00003', '22-december-23', 'Cancelled');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)
VALUES('O19003', '12-july-03', 'C00001', 'P', 'Y', 'S00002', '20-july-18', 'Backorder');--Table5--CREATE TABLE SALES_ORDER_DETAILS (
ORDERNO VARCHAR(6),
PRODUCTNO VARCHAR(6),
QTYORDERED NUMERIC(8),
QTYDISP NUMERIC(8),
PRODUCTRATE NUMERIC(10,2),
CONSTRAINT PK_SALES_ORDER_DETAILS PRIMARY KEY (ORDERNO, PRODUCTNO),
CONSTRAINT FK_SALES_ORDER FOREIGN KEY (ORDERNO) REFERENCES SALES_ORDER(ORDERNO),
CONSTRAINT FK_PRODUCT_MASTER FOREIGN KEY (PRODUCTNO) REFERENCES PRODUCT_MASTER(PRODUCTNO)
);
SELECT * FROM SALES_ORDER_DETAILS;--Value Insertion--INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19002', 'P00003', 3, 5, 300);
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19003', 'P00002', 6, 9, 773);--Q2--/*1. Display the names of all the clients.*/
select name from CLIENT_MASTER;

--2. Display all the clients who are located in Mumbai.
select name from CLIENT_MASTER where city='Mumbai';

--3. Display all the products whose selling price is > 2000 and < 5000.
select description from PRODUCT_MASTER where SELLPRICE between 2000 and 5000;

--4. Display Name, City and State of Clients not in the state of Maharashtra.
select name,city,state from CLIENT_MASTER where state not in('Maharashtra');

--5. Display all the information of client_no C0001 and C0002.
select * from CLIENT_MASTER where CLIENTNO in('C00001','C00002');

--6. Change the selling price of '1.44 drive' to Rs. 1150.50.
update PRODUCT_MASTER set SELLPRICE=1150.50 where DESCRIPTION='1.44 drive';

--7. Delete the record of client_no C0005.
delete from CLIENT_MASTER where CLIENTNO='C00005';

--8. Display the clients who stay in a city whose second letter is 'a'.
INSERT INTO CLIENT_MASTER VALUES
('C00005', 'James Bond', 'Blue House','Cat Street','Manali', 90254, 'HP', 16700);
SELECT NAME FROM CLIENT_MASTER WHERE CITY LIKE '_a%'

--9. Count the number of products having price greater than or equal to 1500.
SELECT COUNT(PRODUCTNO) FROM PRODUCT_MASTER WHERE SELLPRICE=1500;

--10. Display qtyordered, qtydisp and balancedqty (not in table).




