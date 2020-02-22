﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_Walls : MonoBehaviour
{
    [SerializeField]
    private GameObject[] platforms;

    [SerializeField]
    private Material clear;

    [SerializeField]
    private Material green;

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
        this.GetComponent<MeshRenderer>().material = green;
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = clear;
    }


}
