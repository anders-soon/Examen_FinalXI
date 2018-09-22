---Datos Tabla Pais
insert into pais (Id_pais,pais) values (1,'Guatemala');
insert into pais (Id_pais,pais) values (2,'Brujas');
insert into pais (Id_pais,pais) values (3,'Ámsterdam');
insert into pais (Id_pais,pais) values (4,'Londres');
insert into pais (Id_pais,pais) values (5,'Tokio');


---Datos Tabla Gama
insert into Gama(Id_gama,gama) values (1,'XSs');
insert into Gama(Id_gama,gama) values (2,'Maxs');
insert into Gama(Id_gama,gama) values (3,'MaxRR');
insert into Gama(Id_gama,gama) values (4,'XR');
insert into Gama(Id_gama,gama) values (5,'Max');

---Datos Tabla Color
insert into Color(id_color,color) values (1,'Blanco');
insert into Color(id_color,color) values (2,'Azul');
insert into Color(id_color,color) values (3,'Gris');
insert into Color(id_color,color) values (4,'Verde');
insert into Color(id_color,color) values (5,'Rojo');

--Datos Tabla Telefono
insert into Telefono(gama,color,pais) values(2,1,5);
insert into Telefono(gama,color,pais) values(4,5,2);
insert into Telefono(gama,color,pais) values(5,3,1);
insert into Telefono(gama,color,pais) values(2,4,3);
insert into Telefono(gama,color,pais) values(3,5,5);

--Datos Tabla Registro
insert into Registro(FechaHora,telefono,total) values('12/12/2009',2,1500);
insert into Registro(FechaHora,telefono,total) values('09/26/2018',4,2000);
insert into Registro(FechaHora,telefono,total) values('10/10/2015',1,2500);
insert into Registro(FechaHora,telefono,total) values('01/13/2013',3,3500);
insert into Registro(FechaHora,telefono,total) values('06/12/2011',5,5000);



select * from Registro

