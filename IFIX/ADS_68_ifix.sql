create table c_estado_vehiculo_servicio
(
    id_estado   int         not null
        constraint c_estado_vehiculo_servicio_pk
            primary key,
    estado      varchar(50) not null,
    descripcion varchar(150)
)
go

INSERT INTO ifixdb.dbo.c_estado_vehiculo_servicio (id_estado, estado, descripcion) VALUES (1, 'Pendiente', 'El vehículo sigue en espera');
INSERT INTO ifixdb.dbo.c_estado_vehiculo_servicio (id_estado, estado, descripcion) VALUES (2, 'Trabajando', 'El vehículo se encuentra en reparación');
INSERT INTO ifixdb.dbo.c_estado_vehiculo_servicio (id_estado, estado, descripcion) VALUES (3, 'Finalizado', 'El vehículo esta listo para su entrega');
INSERT INTO ifixdb.dbo.c_estado_vehiculo_servicio (id_estado, estado, descripcion) VALUES (4, 'Entregado', 'El vehículo ha sido entregado');
create table c_servicio
(
    id_servicio int         not null
        constraint c_servicio_pk
            primary key,
    nombre      varchar(50) not null,
    costo       float       not null
)
go

INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (1, 'Cambio de aceite', 500);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (2, 'Alineación', 500);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (3, 'Balanceo', 500);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (4, 'Chequeo General', 100);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (5, 'Chequeo de presion de llantas', 50);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (6, 'Chequeo a computadora', 250);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (7, 'Cambio de balatas', 300);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (8, 'Reparación filtro de gasolina', 200);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (9, 'Reparacion de transmision', 150);
INSERT INTO ifixdb.dbo.c_servicio (id_servicio, nombre, costo) VALUES (10, 'Reparacion de carburador', 500);
create table c_tipo_de_vehiculo
(
    id_tipo     int         not null
        constraint c_tipo_de_vehiculo_pk
            primary key,
    tipo        varchar(50) not null,
    descripcion varchar(50)
)
go

INSERT INTO ifixdb.dbo.c_tipo_de_vehiculo (id_tipo, tipo, descripcion) VALUES (1, 'Sedan', null);
INSERT INTO ifixdb.dbo.c_tipo_de_vehiculo (id_tipo, tipo, descripcion) VALUES (2, 'Hatchback', null);
INSERT INTO ifixdb.dbo.c_tipo_de_vehiculo (id_tipo, tipo, descripcion) VALUES (3, 'Coupé', null);
INSERT INTO ifixdb.dbo.c_tipo_de_vehiculo (id_tipo, tipo, descripcion) VALUES (4, 'SUV', null);
INSERT INTO ifixdb.dbo.c_tipo_de_vehiculo (id_tipo, tipo, descripcion) VALUES (5, 'Pick Up', null);
create table cliente
(
    id_cliente         int         not null
        constraint cliente_pk
            primary key,
    nombre             varchar(50) not null,
    usuario            varchar(50) not null,
    contrasena         varchar(50) not null,
    numero_de_telefono varchar(15) not null,
    email              varchar(50)
)
go

INSERT INTO ifixdb.dbo.cliente (id_cliente, nombre, usuario, contrasena, numero_de_telefono, email) VALUES (1, 'Prueba', 'Pig', '12345', '8341067898', 'prueba@gmail.com');
create table empleado
(
    id_empleado int         not null
        constraint empleado_pk
            primary key,
    nombre      varchar(50) not null,
    email       varchar(50) not null,
    celular     varchar(50) not null,
    edad        int         not null
)
go

INSERT INTO ifixdb.dbo.empleado (id_empleado, nombre, email, celular, edad) VALUES (1234, 'Otra Prueba', 'empprueba@gmail.com', '8341023578', 34);
create table vehiculo
(
    id_vehiculo                int         not null
        constraint vehiculo_pk
            primary key,
    foto                       varchar(30),
    num_serie                  char(17)    not null,
    marca                      varchar(50) not null,
    modelo                     varchar(50) not null,
    anio                       int         not null,
    color                      varchar(50),
    alarma                     char,
    cristales_electricos       char,
    gps                        char,
    airbag                     char,
    observaciones              nvarchar(250),
    cliente_id_cliente         int
        constraint vehiculo_cliente_fk
            references cliente,
    c_tipo_de_vehiculo_id_tipo int
        constraint vehiculo_c_tipo_de_vehiculo_fk
            references c_tipo_de_vehiculo
)
go

INSERT INTO ifixdb.dbo.vehiculo (id_vehiculo, foto, num_serie, marca, modelo, anio, color, alarma, cristales_electricos, gps, airbag, observaciones, cliente_id_cliente, c_tipo_de_vehiculo_id_tipo) VALUES (1, 'foto', '12345678901234567', 'Toyota', 'Yaris', 2018, 'rojo', 'S', 'S', 'S', 'S', 'esta bonito', 1, 1);
create table vehiculo_servicio
(
    id                                   int  not null
        constraint vehiculo_servicio_pk
            primary key,
    fecha_entrada                        date not null,
    fecha_salida                         date,
    fecha_terminacion                    date,
    vehiculo_id_vehiculo                 int
        constraint vehiculo_servicio_vehiculo_fk
            references vehiculo,
    c_servicio_id_servicio               int
        constraint vehiculo_servicio_c_servicio_fk
            references c_servicio,
    empleado_id_empleado                 int
        constraint vehiculo_servicio_empleado_fk
            references empleado,
    c_estado_vehiculo_servicio_id_estado int
        constraint vehiculo_servicio_c_estado_vehiculo_servicio_fk
            references c_estado_vehiculo_servicio
)
go

INSERT INTO ifixdb.dbo.vehiculo_servicio (id, fecha_entrada, fecha_salida, fecha_terminacion, vehiculo_id_vehiculo, c_servicio_id_servicio, empleado_id_empleado, c_estado_vehiculo_servicio_id_estado) VALUES (12, '2019-06-20', null, null, 1, 1, 1234, 2);