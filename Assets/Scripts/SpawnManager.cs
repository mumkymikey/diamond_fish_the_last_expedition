using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject fish;
    public Transform[] spawnPositions;
    public int currentFishCount = 0;
    private int totalFishCount = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentFishCount < totalFishCount) {
          SpawnFish();
        }
    }

    void SpawnFish() {
      int spawnIndex = Random.Range(0, spawnPositions.Length);
      Instantiate(fish, spawnPositions[spawnIndex].position, fish.transform.rotation);
      currentFishCount += 1;
    }
}
