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
select Book_code,Title,PRICE,PUBLISHER_NAME from BOOK inner join PUBLISHER on PUBLISHER.PUBLISHER_NAME=PUBLISHER.PUBLISHER_NAME  where PUBLISHER_NAME='PLUME' AND PRICE>=14
select BOOK.Book_code,Book.TITLE,INVENTORY.ON_HAND from BOOK inner join INVENTORY on BOOK.BOOK_CODE=INVENTORY.BOOK_CODE where BRANCH_NUM=4 
select BooK.TITLE from Book inner join PUBLISHER on Book.PUBLISHER_CODE=PUBLISHER.PUBLISHER_CODE where TYPE='PSY' and PUBLISHER_NAME='JOVE PUBLICATIONS'
select Book.TITLE from BOOK where BOOK_CODE in (select BOOK_CODE from Wrote where AUTHOR_NUM =18)
select Book.TITLE from BOOK where EXISTS (select BOOK_CODE from Wrote where BOOK.BOOK_CODE = WROTE.BOOK_CODE and AUTHOR_NUM=18 ) 
select Book.BOOK_CODE,BOOK.TITLE from Book join WROTE on BOOK.BOOK_CODE=WROTE.BOOK_CODE join INVENTORY on WROTE.BOOK_CODE =INVENTORY.BOOK_CODE where Inventory.BRANCH_NUM=2 and WROTE.AUTHOR_NUM=20
select Book.TITLE,AUTHOR.AUTHOR_FIRST,INVENTORY.ON_HAND from Book full join WROTE on Book.BOOK_CODE =Wrote.BOOK_CODE full join AUTHOR on Wrote.AUTHOR_NUM=Author.AUTHOR_NUM full join INVENTORY on Wrote.BOOK_CODE=Inventory.BOOK_CODE where BRANCH_NUM=4 and PAPERBACK='y'
select Book.BOOK_CODE,PRICE from BOOk where book.PRICE=PRICE order by BOOK.PRICE, BOOK.Book_CODE
select Book.BOOK_CODE,Book.TITLE,publisher.CITY from BOOK JOin PUBLISHER on Book.PUBLISHER_CODE=PUBLISHER.PUBLISHER_CODE  where BOOK.PRICE>=10 and CITY!='BOSTON'


