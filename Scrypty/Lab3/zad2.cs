using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 10f; // Publiczne pole prędkości
    private Vector3 initialPosition; // Początkowa pozycja obiektu
    private bool moveForward = true; // Flaga określająca kierunek ruchu

    void Start()
    {
        // Zapisz początkową pozycję obiektu
        initialPosition.x = transform.position.x;
    }
    void Update()
    {
        // Sprawdź kierunek ruchu i przesuń obiekt wzdłuż osi x
        if (moveForward)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // Jeśli obiekt przesunął się o 10 jednostek w prawo, zmień kierunek ruchu
        if (transform.position.x >= initialPosition.x + 10)
        {
            moveForward = false;
        }
        // Jeśli obiekt wrócił na początkową pozycję, zmień kierunek ruchu
        else if (transform.position.x <= initialPosition.x)
        {
            moveForward = true;
        }
    }
}

