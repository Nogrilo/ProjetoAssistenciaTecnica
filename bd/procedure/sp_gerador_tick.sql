CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_gerador_tick`(OUT tick_novo int)
BEGIN
DECLARE ultimo_tick INT;
    SELECT MAX(TICK) INTO ultimo_tick FROM tb_ordem_servico;
    IF ultimo_tick IS NULL THEN
        SET tick_novo = 1;                    
    ELSE
        SET tick_novo = ultimo_tick + 1;
    END IF;
END