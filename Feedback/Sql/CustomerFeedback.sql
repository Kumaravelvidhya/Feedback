--insert sp
create or alter procedure insertFeedback (@Customername nvarchar(200),@Comments nvarchar(100),@Productname nvarchar(100),@Rating int,@Createddate datetime2)
as
begin
 insert into Feedback(Customername,Comments,Productname,Rating,Createddate)values(@Customername,@Comments,@Productname,@Rating,@Createddate)
end
exec insertFeedback  'vidhya','super','apple',5,'05-23-2023'




--select with id

alter procedure selectFeedbackID(@Customername nvarchar(200))
  as
begin

  Select * from Feedback where Customername=@Customername
  end

exec selectFeedbackID 'vidhya'

exec selectFeedback;



--select sp
create procedure selectFeedback
  as
begin

  Select * from Feedback
  end

exec selectFeedback

alter procedure updatesFeedback (@Customername nvarchar(200),@Productname nvarchar(200))
as
begin
update Feedback set Customername=@Customername where Productname=@Productname
end
exec updatesFeedback'saru','table'
--delete
alter procedure deleteFeedback (@Customername nvarchar(200))
as
begin
delete from Feedback where Customername=@Customername
end
exec deleteFeedback 'saru'


