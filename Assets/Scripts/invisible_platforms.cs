using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_platforms : MonoBehaviour
{
    [SerializeField]
    private GameObject[] platforms;

    [SerializeField]
    private Material clear;

    [SerializeField]
    private Material green;

    [SerializeField]
    private Material blue;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            if (i % 2 == 1)
            {
                platforms[i].GetComponent<MeshRenderer>().material = clear;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                if (i % 2 == 1)
                {
                    platforms[i].GetComponent<MeshRenderer>().material = clear;
                }
                else
                {
                    platforms[i].GetComponent<MeshRenderer>().material = green;
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                if (i % 2 == 0)
                {
                    platforms[i].GetComponent<MeshRenderer>().material = clear;
                }
                else
                {
                    platforms[i].GetComponent<MeshRenderer>().material = blue;
                }
            }
        }
    }
}
