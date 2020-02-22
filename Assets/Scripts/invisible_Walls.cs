using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_Walls : MonoBehaviour
{

    [SerializeField]
    private Material clear;

    [SerializeField]
    private Material opaque;

    [SerializeField]
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime/2;
        if (timer > 4)
        {
            this.GetComponent<MeshRenderer>().material = clear;
            timer = 0;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshRenderer>().material = opaque;
    }



}
