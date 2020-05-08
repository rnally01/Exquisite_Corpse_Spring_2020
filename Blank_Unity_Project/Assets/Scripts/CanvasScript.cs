using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public Text coinAmount;
    private GameObject[] coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");

        if (coins.Length == 5)
        {
            coinAmount.text = "x0";
        }
        if (coins.Length == 4)
        {
            coinAmount.text = "x1";
        }
        if (coins.Length == 3)
        {
            coinAmount.text = "x2";
        }
        if (coins.Length == 2)
        {
            coinAmount.text = "x3";
        }
        if (coins.Length == 1)
        {
            coinAmount.text = "x4";
        }
        if (coins.Length == 0)
        {
            coinAmount.text = "x5";
        }
    }
}
