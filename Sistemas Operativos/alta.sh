#!/bin/bash
clear
function alta(){
clear
echo "Creacion de Usuarios"
echo " "
echo "1- Medico"
echo "2- Administrador"
echo "3- Volver"
read -p "Opcion: " op2
case $op2 in
1) CrearUsuario_Medico;;
2) CrearUsuario_Administrador;;
3) sh inicio.sh;;
*) echo "Opcion Incorrecta";;
esac
}
function CrearUsuario_Medico(){
read -p "Ingrese nombre del Medico: " nombre
read -p "Ingrese nombre del directorio de trabajo: " directorio
read -p "Ingrese el grupo de trabajo: " grupo
echo "¿Este grupo existe?"
echo "1- Si"
echo "2- No"
read -p "" op
case $op in
1)
sudo useradd -d /home/Usuarios/Medico/$directorio -m -s /bin/bash -g $grupo -G $grupo $nombre
echo "Ingrese contraseña para el usuario"
sudo passwd $nombre;;
2) sudo groupadd $grupo
sudo useradd -d /home/Usuarios/Medico/$directorio -m -s /bin/bash -g $grupo -G $grupo $nombre
echo "Ingrese contraseña para el usuario"
sudo passwd $nombre;;
esac
alta
}
function CrearUsuario_Administrador(){
read -p "Ingrese nombre del Administrador: " nombre
read -p "Ingrese nombre del directorio de trabajo: " directorio
read -p "Ingrese el grupo de trabajo: " grupo
echo "¿Este grupo existe?"
echo "1- Si"
echo "2- No"
read -p "" op
case $op in
1)
sudo useradd -d /home/Usuarios/Administrador/$directorio -m -s /bin/bash -g $grupo -G sudo $nombre
echo "Ingrese contraseña para el usuario"
sudo passwd $nombre;;
2) sudo groupadd $grupo
sudo useradd -d /home/Usuarios/Administrador/$directorio -m -s /bin/bash -g $grupo -G sudo $nombre
echo "Ingrese contraseña para el usuario"
sudo passwd $nombre;;
esac
alta
}
alta
