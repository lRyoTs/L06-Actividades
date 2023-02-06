using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int countdownNum = 10;
    // Start is called before the first frame update
    void Start()
    {
        Countdown();
    }

    private void Countdown() {
        Debug.Log("COUNTDOWN");
        for ( ;countdownNum >= 0 ; countdownNum--) {
            StartCoroutine(WaitTime());
            Debug.Log(countdownNum);
        }
    }

    private IEnumerator WaitTime() {
        yield return new WaitForSeconds(3);
    }
}
