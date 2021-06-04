using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstac;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        //here 2 is spawn time of obstacles and 5 is after how much time it should b repeat spawn
        InvokeRepeating("Spawn", 2.0f, 5.0f);

        if (transform.position.x <= -11)
        {
            Destroy(this.gameObject);
        }
    }
    void Spawn()
    {
        int value = Random.Range(0, obstac.Length);
        Instantiate(obstac[value], transform.position, Quaternion.identity);

        
    }



    // Update is called once per frame
    void Update()
    {
       
    }
}
