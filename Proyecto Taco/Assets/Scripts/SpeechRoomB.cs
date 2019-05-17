using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechRoomB : MonoBehaviour
{
    public GameObject playerSprite;
    public GameObject machoTextCanvas;

    private bool showMachoSpeech;

    //private bool mainDoorLocked;
    private bool door2Locked;

    public Text dynamicSpeech; 
    // Start is called before the first frame update
    void Start()
    {
        //mainDoorLocked = true;
        door2Locked = true;
    }

    // Update is called once per frame
    void Update()
    {
        var position = playerSprite.transform.position;
        if (position.x >= 157 && position.x <= 161 && position.y >= 34 && position.y <= 39 && !(GManager.instance.getDoorAStatus()))
        {
            //Text on locked door
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "Hmm, esta puerta está cerrada con llave. Debería de haber una forma de abrirla por aquí...";
        }
        else if (position.x >= 157 && position.x <= 161 && position.y >= 34 && position.y <= 39 && GManager.instance.getDoorAStatus())
        {
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "Huh, ese botón verde debió abrir esta puerta!";
        }
        else if (position.x >= 157 && position.x <= 161 && position.y >= 24 && position.y <= 29 && door2Locked)
        {
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "Esta puerta está atorada! Si tan solo hubiera una forma de <b>romper</b> todas estas plantas...";
        }
        else if (position.x >= 215 && position.x <= 218 && position.y >= 22 && position.y <= 24)
        {
            showMachoSpeech = true;
            machoTextCanvas.SetActive(showMachoSpeech);
            dynamicSpeech.text = "¡He obtenido la <b>SALSA VERDE</b>! ¡El poder del <b>CHIPOTLE</b> fluye en mis venas! <i>Presiona <b>C</b> para realizar un ataque a distancia.</i>";
        }
        else
        {
            showMachoSpeech = false;
            machoTextCanvas.SetActive(showMachoSpeech);
        }
    }
}
