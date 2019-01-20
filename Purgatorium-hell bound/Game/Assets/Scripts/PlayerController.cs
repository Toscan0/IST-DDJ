using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float _movementSpeed = 5f;
    float mouseSensitivity = 2.0f;
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * _movementSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * _movementSpeed;

        float horizontal = Input.GetAxis("Mouse X") * mouseSensitivity;
        float vertical = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        vertical = Mathf.Clamp(vertical, -80, 80);
        
        transform.Rotate(0,  horizontal, 0);
        transform.Rotate( vertical, 0, 0);

        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);



        //transform.Rotate(0, x, 0);
        transform.Translate(x, 0, z);
    }
}
