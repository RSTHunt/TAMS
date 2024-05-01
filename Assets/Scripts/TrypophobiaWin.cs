using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrypophobiaWin : MonoBehaviour
{
    public GameObject Player;
    private float Speed = 10;
    public Rigidbody Cube;
    public bool Win;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != new Vector3(0, 0.62f, 0) && Win == true)
        {
            transform.position = new Vector3(0, 0.62f, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            SceneManager.LoadScene(0);
        }
    }
}
