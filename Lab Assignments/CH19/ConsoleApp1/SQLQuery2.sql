select Book_code,title from BOOK
select * from PUBLISHER
select PUBLISHER_NAME ,city from PUBLISHER where city ='boston' order by PUBLISHER_NAME
select PUBLISHER_NAME,city from PUBLISHER where city !='boston' order by PUBLISHER_NAME
select BRANCH_NAME,NUM_EMPLOYEES from BRANCH where NUM_EMPLOYEES>=9
select Book_CODE,Title from BOOK where Type = 'SFI'

select Book_code,title from BOOK  where TYPE='SFI' or PUBLISHER_CODE ='SC'
select book_code,Title,price from book where PRICE >=20 or PRICE=30
select book_code,Title,price from book where TYPE = 'MYS' and Price<=20
INSERT INTO BOOK.PRICE (Discounted_Price,book_Code,Title )[FIrst Value (Book.Price-Book.Price*.10) As[discounte_Price] (Values('59.50',"Book_Code","Title")
select PUBLISHER_NAME from PUBLISHER
insert into BOOK.PRICE (Discounted_Price,BOOK_Code,TItle)Values("book.PRICE*.90",BOOK_CODE,TITLE)
select * from PUBLISHER where PUBLISHER_NAME like '_and%';
select Book_code,Title from BOOK  where TYPE ='SFI' or TYPE='MYS' or TYPE='ART' order by Title
select Book_code,Title,PRICE from BOOK  where TYPE ='SFI' or TYPE='MYS' or TYPE='ART' order by PRICE desc,TITLE asc; 
select BOOK.TYPE from BOOK
select SUM(1) from BOOK where TYPE='SFI'
select BOOK.type ,AVG(Book.PRICE)as [mini]  from BOOK group By TYPE 
select max(price) from BOOK
select min(price) [MINI] from BOOK
select sum(10)  as [Num_EMP] from BRANCH
select Book_code,Title,BOOK.PUBLISHER_CODE from BOOK  full outer join PUBLISHER on PUBLISHER.PUBLISHER_CODE=PUBLISHER.PUBLISHER_NAME
select BOOK.type ,AVG(Book.PRICE)as [mini]  from BOOK where PAPERBACK='y' group By TYPE 
select BOOK.type ,AVG(Book.PRICE)as [mini]  from BOOK where PAPERBACK='y' group By TYPE having AVG(BOOK.Price)>10

select BOOK.BOOK_CODE,BOOK.TITLE,Book.PRICE+(Book.PRICE*.1) AS Discounted_Price from book
select Book_code,Title,PRICE from BOOK  join PUBLISHER on BOOK.PUBLISHER_CODE=PUBLISHER.PUBLISHER_CODE
select Book_code,Title,BOOK.PUBLISHER_CODE,PUBLISHER_NAME from BOOK  full outer join PUBLISHER on PUBLISHER.PUBLISHER_CODE=PUBLISHER.PUBLISHER_NAME