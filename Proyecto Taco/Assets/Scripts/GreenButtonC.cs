using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButtonC : MonoBehaviour
{
    private SpriteRenderer buttonImage;
    public Sprite pressedButton;
    public AudioClip buttonPress;
    private AudioSource audioSource;

    private bool buttonPressed;
    public GameObject doorA;

    // Start is called before the first frame update
    void Start()
    {
        buttonImage = gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

        buttonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonImage.sprite = pressedButton;
        if (!buttonPressed)
        {
            audioSource.PlayOneShot(buttonPress);
            Destroy(doorA);
        }
        buttonPressed = true;
    }
}
