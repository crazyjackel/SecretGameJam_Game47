using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class correct_Input : MonoBehaviour
{
    [SerializeField]
    private bool rPressed = false;
    [SerializeField]
    private bool ePressed = false;
    [SerializeField]
    private bool dPressed = false;
    [SerializeField]
    private bool aPressed = false;
    [SerializeField]
    private bool cPressed = false;
    [SerializeField]
    private bool tPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rPressed = true;
        }
        else
        {
            rPressed = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            ePressed = true;
        }
        else
        {
            ePressed = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dPressed = true;
        }
        else
        {
            dPressed = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            aPressed = true;
        }
        else
        {
            aPressed = false;
        }
        if (Input.GetKey(KeyCode.C))
        {
            cPressed = true;
        }
        else
        {
            cPressed = false;
        }
        if (Input.GetKey(KeyCode.T))
        {
            tPressed = true;
        }
        else
        {
            tPressed = false;
        }

        if(rPressed & ePressed & dPressed & aPressed & cPressed & tPressed)
        {
            SceneManager.LoadScene("platform test");
        }
    }
}
