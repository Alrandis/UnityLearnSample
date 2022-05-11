using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveRaycast : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private InteractiveBox box;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("InteractivePlane"))
                {
                    Instantiate(prefab, hit.point + hit.normal, Quaternion.identity);
                }

                if (hit.collider.CompareTag("InteractiveBox"))
                {
                    InteractiveBox curBox = hit.collider.GetComponent<InteractiveBox>();
                    if (box == null)
                    {
                        box = curBox;
                    }
                    else
                    {
                        box.AddNext(curBox);
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("InteractiveBox"))
                {
                    Destroy(hit.transform.parent.gameObject);
                }
            }
        }
    }
}
