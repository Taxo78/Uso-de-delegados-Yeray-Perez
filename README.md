1. Explicacion del problema:

Para este programa el profesor nos pide que desarrollemos una aplicacion en consola que permita ejecutar operaaciones matematicas aritmeticas usando los delegados (herramienta que nos enseñó a usar la pasada clase, ttambien pide que el sistema sea organizado y flexible con la posivilidad de escalarlo en el futuro, o sea, agregarle mas formas de calcular y asi.

2.Definicion de delegados

Un delegado es un tipo de dato que referencia a un metodo, es eso que tiene la direccion de una funcion para usarlo despues

3.POR QUE USAR DELEGADOS EN VEZ DE LLAMAR METODOS DIRECTAMENTE:

Usar delegados en ves de llamadas directas nos da muchas ventajas, la que a mi mas me gusta es, la flexibilidad que nos da el que el programa pruincipal no necesite saber que metodo especifico usar, solo con llamar al delegado esta bien.

4.COMO SE IMPLEMENTARON EN EL PROYECTO:

primero creo mi delegado (Midelegado) para definir las operaciones
segundo la clase, ahi agrupo los metodos sumar, restar etc. el delegado las llamara de ahi
tercero guardo los metodos en un diccionario para que al elegir algun simbolo aritmetico de los que puse el programaa sepa que metodo usar y asi lo asigna al delegado y lo ejecute.


5. EJEMPLO DE USO DEL PROGRAMA:
Al iniciar el progrm nos pedira un numero x, luego de poner el numero ponemos la operacion aritmetique que querraamos realizar, y finalmente el otro numero que se vera involucrado en el calculo.
El programa calcula y muestra el resultado.


6.CAPTURAS DEL PROGRAMA EN EEJECUCION:
<img width="1907" height="1002" alt="image" src="https://github.com/user-attachments/assets/6f4d91e3-3e85-45d5-89ad-82b7480780b3" />
nos pide el numero

<img width="1892" height="970" alt="image" src="https://github.com/user-attachments/assets/2669f3fc-5d96-4310-89e5-e1d71fc1746f" />
ponemos un numero x y nos pide la operacion

<img width="1873" height="963" alt="image" src="https://github.com/user-attachments/assets/1f79a31d-b1fd-4751-8748-b6432d0dca97" />
ponemos la operacion y el otro numero y nos da el resultado
33 / 3 = 11
