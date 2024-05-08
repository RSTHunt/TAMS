using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallMovement : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Cube;
    public float WallSpeed;
    public float TotalTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Wall1.transform.position = Vector3.MoveTowards(Wall1.transform.position, Cube.transform.position, WallSpeed);
        Wall2.transform.position = Vector3.MoveTowards(Wall2.transform.position, Cube.transform.position, WallSpeed);
        Wall3.transform.position = Vector3.MoveTowards(Wall3.transform.position, Cube.transform.position, WallSpeed);
        Wall4.transform.position = Vector3.MoveTowards(Wall4.transform.position, Cube.transform.position, WallSpeed);

        if (TotalTime > 0)
        {
            //Subtract elapsed time every frame
            TotalTime -= Time.deltaTime;
        }
        else
        {
            TotalTime = 0;
            SceneManager.LoadScene(0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Wall1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
