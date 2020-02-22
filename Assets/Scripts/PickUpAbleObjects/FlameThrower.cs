using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : PickupAbleItem
{
    public float cooldown = 3.0f;
    public float inhitor = 17.0f;
    private float timeSinceClick = 0.0f;

    [SerializeField]
    private float VelocityScalar = 0.0f;
    private bool doThrower =false;
    public override void OnClick()
    {
        if (timeSinceClick >= cooldown)
        {
            VelocityScalar = 6.0f;
            timeSinceClick = 0.0f;
        }
    }
    public override void OnClickHeld()
    {
        Debug.Log("Held");
        doThrower = true;
    }

    public override void OnClickRelease()
    {
        Debug.Log("Released");
        doThrower = false;
    }

    public void Update()
    {
        timeSinceClick += Time.deltaTime;
        VelocityScalar -= Time.deltaTime * 3;


        if (VelocityScalar > 0.0f && doThrower)
        { 
            Vector3 velocity2 = -GameManager.GetInstance().MainCamera.transform.forward * VelocityScalar / inhitor;
            GameManager.GetInstance().movement.Velocities[0] = new Vector3(velocity2.x*inhitor,velocity2.y,velocity2.z*inhitor);
        }
        else
        {
            GameManager.GetInstance().movement.Velocities[0] = Vector3.zero;
        }
    }
}
