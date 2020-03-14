using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollectibleText : MonoBehaviour
{
    public Text coinCountText;

    public void setCountText(int coinCount)
    {
        coinCountText.text = coinCount.ToString() + "x";
    }
}
