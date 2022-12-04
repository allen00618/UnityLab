using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] Slider volume;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 1);
            Load();
        }
        else 
        {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeVolume()
    {
        AudioListener.volume = volume.value;
    }

    private void Load()
    {
        volume.value = PlayerPrefs.GetFloat("volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", volume.value);
    }
}
