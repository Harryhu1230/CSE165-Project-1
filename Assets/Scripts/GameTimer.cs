using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    float timer;
    string timer_string;

    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameEnded == false)
        {
            timer += Time.deltaTime;
        }

        timer_string = timer.ToString("0");

        timeText.text = $"Game Over! \n You have survived for \n {timer_string} seconds!";
    }
}
