using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 5f; // Publiczne pole prędkości
    private Vector3 initialPosition; // Początkowa pozycja obiektu
    private bool moveRight = true; // Flaga określająca kierunek ruchu
    private int Rotate = 0; //Flaga określająca czy dokonano obrotu
    void Start()
    {
        // Zapisz początkową pozycję obiektu
        initialPosition.x = transform.position.x;
        initialPosition.z = transform.position.z;
    }
    void Update()
    {


        if (moveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }



        
        if (transform.position.x >= initialPosition.x + 10 & Rotate == 0)
        {
            transform.Rotate(Vector3.up, 270f);
            Rotate = 1;

        }
        
        if (transform.position.z >= initialPosition.z + 10 & Rotate == 1)
        {
              transform.Rotate(Vector3.up, 270f);
              Rotate = 2;
        }
        if ((transform.position.x <= initialPosition.x + 0) & (transform.position.z >= initialPosition.z + 10) & Rotate == 2)
        {
              transform.Rotate(Vector3.up, 270f);
              Rotate = 3;  
        }
        if ((transform.position.z <= initialPosition.z + 0) & (transform.position.x <= initialPosition.x + 0) & Rotate == 3)
        {
              transform.Rotate(Vector3.up, 270f);  
              Rotate = 0; 
        }
    }
}
