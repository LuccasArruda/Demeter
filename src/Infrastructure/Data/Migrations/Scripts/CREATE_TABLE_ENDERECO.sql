CREATE TABLE ENDERECO (
    ID SERIAL PRIMARY KEY,
    ESTADO VARCHAR(50) NOT NULL,
    CIDADE VARCHAR(50) NOT NULL,
    BAIRRO VARCHAR(50) NOT NULL,
    RUA VARCHAR(100) NOT NULL,
    NUMERO VARCHAR(10) NOT NULL
);