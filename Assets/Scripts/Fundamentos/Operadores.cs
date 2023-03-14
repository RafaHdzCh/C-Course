using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores : MonoBehaviour
{
    int number;
    bool boolean;
    void Start()
    {
        //Operadores Aritmeticos 
        number = 2 + 2;
        number = 2 + 2;
        number = 2 * 2;
        number = 2 / 2;

        //Operadores de Asignacion
        number += 2; //number = number + 2;
        number -= 2; //number = number = 2;
        number *= 2; //number = number * 2;
        number /= 2; //number = number / 2;

        //Operadores Relacionales
        boolean = 2 > 1;
        boolean = 2 < 1;
        boolean = 2 == 2;
        boolean = 2 != 2;
        boolean = 2 >= 1;
        boolean = 2 <= 1;

        //Opeeradores logicos

              //condicion o condicion
        boolean = 2 == 2 || 4 == 4;
              //condicion y condicion
        boolean = 2 == 2 && 4 == 4;
              //Invertir(condicion)
        boolean = !(2 == 2);
        if(boolean)
        {
            boolean = false;
        }
    }
}
