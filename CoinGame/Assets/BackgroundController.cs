using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public GameObject player;
    private float scrollSpeed = 5.5f;

    void Update()
    {
         Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
         GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
