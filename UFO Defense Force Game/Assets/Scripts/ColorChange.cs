using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color startColor = Color.red;
    public Color endColor = Color.yellow;
    [Range(0,10)]
    public float speed = 4;

    Renderer ren;

    void Awake()
    {
        // accessing pickup's renderer
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // changing color of pickup. Lerp finds midway point of colors, Mathf.PingPong goes between colors
        ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
