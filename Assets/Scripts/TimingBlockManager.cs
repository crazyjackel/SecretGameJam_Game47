using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingBlockManager : MonoBehaviour
{
    public static TimingBlockManager Instance;

    private List<TimingDisableBlock> blocks = new List<TimingDisableBlock>();
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

    public static TimingBlockManager GetInstance()
    {
        return Instance;
    }

    public void AddTimingBlock(TimingDisableBlock block)
    {
        blocks.Add(block);
    }

    bool previous;
    bool onOff = true;
    void Update()
    {
        if (previous != GameManager.GetInstance().movement.IsGrounded && !GameManager.GetInstance().movement.IsGrounded)
        {
            onOff = !onOff;
            foreach (TimingDisableBlock block in blocks)
            {
                block.gameObject.SetActive(onOff);
            }
        }

        previous = GameManager.GetInstance().movement.IsGrounded;

    }
}
