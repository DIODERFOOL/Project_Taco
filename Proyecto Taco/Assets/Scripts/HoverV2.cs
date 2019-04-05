using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverV2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = gameObject.transform.position;
        position.y =  position.y + 0.005f*Mathf.Cos(Time.time);
        gameObject.transform.position = position;
    }
}
