using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    public GameObject player;
    public LayerMask layer;

    public PickupAbleItem heldItem = null;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        mouseLook.y = Mathf.Clamp(mouseLook.y, -85f, 85f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.rotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);

        //Does the Pickup and Drop System
        if (Input.GetKeyDown(KeyCode.E) && heldItem == null)
        {
            Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit, 10.0f, layer);
            if (hit.collider != null)
            {
                PickupAbleItem item = hit.collider.gameObject.GetComponent<PickupAbleItem>();
                if (item != null)
                {
                    heldItem = item;
                    heldItem.OnPickUp();
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            heldItem.OnDrop();
        }

        if (Input.GetMouseButtonDown(0) && heldItem != null)
        {
            heldItem.OnClick();
        }
    }
}
