using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollowNew : MonoBehaviour
{
    public float camPosX = 0f;
    public float camPosY = 2f;
    public float camPosZ = 1f;
    float camRotationX = 5;
    float camRotationY = 5;
    float camRotationZ = 5;
    public float turnSpeed = 1;
    public Vector3 offset;
    public Vector3 abovePlayer = new Vector3(25, 25, 25);

    public Transform player;
    private void Start()
    {
        //offset = new Vector3(player.position.x + camPosX, player.position.y + camPosY, player.position.z + camPosZ);
        transform.rotation = Quaternion.Euler(camRotationX, camRotationY, camRotationZ);
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        abovePlayer = new Vector3(player.position.x, player.position.y + 1, player.position.z);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offset;
        transform.position = player.position + offset;
        transform.LookAt(abovePlayer);
        rayCheckCharacter();
    }

    // Can the camera see the character?
    private bool rayCheckCharacter()
    {
        RaycastHit hit;
        Vector3 rayDir = player.position - this.transform.position;
        Ray ray = new Ray(this.transform.position, rayDir);

        Debug.DrawLine(this.transform.position, player.position);

        Physics.Raycast(ray, out hit);

        Debug.Log("Raycast: " + hit.collider);
        if (hit.collider != null && !hit.collider.gameObject.tag.Equals("HDR"))
        {
            Debug.Log("Collision con: " + hit.collider.name + " distancia: " + hit.distance);
            if (!hit.collider.gameObject.tag.Equals("Player")){
                this.transform.position = hit.point;
            }
        }
        else
        {
            return false;
        }

        
        //Debug.Log("Distancia a: " + r.collider + " es de: " + r.distance);


        if (hit.collider != null && hit.distance < 1)
            return true;


        if (hit.collider.gameObject.tag.Equals("stairs"))
        {
            if (hit.collider != null && hit.distance < 2)
                return true;
        }


        return false;
    }

}