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
        // Gets gold bounty from enemy
        Enemy enemy = target.GetComponent<Enemy>();
        GameManager.instance.goldCount += enemy.goldBounty;

        // Destroy object and particle effects
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
