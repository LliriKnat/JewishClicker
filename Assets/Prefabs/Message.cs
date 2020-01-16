using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour
{
    public float DestroyTime = 3;
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
}
