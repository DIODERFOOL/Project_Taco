using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechHUDRoom : MonoBehaviour
{
    public GameObject playerSprite;
    public GameObject pinataTextCanvas;
    public GameObject taqueroTextCanvas;

    private bool showPinata;
    private bool showTaquero;

    public Text alternativePinata; 
    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        var position = playerSprite.transform.position;
        if(position.x >= 0 && position.x <= 5)
        {
            showPinata = true;
            pinataTextCanvas.SetActive(showPinata);
        }
        else if (position.x >= 50 && position.x <= 55)
        {
            showTaquero = true;
            taqueroTextCanvas.SetActive(showTaquero);
        }
        else if (position.x >= 60 && position.x <= 65)
        {
            showPinata = true;
            pinataTextCanvas.SetActive(showPinata);
            alternativePinata.text = "Adelante encontrarás el cenote sagrado. ¡Dicen que en sus profundidades uno puede cumplir cualquier deseo! Suerte, <b>Macho</b>.";
        }
        else
        {
            showPinata = false;
            showTaquero = false;
            pinataTextCanvas.SetActive(showPinata);
            taqueroTextCanvas.SetActive(showTaquero);
        }
    }
}
