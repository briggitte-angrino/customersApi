1. cree una carpeta llamada app en la ruta /opt/services : mkdir app
2. asegurece de tener git en su maquina 
3. si no tiene git instalado ejecute lo siguiente: 
3.1 apt-get install git
4.ubiquese en la ruta /opt/services/app/
5 descargue el repo: git clone https://github.com/NikolasSantofimio/customersApi
7. edite el archivo Dockerfile que se encuentra en la ruta  opt/services/app/customersApi/customersApi/ y modifique la variable de entorno CONNECTION  con el puerto en donde se levanto el servicio de mysql y la cotraseña del servicio root
6. dirijase a la ruta   cd opt/services/app/customersApi/
7. construya la imagen del docker con el siguietne comando sudo docker build -f customersApi/Dockerfile -t customerapi .
8. revise que la imagen  este creada con el comando docker images
9.ubique el archivo app.yaml en la ruta cd opt/services/app/customersApi
9. ejecute el comando sudo kubectl apply -f app.yaml
10. verifique que el servicio como el pod se crearon de manera correcta





