using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automovement : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] Sprite[] balloon;
    private Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        force = new Vector3(Random.Range(-10,10),Random.Range(15,25),0);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 1 * speed * Time.deltaTime);
    }
}