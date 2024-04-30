using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PatternGeneration1 : MonoBehaviour
{
    public GameObject pattern;
    private bool generate = true;
    public int counter;
    private int spawned;
    private TrypophobiaWin Win;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPattern", 0.5f, 0.5f);
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

    void SpawnPattern()
    {
        if (generate == true)
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-7.65f, 7.7f), Random.Range(-0.62f, 0.63f), Random.Range(-7.65f, 7.7f));
            Instantiate(pattern, RandomSpawnPosition, Quaternion.identity);
            spawned++;
        }
    }
}
