using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonONOFF : MonoBehaviour
{
    public GameObject door; // ������ ������Ʈ�� Inspector â���� �����մϴ�.
    public int on =1;

    private void Start()
    {
        door.SetActive(true);
        on = 1;

    }

    // ������Ʈ�� �ٸ� ������Ʈ�� �浹�ϴ� ���� ȣ��˴ϴ�.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (on == 1)
        {
         door.SetActive(false);
            Debug.Log("open");
            on = 0;
        }
        if ( on == 0)
        {
            door.SetActive(true);
            Debug.Log("close");
            on = 1;
        }

    }
}
