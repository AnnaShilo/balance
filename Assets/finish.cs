﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public Transform startpos;
    public Vector3 gravity_vector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Physics.gravity = gravity_vector;
        other.gameObject.transform.position = startpos.transform.position;
    }
}
