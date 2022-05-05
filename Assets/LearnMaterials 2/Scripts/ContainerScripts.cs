using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScripts : MonoBehaviour
{
    public RotationScript rs;
    public MoveScript ms;
    public Delete del;
    public ClonScript cs;

    public List<SampleScript> container = new List<SampleScript>();

    private void Awake()
    {
        container.Add(rs);
        container.Add(ms);
        container.Add(del);
        container.Add(cs);
    }

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            container[i].Use();
        }
    }
}

