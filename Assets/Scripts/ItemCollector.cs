using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int bananas = 0;

    [SerializeField] private Text bananasText;

    [SerializeField] private AudioSource collectionSoundEffect;

    //When the player interacts with the game object it plays an audio clip and is then removed from the game. 
    //The game then tracks how many bananas the player has got and is displayed on screen.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
           collectionSoundEffect.Play(); 
           Destroy(collision.gameObject);
           bananas++;
           bananasText.text = "Bananas: " + bananas;
        }
    }
}
