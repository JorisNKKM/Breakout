using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{
    public static UnityEvent onBrickDestroy = new();
    [SerializeField]int hp = 1;

    void Start()
    {
        GameManager.bricks++;
    }

    public void Break()
    {
        hp--;
        if (hp <= 0)
        {
            onBrickDestroy.Invoke();
            Destroy(gameObject);
        }
    }
}