using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PatternShape : MonoBehaviour
{
    private Transform Target;


    private void Start()
    {
        Target = GameObject.Find("Centre Point").transform;

        Vector3 dir  = Target.position - transform.position;
        dir.y = 0;

        transform.up = dir;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Target.transform);
        //this.gameObject.transform.rotation = Quaternion.Euler(90, -16.409f, -90);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Wall")
        {
            Object.Destroy(gameObject);
        }
    }
}
