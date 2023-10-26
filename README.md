# TrabajoFinalSofttekFront

Este proyecto es el FrontEnd de una billetera virtual. El siguiente link corresponde a la parte del back donde se explica mas en detalle la funcionalidad y como esta compuesto. El proyecto esta incompleto, solo funciona el login y se crearon views y controllers de cuentas. Tambien se establecio la conexcion con la API del back

https://github.com/FrancoScaglione203/TrabajoFinalSofttek/tree/master

---
---

## **Views** 


Login: Donde se encuentra el login y un boton para redirigir a la view NuevoUsuario

NuevoUsuario: donde se cargan los datos para registar un nuevo usuario en DB

NuevaCuentaFiduciaria: donde se cargan los datos para registar una nueva Cuenta Fiduciaria en DB correspondiente al usuario logueado

NuevaCripto: donde se cargan los datos para registar una nueva Cuenta Cripto en DB correspondiente al usuario logueado

Home: en el home la idea es se muestre el cuil del usuario y que haya tres botones donde se puedan consultar los tres tipos de saldos de la cuenta

CuentaFiduciaria: En esta view se observarian todos los datos de la CuentaFiduciaria y tambien habria botones para poder realiar un deposito, extraccion, transferencia o venta de dolares

CuentaCripto:En esta view se observarian todos los datos de la CuentaCripto y tambien habria botones para poder realiar un deposito, extraccion, transferencia, venta y compra de BTC

Historial: La idea es que en esta view el usuario pueda consultar todos los movimientos que tiene al usuario logueado como origen

---
---
## **Especificación de la Arquitectura**
### **Capa Controllers**
En los controladores deberíamos definir la menor cantidad de lógica posible y utilizarlos como un pasamanos con la capa de servicios.


### **Capa DTOS**
En esta capa estan definidos todos los DataTransferObjects.


### **Capa Models**
En esta capa estan definidos todos los models para transferir datos entre el Back y el Front


### **Capa Views**
En estra capa se encuentran todas las vistas


---
---
## **Paquetes Instalados**
![Logo de Mi Proyecto](https://i.imgur.com/br9CcXN.jpg)

---
---
## **Mejoras Versiones Futuras**
Debido a la falta de tiempo el proyecto quedo incompleto, la idea es terminar las views y controllers de CuentaFiduciaria, CuentaCripto e Historial. Tambien falta agregarle la autenticacion para ingresar a las Views

---
---

## **Especificación de GIT**​
* Se implento el patron GitFlow. La rama donde se encuentran las versiones finales es Master, la rama principal a partir de la cual se crean ramas es Develop. La nomenclatura para el nombre de las ramas será la sigueinte: Feature/xx-Titulo (donde xx corresponde con el número de historia)
* El título del pull request debe contener el título de la historia tomada.
---
---
## **Autor**​
* Scaglione Franco
---
---
## **Contacto**
franco.scaglione2@gmail.com
