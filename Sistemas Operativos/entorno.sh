#!/bin/bash
function inicio(){
clear
echo "Entorno de trabajos"
echo " "
echo "1- Crear directorios"
echo "2- Respaldar directorios"
echo "3- Salir"
read -p "Opcion: " op
case $op in
1) cd /home
if [ -d /home/Usuarios ]
then
echo "ya existe"
else
sudo mkdir Usuarios
fi
cd Usuarios
if [ -d /home/Usuarios/Medico ]
then
echo "ya existe"
else
sudo mkdir Medico
fi
if [ -d /home/Usuarios/Administrador ]
then
echo "ya existe"
else
sudo mkdir Administrador
fi
inicio;;
2) cd /home
sudo mkdir Respaldo
sudo cp -r /home/Usuarios/ /home/Respaldo/
inicio;;
3) exit;;
*) echo "Opcion incorrecta"
sleep 1
inicio;;
esac
}
inicio
