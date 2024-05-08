using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PatternShape : MonoBehaviour
{
    private Transform Target;
    private PatternGeneration counterAccess;
    private GameObject CounterObject;

    private void Start()
    {
        Target = GameObject.Find("CentrePoint").transform;

        Vector3 dir = Target.position - transform.position;
        dir.y = 0;

        transform.up = dir;
        counterAccess = CounterObject.GetComponent<PatternGeneration>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Wall")
        {
            Object.Destroy(gameObject);
            counterAccess.counter++;
        }
    }
}
