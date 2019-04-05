using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = gameObject.transform.position;
        position.y =  2.21f + 0.5f*Mathf.Cos(Time.time);
        gameObject.transform.position = position;
    }
}
