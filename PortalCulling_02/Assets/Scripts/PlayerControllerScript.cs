using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public Camera eyes;
    public float speed;
    public float sensitivity;
    float moveFB;
    float moveLR;
    float mouseX;
    float mouseY; 
    CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveFB = Input.GetAxis("Vertical");
        moveLR = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0, mouseX*sensitivity, 0);
        Vector3 movement = new Vector3(moveFB * speed * Time.deltaTime, 0, moveLR * speed * Time.deltaTime);
        controller.Move(transform.rotation*movement);
        eyes.transform.Rotate(-mouseY*sensitivity, 0, 0);
  
    }
}
