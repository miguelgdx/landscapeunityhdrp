using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public float health = 100;
    public float lastHitTime = 0;
    public float timeBetweenHits = 2;
    public Text healthText;
    public Text timeText;
    public float currentGameTime = 0;
    public float startTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        InvokeRepeating("showStats", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        currentGameTime = Time.time - startTime;
    }

    private void showStats()
    {
        healthText.text = "Health: " + health;
        timeText.text = "Time: " + Mathf.RoundToInt(currentGameTime);
    }

    public void DoDamage(float amount)
    {
        if (Time.time - lastHitTime > timeBetweenHits)
        {
            lastHitTime = Time.time;
            health -= amount;
            if (health <= 0)
            {
                health = 0;
                GameData.playerWon = false;
                SceneManager.LoadScene("End", LoadSceneMode.Single);
            }
        }
    }
}
