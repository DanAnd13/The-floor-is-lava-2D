using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMusic : MonoBehaviour
{
    AudioSource victorySound;
    bool play;
    // Start is called before the first frame update
    void Start()
    {
        victorySound = GetComponent<AudioSource>();
        play = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1.804133f & play == false)
        {
            victorySound.Play();
        }
        play = victorySound.isPlaying ? true : false;
    }
}
