using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EVEN NUMBERS 1 to 100");
        for (int i = 100; i > 0; i--) {
            if (i % 2 == 0) {
                Debug.Log(i);
            }
        }
    }
}
