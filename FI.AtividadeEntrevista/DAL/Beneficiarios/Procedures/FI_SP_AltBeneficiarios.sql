﻿CREATE PROC FI_SP_AltBeneficiarios
    @NOME          VARCHAR (50) ,
    @CPF     VARCHAR (14),
	@Id           BIGINT
AS
BEGIN
	UPDATE BENEFICIARIOS
	SET 
		NOME = @NOME, 
		CPF = @CPF
	WHERE Id = @Id
END