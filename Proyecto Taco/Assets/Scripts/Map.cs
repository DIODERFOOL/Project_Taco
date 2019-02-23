using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject mapElement;
    private bool showMap;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            showMap = !showMap;
            mapElement.SetActive(showMap);
        }
    }
}
