using UnityEngine;

public class Bullet : MonoBehaviour {

    public Transform target;

    public float speed = 70f;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        // Checks if it hit
        if (direction.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        // Move to the target at a constant speed
        transform.Translate(direction.normalized * distanceThisFrame, Space.World);

    }

    void HitTarget()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
