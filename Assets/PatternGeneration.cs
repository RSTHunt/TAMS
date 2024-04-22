using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternGeneration : MonoBehaviour
{
    public GameObject pattern;
    private bool generate = true;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPattern", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 35)
        {
            generate = false;
        }
    }

    void SpawnPattern()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-7.65f, 7.7f), 0, Random.Range(-7.65f, 7.7f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
        }
    }
}
