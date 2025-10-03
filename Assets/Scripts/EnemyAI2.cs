using UnityEngine;
using UnityEngine.AI;

public class EnemyAI2 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public bool Move;
    public NavMeshAgent enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Move == true)
        {
            enemy.SetDestination(pointA.position);
            if (!enemy.pathPending)
            {
                if (enemy.remainingDistance <= enemy.stoppingDistance)
                {
                    enemy.SetDestination(pointB.position);
                    Move = false;
                }

            }

        }
        else
        {
            enemy.SetDestination(pointB.position);
            if (!enemy.pathPending)
            {
                if (enemy.remainingDistance <= enemy.stoppingDistance)
                {
                    Move = true;
                }

            }

        }
    }
}
