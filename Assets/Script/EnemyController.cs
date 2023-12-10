using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target;  // El objetivo a seguir (el jugador)
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (target == null)
        {
            // Si el objetivo no se ha asignado, busca al jugador automáticamente
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Persigue al jugador
            navMeshAgent.SetDestination(target.position);
        }
    }
}

