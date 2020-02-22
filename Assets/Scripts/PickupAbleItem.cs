using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupAbleItem : MonoBehaviour
{
    public Transform AdjustmentWhenHeld;
    public virtual void OnPickUp()
    {

    }

    public virtual void OnClick()
    {

    }

    public virtual void OnDrop()
    {

    }
}
