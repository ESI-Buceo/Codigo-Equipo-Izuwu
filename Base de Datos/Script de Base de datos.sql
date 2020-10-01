create database Proyecto_izuwu;
use Proyecto_izuwu;

create table Usuario(
					 Nombre varchar(20)not null, 
					 Apellido varchar(20) not null, 
                     Email varchar(90) not null, 
                     ID_US varchar(11) primary key , 
                     Direccion varchar(30) not null, 
                     CI char(9) not null, 
                     Contraseña varchar(90) not null, 
                     Telefono char(11) not null, 
                     FDN date not null
                     );

create table Telefono_us(
						 Telefono char(11) ,
						 ID_US varchar(11) ,
                         
                         primary key(Telefono,ID_US),
						 constraint foreign key (ID_US) references Usuario(ID_US)
						);                         
                    
create table Medico(
					Espacializacion varchar(30),
                    ID_MED varchar(11) primary key,
                    
					constraint foreign key (ID_MED) references Usuario(ID_US)
                    );
  
create table Paciente(
					  ID_PAC varchar(11) primary key,
                      
					  constraint foreign key (ID_PAC) references Usuario(ID_US)
					 );
                     
create table Gestor(
					ID_GES varchar(11)primary key,
                    Empresa varchar(60) not null,
                    
                    
                    constraint foreign key (ID_GES) references Usuario(ID_US)
                    
);
   
create table Patologia(
					   Nombre varchar(90)not null,
					   Prioridad char(1)not null,
					   ID_PAT varchar(11) primary key 
                      );
                    
create table Sintoma(
					 Nombre varchar(90)not null,
                     ID_SIN varchar(11) primary key
                    );
     
create table Diagnostico(
						 ID_Diag varchar(11) primary key,
                         Contenido varchar (50) not null
                         
                         );
						 
create table Resulta(
					 ID_Diag varchar(11),
                     ID_PAT varchar(11),
                     
                     primary key(ID_Diag,ID_PAT),
                    
                     constraint foreign key (ID_Diag) references Diagnostico(ID_Diag),
                     constraint foreign key (ID_PAT) references Patologia(ID_PAT)
                    );
                   
create table Diagnostico_med(
							 ID_DMED varchar(11) primary key,
							 
                             
							 constraint foreign key (ID_DMED) references Diagnostico(ID_Diag)
							); 
                    
create table Diagnostico_app(
							 ID_DAPP varchar(11) primary key,
							 ID_PAC varchar(11)not null,
                             FechaHora date not null,
                             
							 constraint foreign key (ID_DAPP) references Diagnostico(ID_Diag),
                             constraint foreign key (ID_PAC) references Paciente(ID_PAC)
							);
                   
create table Posee(
				   Fecha date not null,
				   ID_SIN varchar(11),
				   ID_PAC varchar(11),
                   
                   primary key(ID_SIN,ID_PAC),
                    
				   constraint foreign key (ID_PAC) references Paciente(ID_PAC),
				   constraint foreign key (ID_SIN) references Sintoma(ID_SIN)
				   );    
                                                       
create table Tratamiento(
						 ID_TRT varchar(11) primary key,
						 Cantidad varchar(10) not null,
						 Descripcion varchar(90) not null,
						 Tipo varchar(15) not null
						 );
                                       
create table tipo_TRT(
					  Tipo varchar(15) not null,
                      ID_TRT varchar(11) primary key,
                    
					  constraint foreign key (ID_TRT) references Tratamiento(ID_TRT)
                    );

create table Tiene(
				   ID_PAT varchar(11),
				   ID_SIN varchar(11),
                   
                   primary key(ID_PAT,ID_SIN),
                    
				   constraint foreign key (ID_PAT) references Patologia(ID_PAT),
				   constraint foreign key (ID_SIN) references Sintoma(ID_SIN)
                    );
                 
create table Genera(
					ID_MED varchar(11) not null,
                    ID_DMED varchar(11) primary key,
                    
                    constraint foreign key (ID_MED) references Usuario(ID_US),
                    constraint foreign key (ID_DMED) references Diagnostico(ID_Diag)
                    );
                    
      
/* Datos de prueba */                   
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Usuario values("Bruno","Pintos","pintosbruno@gmail.com","PAC-AAA-001","Bruselas esq londres","56505181","dsadsdsasdase","53892734366",'2002-07-18'); 

insert into Usuario values("Cristian","norte","norte@gmail,com","PAC-AAA-002","la casas de norte","46503171","dsadsdsadsasdasdsdase","53892734266",'2003-01-22'); 

