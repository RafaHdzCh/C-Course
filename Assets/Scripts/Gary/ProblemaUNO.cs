using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class ProblemaUNO : MonoBehaviour
{
    [SerializeField] int[] userInputs;
    int minValue;

    private void Start()
    {
        GetIndexOfLowestValue(userInputs);
    }

    public void GetIndexOfLowestValue(int[] array)
    {
        float value = float.PositiveInfinity;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < value)
            {
                value = array[i];
            }
        }
        print("Problema 1 - FOR: " + value);
    }
}
