using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocity = 10f;
    public Game_Manager gameManager;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
        LaunchBall();
    }
    void FixedUpdate()
    {
        if (_rb.velocity.magnitude > velocity)
        {
            _rb.velocity = _rb.velocity.normalized * velocity;
        }
    }
    void LaunchBall()
    {
        bool isRight = false;
        if (Random.value > 0.5f)
        {
            isRight = true;
        }

        float xVelocity = -1;
        if (isRight == true)
        {
            xVelocity = 1;
        }

        float yVelocity = Random.Range(-1f, 1f);
        _rb.velocity = new Vector2(xVelocity * velocity, yVelocity * velocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ball Hit");
        gameManager.p1++;
        gameManager.UpdatePointsText();
    }
}