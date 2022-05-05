using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : SampleScript
{
    private bool startProgramm;
    [SerializeField] private Transform beginPosition;
    public Vector3 endPosition = new Vector3(0, 0, 0);

    private void Awake()
    {
        beginPosition = this.transform;
    }

    [ContextMenu("Запуск программы Move")]
    override public void Use()
    {
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
