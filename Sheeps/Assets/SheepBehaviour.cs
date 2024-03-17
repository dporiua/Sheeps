using System.Collections;
using UnityEngine;

public class SheepBehaviour : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float stopTime = 2f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveAwayFrom(Vector2 threatPosition)
    {
        Vector2 moveDirection = (transform.position - (Vector3)threatPosition).normalized;
        rb.velocity = moveDirection * moveSpeed;
        StartCoroutine(StopMovingAfterDelay(stopTime));
    }

    private IEnumerator StopMovingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        rb.velocity = Vector2.zero;
    }
}