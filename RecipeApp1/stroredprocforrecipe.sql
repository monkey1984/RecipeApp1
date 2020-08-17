Create Procedure [dbo].[sp_getRecipes]  
as  
begin  
   select * from Recipe
End
create procedure sp_saveRecipes
(@RecipeName varchar(30), @Rating int, @Hours int, @Minutes int, @Instructions varchar(500))
	as
	begin
	insert into Recipe values(@RecipeName, @Rating, @Hours, @Minutes, @Instructions)
	end