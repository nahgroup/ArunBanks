using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FallingManager : MonoBehaviour
{
    private int MinXValue;
    private int MaxXValue;
    public double OnScreen;
    private System.Random RandInt;
    private int RandRes;
    public double DepositAmount;
    private bool notStarted;
    private System.Single Frequencey;
    private Color ColorOfComplete;

    //Coins
    public GameObject[] money;

    // Start is called before the first frame update
    void Start()
    {
        MinXValue = -1940;
        MaxXValue = 1925;
        RandInt = new System.Random();
        notStarted = true;
        Frequencey = 0.5f;
        ColorOfComplete = Color.white;
        ColorOfComplete.a = 0;
        GameObject.Find("Complete").GetComponent<SpriteRenderer>().color = ColorOfComplete;
    }

    // Update is called once per frame
    void Update()
    {
        if(DepositAmount - Convert.ToDouble(gameObject.GetComponent<Text>().text) > 0 && notStarted)
        {
            InvokeRepeating("ChooseCoin", 2f, Frequencey);
            notStarted = false;
        }
        if (DepositAmount - Convert.ToDouble(gameObject.GetComponent<Text>().text) == 0)
        {
            ColorOfComplete.a = 1;
            GameObject.Find("Complete").GetComponent<SpriteRenderer>().color = ColorOfComplete;
        }
    }

    void SpawnCoin(GameObject Money, Vector3 Position)
    {
        //Instanate Object
        Instantiate(Money, Position, Quaternion.identity);
        OnScreen += Money.GetComponent<Falling>().value;
    }

    private void ChooseCoin()
    {
        Vector3 Position = new Vector3();
        double totalLeft;
        Position.x = RandInt.Next(MinXValue, MaxXValue);
        Position.y = 837;
        Position.z = 0;
        RandRes = RandInt.Next(1, 100);
        totalLeft = DepositAmount - OnScreen - Convert.ToDouble(gameObject.GetComponent<Text>().text);
        //Scale
        if (totalLeft > 500) //Over 500
        {
            if(RandRes <= 20)
            {
                SpawnCoin(money[11], Position);
            }
            else if (RandRes <= 50)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 75)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 95)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 99)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if(totalLeft > 100) //Over 100
        {
            if (RandRes <= 10)
            {
                SpawnCoin(money[11], Position);
            }
            else if (RandRes <= 20)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 95)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 75) //Over 75
        {
            if (RandRes <= 5)
            {
                SpawnCoin(money[11], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 55)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 95)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 50) //Over 50
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[11], Position);
            }
            else if (RandRes <= 10)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 20)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 50)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 75)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 95)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 25) //Over 25
        {
            if (RandRes <= 5)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 10)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 35)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 45)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 55)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 20) //Over 20
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[10], Position);
            }
            else if (RandRes <= 10)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 35)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 45)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 55)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 10) //Over 10
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[9], Position);
            }
            else if (RandRes <= 10)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 20)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 5) //Over 5
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[8], Position);
            }
            else if (RandRes <= 10)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 20)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 2) //Over 2
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[7], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 90)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 1) //Over 1
        {
            if (RandRes <= 1)
            {
                SpawnCoin(money[6], Position);
            }
            else if (RandRes <= 15)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 30)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 45)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 65)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 85)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0.50) //Over 50p
        {
            if (RandRes <= 5)
            {
                SpawnCoin(money[5], Position);
            }
            else if (RandRes <= 20)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 60)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 80)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0.20) //Over 20p
        {
            if (RandRes <= 5)
            {
                SpawnCoin(money[4], Position);
            }
            else if (RandRes <= 25)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 50)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 75)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0.10) //Over 10p
        {
            if (RandRes <= 10)
            {
                SpawnCoin(money[3], Position);
            }
            else if (RandRes <= 40)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0.05) //Over 5p
        {
            if (RandRes <= 30)
            {
                SpawnCoin(money[2], Position);
            }
            else if (RandRes <= 70)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0.02) //Over 2p
        {
            if (RandRes <= 50)
            {
                SpawnCoin(money[1], Position);
            }
            else if (RandRes <= 100)
            {
                SpawnCoin(money[0], Position);
            }
        }
        else if (totalLeft > 0) //1p
        {
            SpawnCoin(money[0], Position);
        }
    }
}
