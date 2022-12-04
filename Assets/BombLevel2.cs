using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BombLevel2 : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] Animator deathAnimator;
    [SerializeField] Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 6f, 7.5f);

        if(deathAnimator == null)
        {
            deathAnimator = GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(bomb, 6f);
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
}
