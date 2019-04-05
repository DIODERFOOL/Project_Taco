using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverV2 : MonoBehaviour
{
    public float hoverIntensity;
    // Start is called before the first frame update
    void Start()
    {
        hoverIntensity = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        var position = gameObject.transform.position;
        position.y =  position.y + hoverIntensity*Mathf.Cos(Time.time);
        gameObject.transform.position = position;
    }
}
