using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private bool Active = false;
    public GameObject Player;
    private Light lamp;
    // Start is called before the first frame update
    void Start()
    {
        lamp = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Active == true)
        {
            lamp.enabled = true;
        }
    }

    private void OnTriggerOverlap(Collider other)
    {
        if (Active == false && other == Player)
        {
            Active = true;
        }
    }
}
