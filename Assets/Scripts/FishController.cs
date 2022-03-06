using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{
    public SpawnManager pond;
    private Transform destination;
    private float speed = 5.0f;
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
      pond = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
      if (isMoving == false) {
        int destIndex = Random.Range(0, pond.spawnPositions.Length);
        destination = pond.spawnPositions[destIndex];
        isMoving = true;
      }

      transform.position = Vector3.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);

      if (transform.position == destination.position) {
        isMoving = false;
      }
    }
}
