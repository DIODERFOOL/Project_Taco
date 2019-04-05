using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    public GameObject doorA;

    private bool doorAOpened;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject); //So only one Game Manager can exist at a time.
        }
        doorAOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoorA()
    {
        Debug.Log("Opening door A");
        Destroy(doorA);
        doorAOpened = true;
    }

    public bool getDoorAStatus()
    {
        return doorAOpened;
    }
}
