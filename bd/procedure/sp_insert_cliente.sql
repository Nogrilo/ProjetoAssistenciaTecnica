drop procedure sp_insert_cliente;

DELIMITER $

CREATE PROCEDURE sp_insert_cliente(
    IN v_nome VARCHAR(155),
    IN v_cpf_cnpj VARCHAR(20),
    IN v_telefone VARCHAR(16),
    IN v_email VARCHAR(200),
    IN v_data_nasc DATE,
    IN v_estado VARCHAR(2),
    IN v_municipio VARCHAR(200),
    IN v_bairro VARCHAR(200),
    IN v_rua VARCHAR(200),
    IN v_complemento VARCHAR(25),
    IN v_ncomplemento VARCHAR(20),
    IN v_cep VARCHAR(9)
)
BEGIN
    DECLARE ex_cpf_cnpj_invalido CONDITION FOR SQLSTATE '95959';
    DECLARE v_id_pessoa INT;

    IF LENGTH(v_cpf_cnpj) = 11 OR LENGTH(v_cpf_cnpj) = 14 THEN
        INSERT INTO tb_pessoa(
            nome, 
            cpf_cnpj, 
            telefone, 
            email, 
            data_nascimento, 
            data_cadastro
        ) 
        VALUES (
            v_nome, 
            v_cpf_cnpj, 
            v_telefone, 
            v_email, 
            v_data_nasc, 
            CURDATE()
        );
        
        SET v_id_pessoa = LAST_INSERT_ID();

        INSERT INTO tb_cliente(id_pessoa) 
        VALUES (v_id_pessoa);

    ELSE
        SIGNAL ex_cpf_cnpj_invalido SET MESSAGE_TEXT = 'O valor não está em formato CPF/CNPJ';
    END IF;

    CALL sp_insert_endereco(v_id_pessoa, v_estado, v_municipio, v_bairro, v_rua, v_complemento, v_ncomplemento, v_cep);
END$
DELIMITER ;