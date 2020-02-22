using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingDisableBlock : MonoBehaviour
{
    public void Start()
    {
        TimingBlockManager.GetInstance().AddTimingBlock(this);
    }
    bool previous;
    void Update()
    {
        if (previous != GameManager.GetInstance().movement.IsGrounded)
        {
            this.enabled = !this.enabled;
        }
                
        previous = GameManager.GetInstance().movement.IsGrounded;

    }
}
