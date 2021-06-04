using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RepeatBackground : MonoBehaviour
{
    Material bMat;
    public float xoffset;
    // Start is called before the first frame update
    void Start()
    {
        bMat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        bMat.mainTextureOffset = new Vector2(xoffset*Time.time, 0);
    }
}
