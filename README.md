# DIO - Trilha .NET - Programa��o orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, voc� precisar� usar seus conhecimentos adquiridos no m�dulo de orienta��o a objetos, da trilha .NET da DIO.

## Contexto
Voc� � respons�vel por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que voc� fa�a uma abstra��o de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu pr�prio comportamento, possibilitando um maior reuso de c�digo e usando a orienta��o a objetos.

## Proposta
Voc� precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes espec�ficas para dois tipos de celulares: Nokia e iPhone. 
Voc� deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e valida��es
1. A classe **Smartphone** deve ser abstrata, n�o permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O m�todo **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solu��o
O c�digo est� pela metade, e voc� dever� dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no c�digo, em seguida, implemente conforme as regras acima.