using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baterry : MonoBehaviour
{
    private gravity gr;
    private void Start()
    { 
       gr = GetComponent<gravity>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Charge")) // ���� �ݶ��̴��� �±׸� Ȯ���Ͽ� ó��
        {
            transform.position = collision.transform.position;

            gr.gravity_to(0);   
        }
        else
        {
            gr.gravity_back();
        }
    }
}
