using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource SoundToPlay;
    public BoxCollider HitDetector;
    // Start is called before the first frame update
    void Start()
    {
        HitDetector = this.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something Entered");
        if (SoundToPlay != null)
        {
            SoundToPlay.Play();
        }
      
    }

    private void OnTriggerExit(Collider other)
    {
        if (SoundToPlay != null)
        {
            SoundToPlay.Stop();
        }
    }
}
