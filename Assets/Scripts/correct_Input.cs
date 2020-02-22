using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class correct_Input : MonoBehaviour
{
    [SerializeField]
    private bool aPressed = false;
    [SerializeField]
    private bool tPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            aPressed = true;
        }
        else
        {
            aPressed = false;
        }
       
        if (Input.GetKey(KeyCode.T))
        {
            tPressed = true;
        }
        else
        {
            tPressed = false;
        }

        if(aPressed & tPressed)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
