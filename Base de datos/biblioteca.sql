CREATE DATABASE programacion CHARSET utf8mb4;

CREATE TABLE libro(
	id_libro INT UNSIGNED AUTO_INCREMENT NOT NULL,
    ISBN INT (13) NOT NULL,
    nom_libro VARCHAR(30) NOT NULL,
    autor VARCHAR(30) NOT NULL,
    genero VARCHAR(20) NOT NULL,
    fecha_lanzamiento DATE NOT NULL,
    cant_paginas SMALLINT(10) NOT NULL,
    PRIMARY KEY(id_libro)
);

CREATE TABLE socio(
	id_socio INT UNSIGNED AUTO_INCREMENT NOT NULL,
    nom_socio VARCHAR(30) NOT NULL,
    ape_socio VARCHAR(30) NOT NULL,
    tel_socio TINYINT NOT NULL,
    PRIMARY KEY(id_socio)
);

CREATE TABLE prestamo(
	socio INT UNSIGNED NOT NULL,
    libro INT UNSIGNED NOT NULL,
    fecha_prestamo DATE,
    fecha_devolucion DATE,
	CONSTRAINT FK_socio FOREIGN KEY (socio) REFERENCES socio(id_socio),
    CONSTRAINT FK_libro FOREIGN KEY (libro) REFERENCES libro(id_libro),
    PRIMARY KEY(socio, libro,fecha_prestamo)
);