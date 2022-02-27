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
      // transform.position = player.transform.position + offset;
      transform.position = playerPos + (-player.transform.forward * offset.magnitude) + offset;
      // float x = 0.1999993f;
      // float z = 58.7f;
      // transform.position = new Vector3(x, transform.position.y, z);
      transform.LookAt(player.transform);
      // transform.rotation = player.transform.rotation * Quaternion.Inverse();
      // transform.rotation = Quaternion.Slerp(transform.rotation, player.transform.rotation * rotationOffset, Time.deltaTime * turnSpeed);
      // transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position);
    }
}
