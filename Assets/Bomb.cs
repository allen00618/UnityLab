using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] Animator deathAnimator;
    [SerializeField] Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 10f, 10f);

        if(deathAnimator == null)
        {
            deathAnimator = GetComponent<Animator>();
        }

        restartButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(bomb, 15f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "throwingKnife")
        {
            Destroy(gameObject);
            deathAnimator.SetBool("isDead", true);
            restartButton.gameObject.SetActive(true);
            StopTime();
        }
    }

    public void Spawn()
    {
        Vector2 position = new Vector2(Random.Range(-12,12), Random.Range(10,12));
        Instantiate(bomb, position, Quaternion.identity);
    }

    public void StopTime()
    {
        Time.timeScale = 0f;
    }

    /*public void increaseSpawn()
    {
        if(SceneManager.LoadScene())
        {
            InvokeRepeating("Spawn", 7.5f, 7.5f);
        }
        if(level.score=3)
        {
            InvokeRepeating("Spawn", 5f, 5f);
        }
    }*/
}
