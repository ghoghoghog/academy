using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baterry : MonoBehaviour
{
    private gravity gr;
    private Rigidbody2D rb;
    private void Start()
    { 
       gr = GetComponent<gravity>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Charge")) // ���� �ݶ��̴��� �±׸� Ȯ���Ͽ� ó��
        {
            transform.position = collision.transform.position;
            rb.velocity = Vector3.zero;

            gr.gravity_to(0);   
        }
        //else
        {
           // gr.gravity_back();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Charge"))
        {
            gr.gravity_back();
        }
    }
}
