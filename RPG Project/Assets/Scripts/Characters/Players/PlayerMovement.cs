using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform objectToPlace;
    public Camera camera;
    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerMask)) {
            print(hitInfo.collider.gameObject.name);
            objectToPlace.position = hitInfo.point;
            objectToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }
}
