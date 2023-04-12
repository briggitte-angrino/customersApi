1. ingrese a la  terminal y dirijase a la raiz 
2. ingrese el comando sudo chmod 777 opt
3. ingre a la carpteta opt y cre una carpeta llamda services
4. pase los archivos que estan en la carpeta sql  a la carpeta creada en el paso anterior
5. ubiquece en al carpeta services
6. ejecute el comando sudo kubectl apply -f mysql-pvc.yaml para crear el volumen 
7. edite el archivo mysql.yaml y defina en la sección env: la contraseña del usuario root
8. ejecute el comando sudo kubectl apply -f mysql.yaml para crear el servicio
9. sudo kubectl cp bd_clientes.sql pod-id :/tmp/dump.sql
10.  sudo kubectl exec -it pod-id -- /bin/bash
11. mysql -u root -p < /tmp/dump.sql
12. ingrese la contraseña de la base de datos del paso 7.
13. salga de la configuración  xon el comando exit 
14. valide que el servicio se encuentra arriba y la base de datos esta creada y con información.
15. Si no tiene instalado el cliente de mysql instalelo con: sudo apt-get install mysql-client
16. ingrese el siguiente comando sudo mysql -h 10.0.2.15 -u root -p
17. ingrese la contraseña de usuario root de la bd 
18. ingrese comando show databases;,
19.  use bd_clientes;
20. use comando select * from user; deberia salirle la lista de clientes creados hasta el momento.
21. si todo ha salido bien hasta aca puede continuar con el montaje del servicio.

