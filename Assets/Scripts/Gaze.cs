using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{

    public Image imgGaze;

    public float totalTime = 2f;

    bool gazeStatus;
    float gazeTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gazeStatus)
        {
            gazeTimer += Time.deltaTime;
            imgGaze.fillAmount = gazeTimer / totalTime;
        }
    }

    public void GazeOn()
    {
        gazeStatus = true;
    }

    public void GazeOff()
    {
        gazeStatus = false;
        gazeTimer = 0f;
        imgGaze.fillAmount = 0f;
    }
}
