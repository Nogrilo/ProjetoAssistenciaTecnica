delimiter $

create procedure sp_ordem_servico(
    in v_n_atendimento int, 
    in v_defeito text, 
    in v_acessorios varchar(155), 
    in v_status_pd enum('Na fila para concerto','Esperando peça','Esperando orçamento','Saída'), 
    in v_id_orc_inicial int,
    in v_cpf_cliente varchar(20),
    in v_id_produto int)
begin

	declare v_tick_novo int;
	declare v_id_cliente int;
	declare v_ver_tick int;
    declare v_ver_nat int;
    declare v_tick_existente int;
    
	call sp_gerador_tick(@tick);

    set v_tick_novo := @tick;
    set v_tick_existente := (select tick from tb_ordem_servico where id_produto = v_id_produto order by 1 desc limit 1); 
    set v_ver_nat := (select n_atendimento from tb_ordem_servico where tick = v_tick_existente order by 1 desc limit 1);
    set v_ver_tick := (select tick from tb_ordem_servico where tick = v_tick_existente order by 1 desc limit 1);
	set v_id_cliente := (select idPessoa from tb_pessoa where cpf_cnpj = v_cpf_cliente);
    
    if v_ver_tick is null then
		insert into tb_ordem_servico(tick, n_atendimento, defeito, data_abertura, acessorios, id_orcamento_inicial, id_pertencente, id_produto) 
		values(v_tick_novo, 1, v_defeito, CURDATE(), v_acessorios, v_id_orc_inicial, v_id_cliente, v_id_produto);
    else
		set v_ver_nat := v_ver_nat + 1;
		insert into tb_ordem_servico(tick, n_atendimento, defeito, data_abertura, acessorios, id_orcamento_inicial, id_pertencente, id_produto) 
		values(v_tick_existente, v_ver_nat, v_defeito, CURDATE(), v_acessorios, v_id_orc_inicial, v_id_cliente, v_id_produto);
    end if;
end $

delimiter ;
