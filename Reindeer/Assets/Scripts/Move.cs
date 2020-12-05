using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 mousePosition;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = new Vector3(0, Input.mousePosition.y);
        transform.position = mousePosition;
    }
}
