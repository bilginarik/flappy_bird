using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner : MonoBehaviour
{
    public GameObject pipe;
    void Start()
    {
        InvokeRepeating("add_pipe", 0.0f, 4.0f);
    }
    void add_pipe()
    {
        GameObject new_pipe = Instantiate(pipe);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
