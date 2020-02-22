using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowbar : PickupAbleItem
{
    public override void OnPickUp()
    {
        this.transform.parent = PickUpManager.GetInstance().guiCamera.transform;
        this.transform.position = PickUpManager.GetInstance().EmptyPosition.transform.position;
        this.transform.position += this.AdjustmentWhenHeld.position;
        this.transform.rotation = this.AdjustmentWhenHeld.rotation;
        this.transform.localScale = this.AdjustmentWhenHeld.localScale;
    }

}

