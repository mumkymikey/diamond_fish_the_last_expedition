using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bobber;
    public GameObject lure;
    public ParticleSystem splash;
    private Vector3 bobberPosition, lurePosition;
    private Vector3 playerDirection, playerVertical;
    public float speed = 10f;
    public float lureSpeed = 2f;
    public float rotationSpeed = 30f;
    private float horizontalInput, forwardInput;
    private bool isLineCast = false;

    // Start is called before the first frame update
    void Start()
    {
      bobber = this.gameObject.transform.GetChild(2).gameObject;
      lure = this.gameObject.transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void LateUpdate()
    {
      if (isLineCast == false) {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
      } else {
        CatchFish();
      }

      if (Input.GetKeyDown(KeyCode.F)) {
        if (isLineCast == false) {
          playerDirection = this.gameObject.transform.forward;
          playerVertical = this.gameObject.transform.up;
          bobberPosition = bobber.transform.position;
          lurePosition = lure.transform.position;

          bobber.transform.position += (playerDirection * 25) + (playerVertical * -5);
          lure.transform.position += (playerDirection * 25) + (playerVertical * -5);
          isLineCast = true;

          // splash.transform.position = bobber.transform.position;
          // splash.Play();
        } else {
          bobber.transform.position = bobberPosition;
          lure.transform.position = lurePosition;
          isLineCast = false;
        }
      }
    }

    void CatchFish() {
      lure.transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
    }
}
