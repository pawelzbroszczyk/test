using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 5f;
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
        Vector3 direction = new Vector3(0, verticalInput, horizontalInput); //określenie ruchu gracza (ponieważ obiekt jest odwrócony Y Rotation = 90 - horizontalInput wpisany jest w osi Z)
        transform.Translate(direction * playerSpeed * Time.deltaTime); //wprawienie w ruch gracza z prędkością 'playerSpeed'  
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minXPositionPossible, maxXPositionPossible), Mathf.Clamp(transform.position.y, minYPositionPossible, maxYPositionPossible), transform.position.z); //nie pozwol wyjsc graczowi poza ekran (może lepiej to ograniczyć innym obiektem z Colliderem?)       
    }

}
