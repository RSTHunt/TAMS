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
        InvokeRepeating("SpawnPattern1", 0.5f, 0.5f);
        InvokeRepeating("SpawnPattern2", 0.66f, 0.5f);
        InvokeRepeating("SpawnPattern3", 0.87f, 0.5f);
        InvokeRepeating("SpawnPattern4", 0.25f, 0.5f);
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
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-6.73f, 5.42f), Random.Range(1, 3), Random.Range(6.08f, 6.866f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern2()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(1, 3), Random.Range(-4.874f, -4.666f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern3()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(10.91f, 11.17f), Random.Range(1, 3), Random.Range(-7.76f, 2.23f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }

    void SpawnPattern4()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-4.1f, -4.29f), Random.Range(1, 3), Random.Range(-6.84f, 2.74f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }
}
