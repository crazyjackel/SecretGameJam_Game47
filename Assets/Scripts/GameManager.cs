using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public Camera MainCamera;
    public PlayerMovement movement;
    public PlayerCamera PlayerCamera;

    private static GameManager Instance = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public static GameManager GetInstance()
    {
        return Instance;
    }
}
