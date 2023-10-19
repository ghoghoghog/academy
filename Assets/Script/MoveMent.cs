using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public gravity gr;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    public Animator anim;

    int left = 0;
    int right = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gr = GetComponent<gravity>();
        anim.SetBool("Idle", true);




    }

    private void Update()
    {

        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        //int keyInput = Mathf.RoundToInt(horizontalInput);
        int keyInput = left + right;
        if (keyInput != 0)
        {
            GetComponent<SpriteRenderer>().flipX = keyInput == -1;
            anim.SetBool("Idle", false);
        }
        else
        {
            anim.SetBool("Idle", true);
        }
        
        // �¿� �Է��� �޽��ϴ�. (Ű������ �¿� ȭ��ǥ �Ǵ� A/D Ű)

        // �������� �����մϴ�.
        rb.velocity = new Vector2(keyInput * moveSpeed, rb.velocity.y);

        if (gr.wjdtkdwndfur == false)
        {
            transform.rotation=Quaternion.Euler(180, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

        public void leftPress()
        {
        left = -1;
        }

        public void rightPress()
    {
        right = 1;

    }

        public void leftUnPress()
    {
        left = 0;

    }

        public void rightUnPress()
    {
        right = 0;

    }
}
