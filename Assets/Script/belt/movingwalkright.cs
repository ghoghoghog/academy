using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingwalkright : MonoBehaviour
{


    public float objectSpeed = 5f; // ������Ʈ�� �̵� �ӵ�

    private void OnCollisionStay2D(Collision2D collision)
    {
        
        
            // �浹�� ������Ʈ�� transform�� �������� �̵���Ű��
            Vector3 leftDirection = Vector3.right;
            float moveSpeed = 5f; // �̵� �ӵ� ����
            collision.transform.Translate(leftDirection * moveSpeed * Time.deltaTime);
        
    }

}
