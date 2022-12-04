using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 0;
    public int level = 0;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI nameText;
    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        //score = PersistentData.Instance.GetScore();
        //playerName = PersistentData.Instance.GetName();
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        score = PlayerPrefs.GetInt("score");
        level = SceneManager.GetActiveScene().buildIndex;
        levelText.text = "Level " + level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
        if(score >= 10)
        {
            AdvanceLevel();
        }
    }

    public void AddTwoPoint()
    {
        score += 2;
    }

    public void AdvanceLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void resetGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    public void DisplayName()
    {
        nameText.text = "Player: " + playerName;
    }
}