insert into Usuario values("Nicolas","Pere","nicoperemedico@gmail.com","MED-AAA-003","la casa de la salud","50921456","soymedico123","53895277648",'1996-09-01');

insert into Usuario values("Ignacio","Franco","nachofranco@gmail.com","PAC-AAA-004","Jose jupes","56785189","eltachitoga","53891524823",'2002-10-30');

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into paciente values("PAC-AAA-001");
insert into paciente values("PAC-AAA-002");
insert into paciente values("PAC-AAA-004");
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Medico values("Pediatra","MED-AAA-003");
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Sintoma values("Tos seca","FSC-AAA-002");
insert into Sintoma values("Tos","FSC-AAA-003");
insert into Sintoma values ("Fiebre","FSC-AAA-004");
insert into Sintoma values("Mocos","FSC-AAA-006");
insert into Sintoma values ("Dificultad respi","FSC-AAA-009");
insert into sintoma values("Mareos","FSC-AAA-010");
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Posee values('2020-07-23',"FSC-AAA-004","PAC-AAA-002");
insert into Posee values('2020-07-13',"FSC-AAA-006","PAC-AAA-001");
insert into Posee values('2020-07-18',"FSC-AAA-009","PAC-AAA-004");
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Patologia values("Covid","5","CVD-AAA-001");
insert into Patologia values("Gripe","3","GRP-AAA-002");
/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Tiene values("CVD-AAA-001","FSC-AAA-002");
insert into Tiene values("CVD-AAA-001","FSC-AAA-009");

insert into Tiene values("GRP-AAA-002","FSC-AAA-006");
insert into Tiene values("GRP-AAA-002","FSC-AAA-004");
insert into Tiene values("GRP-AAA-002","FSC-AAA-003");

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
insert into Diagnostico values ("DAP-AAA-001","Gripe");
insert into Diagnostico values ("DAP-AAA-002","Covid");
insert into resulta values ("DAP-AAA-001","GRP-AAA-002");
insert into resulta values ("DAP-AAA-002","CVD-AAA-001");
insert into Diagnostico_app values ("DAP-AAA-001","PAC-AAA-001","2020-08-18");
insert into Diagnostico_app values ("DAP-AAA-002","PAC-AAA-004","2020-05-14");

/*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
/* Fin de datos de prueba */ 


/* Consultas de prueba */    

use proyecto_izuwu;

Select *
from medico;

Select *
from usuario;



select ID_PAC,Nombre,Apellido
from Paciente 
inner join Usuario on
Paciente.id_pac=Usuario.id_us;


 select patologia.nombre,patologia.id_pat,sintoma.nombre
 from patologia
 inner join tiene on
 tiene.id_pat=patologia.id_pat 
 inner join sintoma on
 tiene.id_sin=sintoma.id_sin;
 

 insert into Usuario values("Prueba","Usuario","norte22@gmail,com","GES-AAA-002","la casas de prueba","46503231","algo123","53892731133",'2010-01-22'); 

 delete  
 from paciente
 where id_pac="000-000-003";
 
alter table medico change Espacializacion Especializacion varchar(30);
 
 
 /* Fin de consultas de prueba */
 
  /* Inicio de consultas solicitadas por el profesor */
  
/* 1) Para cada diagnóstico mostrar cuantas veces fue asignado por la app. Por ejemplo Resfrío 4 veces, Covid 3423 veces*/
  
select *
from diagnostico_app da inner join diagnostico d on da.ID_DAPP=d.id_diag 
inner join resulta r on d.id_diag=r.id_diag
inner join patologia p on r.id_pat=p.id_pat
;

  
/*2) Mostrar nombre y apellido de los pacientes y sus diagnósticos.*/

select u.Nombre , u.Apellido , d.Contenido
from  Usuario u inner join Paciente p on p.id_pac=u.id_us
inner join diagnostico_app da on p.Id_pac=da.id_pac
inner join diagnostico d on da.id_dapp=d.id_diag
;

/*3) Para el día de hoy, mostrar cuántos pacientes consultaron la aplicación. (Utilizar la función Today).*/

select *
from Paciente p inner join diagnostico_app da on p.Id_pac=da.id_pac
where da.FechaHora = curdate();
;
/*Para usar esta consulta se recomienda cabiar el tercer campo de las lineas 176 y 177*/


  /* Fin de consultas solicitadas por el profesor */
