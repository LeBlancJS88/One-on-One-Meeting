using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpace : MonoBehaviour
{

    public AudioSource yeeHaw;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!yeeHaw.isPlaying)
            {
                yeeHaw.Play();
            }
        }
    }
}