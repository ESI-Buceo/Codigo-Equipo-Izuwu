#!/bin/bash
oldport=$(grep "Port " /etc/ssh/sshd_config)
echo "Puerto Actual: " $oldport
echo "Ingrese Port (Numero de puerto)"
read -p "Nuevo Puerto: " newport
sed "s/$oldport/$newport/" /etc/ssh/sshd_config > /etc/ssh/sshd_config1
rm -f /etc/ssh/sshd_config
mv /etc/ssh/sshd_config1 /etc/ssh/sshd_config
verify=$(grep "Port " /etc/ssh/sshd_config)
echo "Verificar si cambio el puerto: " $verify
read -p "..."
