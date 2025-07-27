using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotation;
    private bool isRotating = true;


    [SerializeField] private float speed;

    private FixedJoystick joystick;
    private Rigidbody rb;

    private void Start()
    {
        joystick = FindAnyObjectByType<FixedJoystick>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(rotation * Time.deltaTime);
        }
        else
        {
            float xVal = joystick.Horizontal;
            float yVal = joystick.Vertical;

            Vector3 movement = new Vector3(xVal, 0, yVal);

            rb.velocity = movement * speed;

            if (xVal != 0 && yVal != 0)
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
            }
        }
    }

    public void StopRotation()
    {
        isRotating = false;
    }

    public void StartRotation()
    {
        isRotating = true;
    }
}
    