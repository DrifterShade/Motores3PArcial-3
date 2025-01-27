using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
    }

    private void Update()
    {
        if (parent != null)
        {
            transform.position = parent.position;
        }
    }
}
