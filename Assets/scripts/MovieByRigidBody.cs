using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieByRigidBody : MonoBehaviour
{[SerializeField]
    private float SpeedFactor = 10f;

private Rigidbody2D Rb;
   
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float horizontaInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(horizontaInput, verticalInput,0f) * SpeedFactor;

    }
}
