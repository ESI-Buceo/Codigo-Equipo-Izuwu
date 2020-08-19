#!/bin/bash
clear
function BorrarUsuario(){
clear
echo "Borrar Usuarios"
echo " "
echo "1- Borrar"
echo "2- Volver"
read -p "Opcion: " op
case $op in
1)
read -p "Ingrese usuario a borrar: " nombre
sudo userdel -r $nombre
BorrarUsuario;;
2)sh inicio.sh;;
*) echo "Opcion incorrecta"
sleep 1
BorrarUsuario;;
esac
}
BorrarUsuario
