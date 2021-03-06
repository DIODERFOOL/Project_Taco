﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManagerC : MonoBehaviour
{
    public static GManagerC instance = null;

    private int roomStatus;
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
        roomStatus = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clearRoomC()
    {
        roomStatus = 1;
    }

    public int getRoomStatus()
    {
        return roomStatus;
    }
}
