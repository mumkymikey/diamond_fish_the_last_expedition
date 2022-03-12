using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LureCollision : MonoBehaviour
{
    public SpawnManager pond;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
      pond = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
      manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision) {
      if (collision.gameObject.tag == "Fish") {
        Debug.Log("Fish caught!");
        Destroy(collision.gameObject);
        pond.currentFishCount -= 1;
        manager.UpdateFishCaught();
      }
    }
}
