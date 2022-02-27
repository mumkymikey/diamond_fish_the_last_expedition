using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 30f;
    private float horizontalInput, forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // transform.position += transform.rotation * new Vector3(0, 0, forwardInput) * speed * Time.deltaTime;
        // transform.rotation *= Quaternion.Euler(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
