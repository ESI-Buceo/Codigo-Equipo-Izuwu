#!/bin/bash
iptables -L INPUT -n --line-numbers
echo ""
read -p "Seleccione la posicion en la que se encuentra la IP: " ipdes
iptables -D INPUT $ipdes

