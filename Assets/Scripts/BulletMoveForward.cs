using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour 
{
    [SerializeField]
    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D rb_Bullet;

    // Use this for initialization
    void Start()
    {
        rb_Bullet = GetComponent<Rigidbody2D>();

        rb_Bullet.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Moves Bullet Towards top of screen.
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        rb_Bullet.AddForce(ForceToAdd);
    }
}
