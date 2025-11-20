alter table tb_produto add column condicao varchar(50);

delimiter &
create procedure sp_insert_produto(in v_cpf_cliente varchar(20), in v_marca varchar(50), in v_modelo varchar(50), in v_n_serie varchar(50), v_tipo varchar(50), in v_condicao varchar(50)) 
begin
	declare id_cliente int;
    DECLARE cpf_nao_encontrado CONDITION FOR SQLSTATE '45000';
    set id_cliente := (select idPessoa from tb_pessoa where v_cpf_cliente = cpf_cnpj limit 1);
    
    if id_cliente is null
    then
        signal sqlstate '45000' set MESSAGE_TEXT ='CPF não encontrado';
	end if;
    
    insert into tb_produto values (null, id_cliente, v_marca, v_modelo, v_n_serie, v_tipo, v_condicao);
    
end &

delimiter ;

