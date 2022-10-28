using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringsAndParameters : MonoBehaviour
{
    public void HighScore(string name, int score)
    {
        print($"La nueva puntuacion maxima es de {name} con {score} puntos");
    }
}
