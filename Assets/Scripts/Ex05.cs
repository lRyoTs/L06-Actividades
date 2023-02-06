using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05 : MonoBehaviour
{
    public int[] numbers;
    private int result = 0; //Stores the sum of numbers
    // Start is called before the first frame update
    void Start()
    {
        //For each number
        foreach (int number in numbers) {
            result += number; //Add to result
        }
        Debug.Log(result);
    }
}
