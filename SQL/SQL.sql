Create table SuperMarketShope
(
 ShopId int not null  Identity (1,1), 
 Name nvarchar (100)  not null, 
 OwnerName nvarchar (100) not null,
 NumberOfProduct int not null,
 ContactNumber bigint not null,
 Emailid nvarchar (100) not null,
 Location nvarchar (100) not null
)

select *from SuperMarketShope
alter Procedure SuperMarket
(
 
 @name nvarchar(100),
 @OwnerName nvarchar (100),
 @NumberOfProduct int,
 @ContactNumber  bigint,
 @Emailid nvarchar (100),
 @Location nvarchar (100)
 )
as
begin
I nsert into [dbo].[SuperMarketShope]
 ([name],[OwnerName],[NumberOfProduct],[ContactNumber],[Emailid],[Location])
values(

   @name,
   @OwnerName,
   @NumberOfProduct,
   @ContactNumber,
   @Emailid,
   @Location
)
 Select * from SuperMarketShope
end

 exec SuperMarket 'SivaSuperMarket','Siva',300,756766878,'Siva@gmail.com','Dharapuram'

Create Procedure UpdateSuperMarket
(
 @name nvarchar(100),
 @Location nvarchar (100)

 )
as
begin
update SuperMarketShope

set
  Location= @Location
where
  Name= @name


 select*from SuperMarketShope
end
exec UpdateSuperMarket 'sivasupermarket','cbe'



Create procedure DeleteSuperMarket
(
    @ShopId int
)
as
begin
Delete from SuperMarketShope
where
ShopId=@ShopId
select*from SuperMarketShope

end


exec DeleteSuperMarket

Alter procedure Showall
as
begin
Select *from SuperMarketShope
end
exec Showall