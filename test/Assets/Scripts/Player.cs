using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] 
    public float playerSpeed = 5f;
    private float minXPositionPossible=-8f, maxXPositionPossible=8.5f, minYPositionPossible=-4.5f, maxYPositionPossible=5; 

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
        Vector3 direction = new Vector3(verticalInput, -horizontalInput, 0);
        transform.Translate(direction * playerSpeed * Time.deltaTime); //wprawienie w ruch gracza z prędkością 'playerSpeed'  
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minXPositionPossible, maxXPositionPossible), 
            Mathf.Clamp(transform.position.y, minYPositionPossible, maxYPositionPossible), transform.position.z); //nie pozwol wyjsc graczowi poza ekran (może lepiej to ograniczyć innym obiektem z Colliderem?)       
    }

}
