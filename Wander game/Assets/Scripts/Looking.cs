using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
	//Multipler
    [Range(100f, 2000f)]
	public float MouseSensitivity = 200f;
	//Mouse Positions
	float MouseX;
	float MouseY;
    public float lookLimit = 45f;

	//Player Body
	public Transform Body;
    public Camera playerCamera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerCamera.GetComponent<Camera>();
    }

    void Update()
    {

        MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        //Player Body Turn
        Body.Rotate(Vector3.up * MouseX);
        //Camera Rotation
        Mathf.Clamp(MouseY, -lookLimit, lookLimit);
        playerCamera.transform.Rotate(Vector3.right * -MouseY);
    }

}
