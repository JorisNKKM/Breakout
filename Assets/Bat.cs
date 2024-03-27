using UnityEngine;

public class Bat : MonoBehaviour
{
	public float speed = 1;
	Rigidbody2D rb;
	public int balls = 5;

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
		print("respawn!");
	}
}