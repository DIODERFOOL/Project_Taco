using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject mapElement;
    public GameObject miniMapElement;
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
            miniMapElement.SetActive(!showMap);
        }
    }
}
