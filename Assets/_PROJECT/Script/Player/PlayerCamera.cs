using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSensitivity;  //mouse sensitivity to change mouse speed
    public Transform characterBody; //player body to rotate with camera rotate on y axis

    private float _currentXRotation = 0;    //tracking current x rotation so we can limit it preventing player breaking spine


    // Start is called before the first frame update
    void Start()
    {
        MouseInitializer();
    }

    // Update is called once per frame
    void Update()
    {
        MouseMovement();
    }

    private void MouseInitializer()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void MouseMovement()
    { 
        float _mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float _mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        _currentXRotation -= _mouseY;
        _currentXRotation = Mathf.Clamp(_currentXRotation,-90,90);

        this.transform.localRotation = Quaternion.Euler(_currentXRotation,0,0);
        characterBody.Rotate(Vector3.up * _mouseX);
    }
}
