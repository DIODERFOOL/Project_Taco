using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechRoomFinal : MonoBehaviour
{
    public GameObject playerSprite;
    public GameObject machoTextCanvas;

    private bool showMachoSpeech;

    public Text dynamicSpeech; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var position = playerSprite.transform.position;
        if (position.x >= 58.5 && position.x <= 61)
        {
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "Has obtenido el primer tesoro del cenote de los dioses. Sigue buscando tesoros en la versión completa de <b>SANCHEZ: DIE TWICE COMING STEAM SUMMER 2020.</b>";
            GManagerC.instance.clearRoomC();
        }
        else
        {
            showMachoSpeech = false;
            machoTextCanvas.SetActive(showMachoSpeech);
        }
    }
}
