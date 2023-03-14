using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaTRES : MonoBehaviour
{
    [SerializeField] int[] userInputs;
    int minValue;

    private void Start()
    {
        GetIndexOfLowestValue(userInputs);
    }

    public void GetIndexOfLowestValue(int[] array)
    {
        //foreach
    }
}
