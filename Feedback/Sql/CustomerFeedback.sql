create or alter procedure insertFeedback (@Customername nvarchar(200),@Comments nvarchar(100),@Productname nvarchar(100),@Rating int,@Createddate datetime)
as
begin
 insert into Feedback(Customername,Comments,Productname,Rating,Createddate)values(@Customername,@Comments,@Productname,@Rating,@Createddate)
end
exec insertFeedback  'vidhya','super','apple',5,'05-23-2023'



create procedure selectFeedback
  as
begin

  Select * from Feedback
  end

exec selectFeedback



