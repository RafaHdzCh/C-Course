using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class ProblemaDOS : MonoBehaviour
{
    [SerializeField] int[] userInputs;

    private void Start()
    {
        GetIndexOfLowestValue(userInputs);
    }

    public void GetIndexOfLowestValue(int[] array)
    {
        float value = float.PositiveInfinity;
        int index = 0;

        while(index < array.Length)
        {
            if (array[index] < value)
            {
                value = array[index];
            }
            index++;
        }
        print("Problema 2 - WHILE: " + value);
    }
}
