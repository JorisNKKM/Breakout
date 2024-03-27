using UnityEngine;

public class Bat : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rb;
    public int lives = 5;
    public int rnd;
    public Vector3 derection;
    public GameObject Ball;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Ball.onBallLose.AddListener(RespawnBall);
    }

    void Update()
    {
        rb.velocity = Vector2.right * Input.GetAxisRaw("Horizontal") * speed;
    }

    void RespawnBall()
    {
        lives--;
        if (lives > 0)
        {
            rnd = Random.Range(0, 10);
            if (rnd > 5)
            {
                Ball.transform.rotation = Quaternion.Euler(1, 0, 0); 
            }
            else
            {
                Ball.transform.rotation = Quaternion.Euler(-1, 0, 0); 
            }
        }
    }
}
