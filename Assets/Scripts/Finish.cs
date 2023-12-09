using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    //When player collides with the checkpoint it finishes the level it gets the audio file for completing level and plays it

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    //When level is completed it looks for the next scene to play
    private void CompleteLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
