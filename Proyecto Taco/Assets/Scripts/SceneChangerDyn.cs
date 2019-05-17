using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerDyn : MonoBehaviour
{
    public string levelToLoad;
    public string levelToLoadB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GManagerC.instance.getRoomStatus() == 0)
            {
                SceneManager.LoadScene(levelToLoad);
            }
            else
            {
                SceneManager.LoadScene(levelToLoadB);
            }
        }
    }
}
