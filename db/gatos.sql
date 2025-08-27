DROP TABLE IF EXISTS Gatos;

CREATE TABLE Gatos (
    Id INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(50) NOT NULL,
    Cor VARCHAR(20) NOT NULL,
    Idade INT,
    Raca VARCHAR(20) NOT NULL,
    Dono VARCHAR(50) NOT NULL,
    Sexo VARCHAR(20) NOT NULL,
    PRIMARY KEY(Id)
);

INSERT INTO Gatos (Nome, Cor, Idade, Raca, Dono, Sexo) VALUES
('Frajola', 'Branco e Preto', 1, 'Siames', 'Lucas', 'Macho'),
('Garfield', 'Laranja', 2, 'Persa', 'Joao', 'Macho');