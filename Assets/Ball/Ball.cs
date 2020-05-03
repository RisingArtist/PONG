using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float speedCap;
    Rigidbody2D rb;
    bool hasLaunch;
    Vector2 launchDirection;
    public float speedUpTimer;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        launchDirection = Vector2.zero;
        hasLaunch = false;
    }

    // Pre-launch set up
    public void ResetBall()
    {
        hasLaunch = false;
        speed = 8.0f;
        speedUpTimer = Constants.RESET_TIMER;
        transform.position = Vector2.zero;
        rb.velocity = Vector2.zero;
    }

    // Construct random direction for the ball to go in
    public void PlayBall()
    {
        int angle = Random.Range(0, 60);
        int Up_Or_Down = Random.Range(-1, 1) > 0 ? 1 : -1;
        bool direction = (Random.Range(-1, 1) > 0) ? true : false; // Left or Right
        if (direction)
        {
            launchDirection = (new Vector2(Mathf.Cos(angle), Mathf.Sin(angle * Up_Or_Down)) * speed);
        }
        else
        {
            launchDirection = (new Vector2(Mathf.Cos(angle), Mathf.Sin(angle * Up_Or_Down)) * -speed);
        }

        hasLaunch = true;
        rb.velocity = launchDirection;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasLaunch)
            return;

        ClampVelocity();
        SpeedUp();
    }

    // Over certain amount time, speed up
    void SpeedUp() 
    {
        speedUpTimer -= Time.deltaTime;
        if (speedUpTimer <= 0.0f && speed < speedCap)
        {
            Debug.Log("Speed Up!");
            IncreaseVelocity();
            speedUpTimer = Constants.RESET_TIMER;
        }
    }

    // Increase ball's velocity in current direction & add it to speed
    void IncreaseVelocity()
    {
        if (rb.velocity.x < 0)
            rb.velocity = new Vector2(rb.velocity.x - Constants.SPEED_UP, rb.velocity.y);
        else
            rb.velocity = new Vector2(rb.velocity.x + Constants.SPEED_UP, rb.velocity.y);

        if (rb.velocity.y < 0)
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - Constants.SPEED_UP);
        else
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + Constants.SPEED_UP);

        speed += Constants.SPEED_UP;
    }

    // Prevents ball going completely straight horizontally or vertically
    void ClampVelocity()
    {
        float _threshold = speed / Constants.BY_QUARTER;
        if (Mathf.Abs(rb.velocity.y) < _threshold)
        {
            if (rb.velocity.y < 0)
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - _threshold);
            else
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + _threshold);
        }

        if (Mathf.Abs(rb.velocity.x) < _threshold)
        {
            if (rb.velocity.x < 0)
                rb.velocity = new Vector2(rb.velocity.x - _threshold, rb.velocity.y);
            else
                rb.velocity = new Vector2(rb.velocity.x + _threshold, rb.velocity.y);
        }
    }

    // Play sound when ball hits the paddle
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Paddle"))
        {
            GameManager.gm.PlaySFX(Constants.SoundTracks.PaddleHit);
        }
    }
}
