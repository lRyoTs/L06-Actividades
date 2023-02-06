using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public int start = 0;
    public int end = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MULTIPLES of 5 between start and end");
        int num = start; //number to check from start to end
        while (num <= end) {
            if (num % 5 == 0) { //CHeck if is mutiple of 5
                Debug.Log(num);//Display
            }
            num++; //next number
        }
    }
}
