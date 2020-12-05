using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector3(0, Input.mousePosition.y, -10);
        transform.position = mousePosition;
    }
}
