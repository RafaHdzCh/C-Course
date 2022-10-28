using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    string label;
    string name = "Name";
    int score = 100;

    [SerializeField] StringsAndParameters stringsAndParametersScript;

    private void Start()
    {
      //label = "Name Score:100"
        label = $"{name} Score:{score}"; //text = "Name Score:100"
        stringsAndParametersScript.HighScore(name, score);
    }

}
