#!/bin/bash
function menuP(){
clear
echo "--CENTRODE COMPUTO--"
echo "1- Usuario"
echo "2- Red"
echo "3- Servicio"
echo "4- Respaldo"
echo "5- Salir"
read -p "Opcion: " op

case $op in

1) sh inicio.sh;;

2) function Menured(){
clear
echo "--MENU RED--"
echo "1- Denegar Acceso a una IP"
echo "2- Permitir Acceso a una IP"
echo "3- Listar Reglas de Firewall"
echo "4- Comprobar conectividad a internet"
echo "5- Salir"

read -p "Opcion: " op2

case $op2 in

1)
sh Ipden.sh
Menured;;

2)
sh Ipaccept.sh
Menured;;

3)
iptables -L INPUT -n --line-numbers
echo ""
read -p "..."
Menured;;

4)
echo "Comprobando conexion a internet..."
ping www.google.com
read -p "..."
Menured;;

5)
menuP;;

esac

}
Menured;;



3) function menuFun(){
clear
echo "--MENU FUNCIONES--"
echo "1- Cambiar Puerto SSH"
echo "2- Status de SSHD"
echo "3- Reiniciar SSHD"
echo "4- PermitRoot Login"
echo "5- Salir"

read -p "Opcion: " op4
case $op4 in

1)
sh modPort.sh
menuFun;;

2)
systemctl status sshd
read -p "..."
menuFun;;

3)
systemctl restart sshd
read -p "..."
menuFun;;

4)
sh modRootLog.sh
menuFun;;

5)
menuP;;

esac


}
menuFun;;

4) function menuResp(){
clear
echo "1- Hacer respaldo Local"
echo "2- Revisar Actividad de Logs"
echo "3- Salir"

read -p "Opcion: " op5
case $op5 in

1)
sh RespLocal.sh
menuResp;;

2)function logsR(){
clear
echo "--REGISTROS DE LOGS--"
echo "1- Falied password"
echo "2- Accepted password"
echo "3- Salir"

read -p "Opcion: " op6
case $op6 in

1) grep "Failed password" /var/log/secure
read -p "..."
logsR;;

2) grep "Accepted password" /var/log/secure
read -p "..."
logsR;;

3)menuP;;

esac


}
logsR;;

3)
menuP;;

esac

}
menuResp;;

5)
echo ""
read -p "ADIOS, hasta la proxima! ;)"
exit;;

esac

}
menuP
