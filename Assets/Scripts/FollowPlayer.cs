using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(-3, 4, 0);
    public Vector3 playerPos;
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      playerPos = player.transform.position;
      transform.position = playerPos + (-player.transform.forward * offset.magnitude) + offset;
      transform.LookAt(player.transform);
    }
}
