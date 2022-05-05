using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : SampleScript
{
    private bool startProgramm;
    public float speed = 0;
    public float xAngle;
    public float rotate;
    public Transform beginRotation;

    [ContextMenu("Запуск программы Rotation")]
    override public void Use()
    {
        startProgramm = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startProgramm)
        {
            if (xAngle < rotate)
            {
                xAngle += Time.deltaTime * speed;
                transform.rotation = Quaternion.Euler(xAngle, 0, 0);
            }
        }
    }
}
