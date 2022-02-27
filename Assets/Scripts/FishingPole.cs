using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingPole : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPos;
    public Quaternion playerRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      playerPos = player.transform.position;
      playerRotation = player.transform.rotation;
      transform.position = playerPos + new Vector3(0,2.1f,-1.2f);
      transform.rotation = playerRotation;
    }
}
