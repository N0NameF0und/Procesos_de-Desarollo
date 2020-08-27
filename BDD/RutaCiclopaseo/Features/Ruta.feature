# language: es
Característica: Ruta
	Para transaldarme de distitintos puntos en la ciudad de Quito
	como un ciclista lento
	Quiero saber el tiempo estimado de un viaje

@mytag
Escenario: Manejo directo 
	Dado que se recorro a una velocidad media de  10 KM/HORA 
	Y existe una distancia media entre puntos de 40 KM
	Entonces mi tiempo seria de 4 HORAS

Escenario: Manejo con varios puntos 
	Dado que estoy andando a una <velocidad> KM/HORA 
	Y por <distancia> KM
	Entonces mi tiempo medio seria de 1.66 HORAS

  Ejemplos:
    | velocidad | distancia|
    | 5			| 3		   |
    | 9			| 15       |
    | 4			| 7        |
    | 0			| 2        |
    | 9			| 8        |