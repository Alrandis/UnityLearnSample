using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonScript : SampleScript
{
    public GameObject prefab;
    public Transform parent;
    // Start is called before the first frame update
    [ContextMenu("�����������")]
    public override void Use()
    {
        for (int i = 1; i < 10; i++)
           Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity, parent);
    }

}
