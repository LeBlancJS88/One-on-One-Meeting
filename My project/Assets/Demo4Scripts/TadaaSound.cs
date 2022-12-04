using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TadaaSound : MonoBehaviour
{
    public AudioSource tadaa;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Cube"))
        {
            tadaa.Play();
        }
    }
}
