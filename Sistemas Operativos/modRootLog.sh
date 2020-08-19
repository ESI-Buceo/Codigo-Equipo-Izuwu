#!/bin/bash
oldport=$(grep -m 1 "PermitRootLogin " /etc/ssh/sshd_config)
echo ": " $oldport
echo "Inggresar (PermitRootLogin yes/no)"
read -p "yes/no: " newport
sed "s/$oldport/$newport/" /etc/ssh/sshd_config > /etc/ssh/sshd_config1
rm -f /etc/ssh/sshd_config
mv /etc/ssh/sshd_config1 /etc/ssh/sshd_config
verify=$(grep -m 1 "PermitRootLogin " /etc/ssh/sshd_config)
echo "Verificar si cambio el rootLogin: " $verify
read -p "..."
