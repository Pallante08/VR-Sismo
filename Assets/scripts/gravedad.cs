using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravedad : MonoBehaviour
{
    public Transform obj;
    public float gravity = -9.81f;

    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity.y += gravity * Time.deltaTime;

    }
}
