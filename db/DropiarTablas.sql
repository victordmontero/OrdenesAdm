/*
	AUTOR: Victor D. Montero Adames
	------------------------------------
	ELIMINA TABLAS CON TODO Y RELACIONES.
	***USAR CON CUIDADO***
*/
CREATE PROCEDURE DropiarTablas
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		DECLARE @name VARCHAR(255);
		DECLARE @namef VARCHAR(255);

		DECLARE cur CURSOR LOCAL FOR
		SELECT name FROM
		sys.objects
		WHERE type='U';

		OPEN cur;

		FETCH NEXT FROM
		cur INTO @name;

		WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE cur2 CURSOR LOCAL FOR
			SELECT name FROM sys.foreign_keys;

			OPEN cur2;
			FETCH NEXT FROM cur2
			INTO @namef

			WHILE @@FETCH_STATUS = 0
			BEGIN

				EXEC('ALTER TABLE ['+@name+'] DROP CONSTRAINT ['+@namef+']');
				-----------------------------------
				FETCH NEXT FROM cur2
				INTO @namef;
			END
			CLOSE cur2;
			DEALLOCATE cur2;

			EXEC('DROP TABLE '+@name);

			FETCH NEXT FROM cur
			INTO @name;
		END
		CLOSE cur;
		DEALLOCATE cur;
		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;
		PRINT(ERROR_MESSAGE())
	END CATCH
END --Fin del Procedure