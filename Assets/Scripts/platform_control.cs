using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_control : MonoBehaviour
{
    [SerializeField]
    private GameObject[] platforms;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < platforms.Length; i++)
        {
            if(i % 2 == 0)
            {
                platforms[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                if (i % 2 == 1)
                {
                    platforms[i].SetActive(false);
                }
                else
                {
                    platforms[i].SetActive(true);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                if (i % 2 == 0)
                {
                    platforms[i].SetActive(false);
                }
                else
                {
                    platforms[i].SetActive(true);
                }
            }
        }
    }
}
