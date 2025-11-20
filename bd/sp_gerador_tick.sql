delimiter &

create procedure sp_gerador_tick(out tick_novo int, out n_atendimento int)
begin 
 select tick + 1, n_atendimento + 1 into tick_novo, n_atendimento from tb_ordem_servico 
 order by 1 desc limit 1;
end &

delimiter ;

drop procedure sp_gerador_tick;