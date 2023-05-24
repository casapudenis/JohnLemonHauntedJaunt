using UnityEngine;
using UnityEngine.UI;

public class SpentSeconds : MonoBehaviour
{
    public Text timeText;
    void Update()
    {
        float spentSeconds = Time.time;
        timeText.text = "Spent Seconds: " + spentSeconds.ToString("F2");
    }
}