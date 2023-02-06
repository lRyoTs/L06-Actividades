using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int countdownNum = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("COUNTDOWN");
        Countdown();
    }

    private void Countdown() {
        for ( ;countdownNum >= 0 ; countdownNum--) {
            Debug.Log(countdownNum);
        }
    }
}
