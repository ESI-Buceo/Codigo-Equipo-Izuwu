#!/bin/bash
clear
function inicio(){
clear
echo "Inicio"
echo " "
echo "1- Crear Usuario"
echo "2- Borrar Usuario"
echo "3- Modificar Usuario"
echo "4- Salir"
read -p "Opcion: " op
case $op in
1) sh alta.sh;;
2) sh baja.sh;;
3) sh modificar.sh;;
4) exit;;
*) echo "Opcion Incorrecta"
sleep 1
inicio;;
}
inicio
