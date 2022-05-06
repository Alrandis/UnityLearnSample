using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonScript : SampleScript
{
    [SerializeField] private Vector3 step;
    public GameObject prefab;
    // Start is called before the first frame update
    [ContextMenu("Клонировать")]
    public override void Use()
    {

        for (int i = 1; i < 10; i++)
           Instantiate(prefab, transform.position + step * i, Quaternion.identity);
    }

}
