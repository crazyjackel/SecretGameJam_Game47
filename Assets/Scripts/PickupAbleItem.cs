﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupAbleItem : MonoBehaviour
{
    public Vector3 Offset, Rotation, Scale;

    private Vector3 origScale;
    
    public virtual void OnPickUp()
    {
        Debug.Log("Pickup");
        this.transform.parent = PickUpManager.GetInstance().guiCamera.transform;
        this.transform.position = PickUpManager.GetInstance().EmptyPosition.transform.position;
        this.transform.position += this.Offset;
        this.transform.rotation = Quaternion.Euler(Rotation);
        origScale = this.transform.localScale;
        this.transform.localScale = this.Scale;


        Rigidbody rb = this.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.detectCollisions = false;
            rb.useGravity = false;
            rb.freezeRotation = true;
            rb.velocity = Vector3.zero;
        }
    }

    public virtual void OnClick()
    {

    }

    public virtual void OnClickHeld()
    {

    }

    public virtual void OnClickRelease()
    {

    }

    public virtual void OnDrop()
    {
        Debug.Log("Drop");
        this.transform.parent = null;
        this.transform.position = GameManager.GetInstance().MainCamera.transform.position + GameManager.GetInstance().MainCamera.transform.forward + GameManager.GetInstance().MainCamera.transform.right;

        this.transform.localScale = origScale;

        Rigidbody rb = this.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.detectCollisions = true;
            rb.useGravity = true;
            rb.velocity = 2*GameManager.GetInstance().MainCamera.transform.forward + GameManager.GetInstance().Player.GetComponent<PlayerMovement>().Velocity;
            rb.freezeRotation = false;
        }
    }
}
