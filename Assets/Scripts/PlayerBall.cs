using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerBall : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 6f;
    private Rigidbody2D rb;
    private bool grounded = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Consider grounded when touching anything below
        foreach (ContactPoint2D pt in collision.contacts)
        {
            if (pt.normal.y > 0.5f) grounded = true;
        }
    }
}