using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeyAndDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject door;
    private GameObject key;
    bool doorOpened;

    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<KeyAndDoor>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            if (doorOpened == false)
            {
                door.SetActive(false);
                doorOpened = true;
                Object.Destroy(key);
            }
        }
    }
}
