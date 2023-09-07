using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
    public GameObject door; // ������ ������Ʈ�� Inspector â���� �����մϴ�.

    private void Start()
    {
        door.SetActive(true);
    }

    // ������Ʈ�� �ٸ� ������Ʈ�� �浹�ϴ� ���� ȣ��˴ϴ�.
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Battery"))
        {
            door.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Battery"))
            door.SetActive(true);
    }
}
