using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour 
{
    [SerializeField]
    private float acceleration = 75f;

    private float initialVelocity = 2f;

    private Rigidbody2D rb_Enemy;

    // Use this for initialization
    void Start()
    {
        rb_Enemy = GetComponent<Rigidbody2D>();

        rb_Enemy.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Moves Enemy Down the screen.
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        rb_Enemy.AddForce(ForceToAdd);
    }
}
