using UnityEngine;

public class Bat : MonoBehaviour
{
	public float speed = 1;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		rb.velocity = Vector2.right * Input.GetAxisRaw("Horizontal") * speed;
		//rb.MovePosition(transform.position + Vector3.right * Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime);
	}
}