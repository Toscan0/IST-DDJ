using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    float _mouseSensitivity = 2.0f;

    // Update is called once per frame
    void Update () {
        float horizontal = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float vertical = -Input.GetAxis("Mouse Y") * _mouseSensitivity;
        vertical = Mathf.Clamp(vertical, -80, 80);

        transform.Rotate(0, horizontal, 0);
        transform.Rotate(vertical, 0, 0);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.parent.transform.rotation.eulerAngles.y, 0);

    }
}
