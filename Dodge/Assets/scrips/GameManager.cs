using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timetext;
    public Text bestTimeText;

    private float s_time;
    private bool IsGameOver;

    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
        s_time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGameOver)
        {
            s_time = s_time + Time.deltaTime;

            timetext.text = "TIME : " + (int)s_time;
        }
        else
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }

            if (Input.GetKey(KeyCode.Q))
            {
                Application.Quit();
            }
        }
    }

    public void Endgame()
    {
        IsGameOver = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (bestTime < s_time)
        { 
            bestTime = s_time;

            PlayerPrefs.GetFloat("BestTime", bestTime);
        }

        bestTimeText.text = "Besttime : " + (int)bestTime;
    }
}
