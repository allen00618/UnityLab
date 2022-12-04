using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] GameObject balloon;
    [SerializeField] AudioSource sound;
    [SerializeField] Animator balloonAnimator;
    [SerializeField] Score score;
    float maxSize = 1.6f, growthRate = 0.1f, scale = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        if(balloon == null)
        {
            balloon = GameObject.FindGameObjectWithTag("balloon");
        }
        if(sound == null)
        {
            sound = GetComponent<AudioSource>();
        }

        if(balloonAnimator == null)
        {
            balloonAnimator = GetComponent<Animator>();
        }

        balloonAnimator.SetBool("isPopped", false);

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale!=0f)
        {
            increaseSize();
        }
    }

    private void OnTriggerEnter2D (Collider2D other) 
    {
        if(other.gameObject.tag == "throwingKnife") 
        {
            if(scale<1f) 
            {
                score.AddScore();
            }
            if(scale>1f) 
            {
                score.AddTwoPoint();
            }
            AudioSource.PlayClipAtPoint(sound.clip, transform.position);
            balloonAnimator.SetBool("isPopped", true);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "topWall")
        {
            Destroy(this.gameObject);
        }
    }
    //void expiredTime()
    //{
      //  Destroy(balloon, 3f);
    //}
    void increaseSize()
    {
        transform.localScale = Vector3.one * scale;
        scale += growthRate * 0.01f;
        if(scale>maxSize)
        {
            resetSize();
        }
    }

    void resetSize()
    {
        scale = 0.4f;
    }
}
