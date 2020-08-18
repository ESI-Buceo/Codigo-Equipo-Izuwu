#!/bin/bash
clear
function ModUsuario(){
clear
echo "Modificaciones"
echo " "
echo "1- Nombre de usuario"
echo "2- Contraseña"
echo "3- Volver"
read -p "Opcion: " op
case $op in

1) 
read -p "Nombre actual: " nomviejo
read -p "Nombre nuevo: " nomnuevo
sudo usermod -l $nomnuevo $nomviejo
sh inicio.sh;;

2) 
read -p "Nombre del usuario: " nom
sudo passwd $nom
sh inicio.sh;;

3) 
sh inicio.sh;;
*) echo "Opcion incorrecta"
sleep 1

ModUsuario;;
esac
}
ModUsuario
