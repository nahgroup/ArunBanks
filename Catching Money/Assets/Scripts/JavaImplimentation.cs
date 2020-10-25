using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;

public class JavaImplimentation : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Complete();

    [DllImport("__Internal")]
    private static extern void Started();

    // Start is called before the first frame update
    void Start()
    {
        Started();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color.a == 1)
        {
            Complete();
        }
    }

    void GetDepositValue(string Deposit)
    {
        Color temp;
        double Depo = double.Parse(Deposit);
        GameObject.Find("Score").GetComponent<FallingManager>().DepositAmount = Depo;
        GameObject.Find("Score").GetComponent<FallingManager>().notStarted = true;
        GameObject.Find("Score").GetComponent<Text>().text = "0";
        temp = GameObject.Find("Complete").GetComponent<SpriteRenderer>().color;
        temp.a = 0;
        GameObject.Find("Complete").GetComponent<SpriteRenderer>().color = temp;
    }
}
