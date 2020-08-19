#!/bin/bash
read -p "Ingresar la IP para denegar su acceso: " ipbloq
iptables -I INPUT 1 -s $ipbloq -p tcp --dport 22 -j DROP
read -p "Presione enter para continuar..."
