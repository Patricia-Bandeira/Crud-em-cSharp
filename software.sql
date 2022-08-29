CREATE DATABASE software;
use software;
CREATE TABLE `software`.`alunosetec` (
  `matricula` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(100) NOT NULL,
  `Idade` INT NOT NULL,
  `Genero` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  `Contato` VARCHAR(45) NOT NULL,
  `Endereco` VARCHAR(200) NOT NULL,
  `Curso` VARCHAR(100) NOT NULL,
  `Tipo` VARCHAR(45) NOT NULL,
  `Inicio` DATE,
  `Fim` DATE,
  PRIMARY KEY (`matricula`));
select `matricula`, `Nome`,`Curso`, `Tipo`, `Inicio`, `Fim` FROM `alunosetec` ;
select * from alunosetec;

INSERT INTO alunosetec (Nome, Idade, Genero, Email, Contato, Endereco, Curso, Tipo, Inicio, Fim) VALUES
('Patricia', '17','Feminino','patricia.souza244@gmail.com','(11)942909415','Rua Equador 111, Jardim América Taboão da Serra', 'Desenvolvimento de Sistemas', 'Tecnologia', '2021-02-10',  '2022-12-23');

CREATE TABLE `software`.`cursostec` (
  `idcurso` INT NOT NULL AUTO_INCREMENT,
  `Nome_do_curso` VARCHAR(100) NOT NULL,
  `Duração` VARCHAR(45) NOT NULL,
  `Tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idcurso`));
  
  select * from cursostec;
  INSERT INTO cursostec (Nome_do_curso, Duração, Tipo )VALUES
  ('Desenvolvimento de Sistemas','3 semestres','Tecnologia');
  
  

