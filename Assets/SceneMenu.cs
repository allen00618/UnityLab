using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneMenu : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    [SerializeField] TextMeshProUGUI nameText;

    void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        nameText.text = PlayerPrefs.GetString("playerName");
        PlayerPrefs.SetString("playerName", nameText.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        nameText.text = playerNameInput.text;
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("playerName", nameText.text);
        Time.timeScale = 1f;
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}