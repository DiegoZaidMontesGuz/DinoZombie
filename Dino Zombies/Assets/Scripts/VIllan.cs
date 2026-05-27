using UnityEngine;
using UnityEngine.AI;

public class Villan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float range = 30f;
    private Transform player;
    private bool inSight = false;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateUpAxis = false;
        agent.updateRotation = false;

        player = GameObject.FindWithTag("MC").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (inSight)
            agent.SetDestination(player.position);

        Vector3 direction = agent.velocity;

        float distance = Vector2.Distance(player.position, transform.position);

        if (distance < range)
        {
            inSight = true;
        }

        if (direction.sqrMagnitude > 0.01f )
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0,0,angle - 90f);
        }
    }
}
