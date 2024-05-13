INSERT INTO Personas (IdPersona, NombreUsuario, Contrasenna, Nombre, Correo, FechaDeRegistro, Rol)
VALUES 
    (1, 'Juan1', 'contraseña123', 'Juan Pérez', 'juan@example.com', '2024-05-03 10:30:00', 'Usuario'),
    (2, 'usuario2', 'abc123', 'María Rodríguez', 'maria@example.com', '2024-05-03 11:45:00', 'Administrador'),
    (3, 'usuario3', 'qwerty', 'Pedro Gómez', 'pedro@example.com', '2024-05-04 09:15:00', 'Usuario');


INSERT INTO Cuestionarios ( IdPersona, Titulo, Descripcion, FechaDeCreacion, FechaDeEjecucion)
VALUES 
    ( 1, 'Cuestionario de Historia', 'Cuestionario sobre eventos históricos importantes', '2024-05-03 09:00:00', '2024-05-10 09:00:00'),
    ( 2, 'Cuestionario de Matemáticas', 'Cuestionario sobre conceptos básicos de matemáticas', '2024-05-03 10:30:00', '2024-05-11 10:00:00'),
    (3, 'Cuestionario de Ciencias', 'Cuestionario sobre biología, química y física', '2024-05-04 08:45:00', '2024-05-12 11:30:00');

INSERT INTO Pregunta (IdCuestionario, Pregunta, TipoDePregunta, TipoDeRespuesta, FechaDeEjecucion)
VALUES (2, '¿Cuántos años tienes?', 'Abierta', 'Número', GETDATE()),
       (3, '¿Te gusta la comida picante?', 'Selección Múltiple', 'Sí/No', GETDATE()),
       (2, '¿Cuál es tu película favorita?', 'Abierta', 'Texto', GETDATE());

INSERT INTO Respuesta (IdPregunta, Respuesta)
VALUES 
    (1, '20'),
    (2, 'Si'),
    (3, 'Pull Fiction'),
    (1, '30'),
    (2, 'No');
