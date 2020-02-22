using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingDisableBlock : MonoBehaviour
{
    public void Start()
    {
        TimingBlockManager.GetInstance().AddTimingBlock(this);
    }
    
}
