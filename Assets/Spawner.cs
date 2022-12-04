using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3.5f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Vector2 position = new Vector2(Random.Range(-10,10), Random.Range(-3, 3));
        Instantiate(balloon, position, Quaternion.identity);
    }
}
