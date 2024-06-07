using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody=GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(6f, 6f);
    }
    private void Update()
    {
        
    }
}

