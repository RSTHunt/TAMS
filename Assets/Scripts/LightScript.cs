using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightScript : MonoBehaviour
{
    public GameObject Player;
    public Light lamp;
    public float TotalTime;
    private float MaxTime;
    private bool TimerStart;

    // Start is called before the first frame update
    void Start()
    {
        MaxTime = TotalTime;
    }

    private void Update()
    {
        if (TimerStart == true)
        {
            if (TotalTime > 0)
            {
                //Subtract elapsed time every frame
                TotalTime -= Time.deltaTime;
            }
            else
            {
                TotalTime = 0;
                SceneManager.LoadScene(3);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == Player)
        {
            lamp.enabled = true;
            TimerStart = false;
            TotalTime = MaxTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            lamp.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    { 
        if (other.gameObject == Player) 
        { 
            lamp.enabled = false;
            TimerStart = true;
        } 
    }
}
