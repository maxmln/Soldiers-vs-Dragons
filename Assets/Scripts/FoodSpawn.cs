using UnityEngine;
using System.Collections;

public class FoodSpawn : MonoBehaviour {
    public GameObject foodPrefab;
    private int returnedRandom;

    void Start()
    {
        returnedRandom = (int)(5 + 20 * Random.value);
        InvokeRepeating("Spawn", returnedRandom, returnedRandom);
    }
    void Spawn() {
        Vector3 randomPosition;
        if(Application.loadedLevelName=="PlayingTheGame"){
            randomPosition = new Vector3(Random.Range(0, 5), Random.Range(0, 5), 0);
        }
        else

        {
            randomPosition = new Vector3(Random.Range(0, 10), Random.Range(0, 8), 0);
        }
        Instantiate(foodPrefab, randomPosition, Quaternion.identity);
        
    }
}