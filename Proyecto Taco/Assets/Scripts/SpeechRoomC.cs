using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechRoomC : MonoBehaviour
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
        if (position.x >= 57 && position.x <= 61 && position.y >= 22 && position.y <= 26)
        {
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "¡He obtenido la <b>SALSA ROJA</b>! ¡Este <b>PICANTE</b> da una energía <b>INIGUALABLE</b>! <i> Presiona <b> V </b> para realizar un fuerte ataque de corto alcance. Sirve para romper <b>lianas y puertas atoradas</b>!</i>";
        }
        else
        {
            showMachoSpeech = false;
            machoTextCanvas.SetActive(showMachoSpeech);
        }
    }
}
