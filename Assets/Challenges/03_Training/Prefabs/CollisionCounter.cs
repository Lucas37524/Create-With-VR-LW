using UnityEngine;
using TMPro;

public class CollisionCounter : MonoBehaviour
{
    public TMP_Text counterText;
    public TMP_Text timerText; 
    private int counter = 0;
    private float timer = 0f;
    

    private void Start()
    {
        UpdateCounterText();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        UpdateTimerText(); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            counter++;
            UpdateCounterText();
        }
    }

    private void UpdateCounterText()
    {
        counterText.text = "" + counter;
    }

    private void UpdateTimerText()
    {
        timerText.text = "Time Played: " + timer.ToString("F2") + "s";
    }
}