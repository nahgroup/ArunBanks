using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FallingManager : MonoBehaviour
{
    private float MinXValue;
    private float MaxXValue;
    public double OnScreen;

    // Start is called before the first frame update
    void Start()
    {
        MinXValue = -1940;
        MaxXValue = 1925;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCoin(GameObject Money, Vector3 Position)
    {
        //Instanate Object
        Instantiate(Money, Position, Quaternion.identity);
        OnScreen += Money.GetComponent<Falling>().value;
    }

    private void ChooseCoin(float DepositAmount)
    {
        //Scale
        if(DepositAmount - OnScreen - Convert.ToDouble(gameObject.GetComponent<Text>().text) > 100)
        {

        }
    }
}
