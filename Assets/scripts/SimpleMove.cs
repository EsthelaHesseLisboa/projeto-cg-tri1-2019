using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;

    void Start()
    {
    }

    void Update()
    {
       float horizontaInput = Input.GetAxisRaw("Horizontal");
       float verticalInput = Input.GetAxisRaw("Vertical");

       Vector3 velocity = new Vector3(horizontaInput,verticalInput,0f) * SpeedFactor;
        
      transform.position = transform.position + velocity * Time.deltaTime;
    }
}
 