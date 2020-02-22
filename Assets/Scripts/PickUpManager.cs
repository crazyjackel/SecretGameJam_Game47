using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public Camera guiCamera;
    public GameObject EmptyPosition;

    private static PickUpManager Instance;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public static PickUpManager GetInstance()
    {
        return Instance;
    }
}
