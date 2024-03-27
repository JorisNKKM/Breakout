using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int score;
	public static int bricks;

	void Start()
	{
		Brick.onBrickDestroy.AddListener(BrickBreak);
	}

	void BrickBreak()
	{
		score += 100;
		bricks--;

		if (bricks <= 0)
		{
			print("win!");
		}
	}
}