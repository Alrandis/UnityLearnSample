using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : SampleScript
{
    private bool startProgramm;
    public float speed = 0;
    private float xAngle;
    private float yAngle;
    private float zAngle;
    public float xRotate;
    public float yRotate;
    public float zRotate;
    public Transform beginRotation;

    private void Awake()
    {
        beginRotation = this.transform;
    }

    [ContextMenu("������ ��������� Rotation")]
    override public void Use()
    {
        startProgramm = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startProgramm)
        {
            if (xAngle < xRotate) { xAngle += Time.deltaTime * speed; }
            if (yAngle < yRotate) { yAngle += Time.deltaTime * speed; }
            if (zAngle < zRotate) { zAngle += Time.deltaTime * speed; }
            transform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
        }
    }
}
