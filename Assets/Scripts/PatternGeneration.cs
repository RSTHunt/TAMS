using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatternGeneration : MonoBehaviour
{
    public GameObject pattern;
    private bool generate = true;
    public int counter;
    private int spawned;
    private TrypophobiaWin Win;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPattern1", 0.5f, 0.75f);
        InvokeRepeating("SpawnPattern2", 0.66f, 0.75f);
        InvokeRepeating("SpawnPattern3", 0.87f, 0.75f);
        InvokeRepeating("SpawnPattern4", 0.25f, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 50)
        {
            generate = false;
            Win.Win = true;
        }
        if (spawned == 100)
        {
            SceneManager.LoadScene(4);
        }
    }

    void SpawnPattern1()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-5.62f, 5.39f), Random.Range(1f, 3f), Random.Range(-12.162f, -9.81f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern2()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-13.25f, -9.31f), Random.Range(0.81f, 2.82f), Random.Range(-6.398f, 5.29f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern3()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(9.935f, 13.176f), Random.Range(0.81f, 2.82f), Random.Range(-6.33f, 4.59f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern4()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-4.12f, 6.04f), Random.Range(-1.26f, 1.88f), Random.Range(11.87f, 15.06f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }
}
