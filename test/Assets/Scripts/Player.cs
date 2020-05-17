using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 3.5f;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0); //określenie ruchu gracza
        transform.Translate(direction * playerSpeed * Time.deltaTime); //wprawienie w ruch gracza z prędkością 'playerSpeed'        
    }
}
