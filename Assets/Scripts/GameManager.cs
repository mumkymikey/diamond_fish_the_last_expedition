using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI fishCaughtText;
    private int fishCaught;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateFishCaught()
    {
      fishCaught += 1;
      fishCaughtText.text = "Fish Caught: " + fishCaught;
    }
}
