using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }

   // public void Introduction()
    //{
     //   SceneManager.LoadScene("Introduction");
    //}

    //public void Setting()
    //{
      //  SceneManager.LoadScene("Setting");
    //}
}
