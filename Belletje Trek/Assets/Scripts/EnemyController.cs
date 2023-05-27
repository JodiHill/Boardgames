using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public Transform planeTransform;
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Collider planeCollider;
    private Vector3 planeNormal;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        planeCollider = planeTransform.GetComponent<Collider>();
        planeNormal = planeTransform.up;
    }

    private void FixedUpdate()
    {
        Vector3 desiredDirection = player.position - transform.position;
        Vector3 movement = Vector3.ProjectOnPlane(desiredDirection, planeNormal).normalized;

        rb.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the plane collider
        if (collision.collider == planeCollider)
        {
            // Set the enemy's position to the collision contact point projected onto the plane
            Vector3 projectedPosition = Vector3.ProjectOnPlane(collision.contacts[0].point, planeNormal);
            rb.MovePosition(projectedPosition);
        }
    }
}
