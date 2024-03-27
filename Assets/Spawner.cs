using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int width;
    public int height;

    public GameObject prefab;
    public Vector3 brickSize;

    void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var pos = new Vector3(x * brickSize.x,-y * brickSize.y,0);
                Instantiate(prefab,transform.position + pos,Quaternion.identity);
            }
        }
    }
}