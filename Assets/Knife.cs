using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] GameObject throwingKnifePrefab;
    [SerializeField] Vector3 throwingKnifeForce;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot() 
    {
        GameObject throwingKnife = Instantiate(throwingKnifePrefab, transform.position, transform.rotation);
        throwingKnife.GetComponent<Rigidbody2D>().AddForce(throwingKnifeForce);
        Destroy(throwingKnife, 1f);
    }
}
