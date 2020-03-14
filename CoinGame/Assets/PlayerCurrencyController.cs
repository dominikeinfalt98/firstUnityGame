using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrencyController : MonoBehaviour
{
    public CollectibleText text;
    private int coinCount;

    void Awake() {
        coinCount = 0;
        text.setCountText(coinCount);
    }

    public void increaseCoinCount(int count = 1) 
    {
        coinCount += count;
        text.setCountText(coinCount);
    }

    public int getCoinCount() 
    {
        return coinCount;
    }

}
