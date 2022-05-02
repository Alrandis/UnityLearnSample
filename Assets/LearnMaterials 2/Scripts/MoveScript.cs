using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : SampleScript
{
    private bool startProgramm;
    [SerializeField] private Transform beginPosition;
    public Vector3 endPosition = new Vector3(0, 0, 0);

    [ContextMenu("Запуск программы Move")]
    new public void Use()
    {
        beginPosition = this.transform;
        startProgramm = true;
    }

    void Update()
    {
        if(startProgramm)
        {
            Vector3 directionMove = endPosition - beginPosition.position;
            if(directionMove.magnitude > 0.3f)
            {
                beginPosition.forward = directionMove;
                beginPosition.position += directionMove * Time.deltaTime;
            }
        }
    }
}
