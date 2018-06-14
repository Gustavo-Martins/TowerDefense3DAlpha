using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int waypointIndex = 0;
    private float minPosition = 0.5f;
    
    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;

        // Normalized to have a fixed speed
        // Delta time to dettach from framerate speed
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // If position is close, waypoint reached, get next waypoint
        if (Vector3.Distance(transform.position, target.position) <= minPosition)
        {
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }
  }
