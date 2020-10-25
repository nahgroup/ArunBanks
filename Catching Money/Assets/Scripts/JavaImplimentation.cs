using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;

public class JavaImplimentation : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Complete();

    // Start is called before the first frame update
    void Start()
    {
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
        double Depo = double.Parse(Deposit);
        GameObject.Find("Score").GetComponent<FallingManager>().DepositAmount = Depo;
    }
}
