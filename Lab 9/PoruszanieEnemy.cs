using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float movementSpeed = 2f;
    public float reactionRange = 5f;

    private Vector3 currentTarget;
    public Transform gracz;


    void Start()
    {
        currentTarget = pointB.position;
    }

    void Update()
    {

        float distance = Vector3.Distance(transform.position, currentTarget);

        if (gracz.position.x > pointA.position.x && gracz.position.x < pointB.position.x && gracz.position.y < transform.position.y + reactionRange && gracz.position.y > transform.position.y - reactionRange)
        {

            Vector2 player = new Vector2((gracz.position - transform.position).normalized.x, 0f);
            transform.Translate(player * movementSpeed * Time.deltaTime);
        }

        else
        {
            if (distance <= 0)
            {
                currentTarget = (currentTarget == pointA.position) ? pointB.position : pointA.position;
            }

            transform.position = Vector2.MoveTowards(transform.position, currentTarget, movementSpeed * Time.deltaTime);
        }

    }
}