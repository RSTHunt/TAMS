using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [SerializeField] private float Threshold = 0.1f;
    [SerializeField] private float Deadzone = 0.025f;

    private bool isPressed;
    private Vector3 StartPosition;
    private ConfigurableJoint Joint;

    public UnityEvent OnPressed, OnReleased;

    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Cube;
    public float WallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.localPosition;
        Joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPressed && GetValue() + Threshold >=1)
        {
            Pressed();
        }
        if(isPressed && GetValue() - Threshold <=0)
        {
            Released();        
        }
    }

    private float GetValue()
    {
        var value = Vector3.Distance(StartPosition, transform.localPosition) / Joint.linearLimit.limit;

        if(Math.Abs(value) < Deadzone)
        {
            value = 0;
        }

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        isPressed = true;
        OnPressed.Invoke();
    }

    private void Released()
    {
        isPressed = false;
        OnReleased.Invoke();
        Wall1.transform.position = Vector3.MoveTowards(Wall1.transform.position, Cube.transform.position, -WallSpeed);
        Wall2.transform.position = Vector3.MoveTowards(Wall2.transform.position, Cube.transform.position, -WallSpeed);
        Wall3.transform.position = Vector3.MoveTowards(Wall3.transform.position, Cube.transform.position, -WallSpeed);
        Wall4.transform.position = Vector3.MoveTowards(Wall4.transform.position, Cube.transform.position, -WallSpeed);
    }
}
