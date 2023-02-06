using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    private string message = "Hola, holita, vecinito"; //Message to display
    public int numIteration = 20; //number of Iterations desired
    // Start is called before the first frame update
    void Start()
    {
        //Check if numIteration > 0 and post decrement numIteration
        while (numIteration-- > 0) {
            Debug.Log(message); //Display message
        }
    }
}
