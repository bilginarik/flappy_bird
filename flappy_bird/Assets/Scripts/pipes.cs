using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    void Start()
    {
        float rnd = Random.Range(-2.25f,1.5f);
        transform.position = new Vector3(3.75f, rnd, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -3.80f)
        {
            Destroy(gameObject);
        }
        transform.Translate(-0.8f * Time.deltaTime, 0, 0);
        
    }
}
