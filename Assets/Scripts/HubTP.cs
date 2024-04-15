using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubTP : MonoBehaviour
{
    public GameObject ClaustroTP;
    public GameObject AcroTP;
    public GameObject NyctoTP;
    public GameObject TrypoTP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ClaustroTP)
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject == AcroTP)
        {
            SceneManager.LoadScene(2);
        }

        if (other.gameObject== NyctoTP)
        {
            SceneManager.LoadScene(3);
        }
    }
}
