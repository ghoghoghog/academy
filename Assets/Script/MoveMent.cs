using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        GetComponent<SpriteRenderer>().flipX = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal")) == -1;

        

        float  keyInput = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        if (keyInput != 0)
        {
            GetComponent<SpriteRenderer>().flipX = keyInput == -1;
        }

        // �¿� �Է��� �޽��ϴ�. (Ű������ �¿� ȭ��ǥ �Ǵ� A/D Ű)
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // �������� �����մϴ�.
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

    }
}
