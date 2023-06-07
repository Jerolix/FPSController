using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{

    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform objectGrabPointTransform;


    private ObjectGrabbable objectGrabbable;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabbable == null)

            { //Not carrying object, try to grab object
                float pickUpDistance = 2f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask))
                    Debug.Log(raycastHit.transform);

                if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                {
                    objectGrabbable.Grab(objectGrabPointTransform);
                    Debug.Log(objectGrabbable);
                }
            } 
            else
            {
                // Currently carrying something, drop object
                objectGrabbable.Drop();
                objectGrabbable = null;
            }
        }    
    }
}
