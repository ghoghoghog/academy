using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject door; // ������ ������Ʈ�� Inspector â���� �����մϴ�.

    SpriteRenderer sr;
    Sprite buttonSprite;
    Sprite buttonOffSprite;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        buttonSprite = Resources.Load<Sprite>("ButtonPushed");
        buttonOffSprite = Resources.Load<Sprite>("Button");

        door.SetActive(true);
    }

    // ������Ʈ�� �ٸ� ������Ʈ�� �浹�ϴ� ���� ȣ��˴ϴ�.
    private void OnTriggerStay2D(Collider2D other)
    {
        

        door.SetActive(false);
        
        //sprite.sprite = Resources.Load<Sprite>("ButtonPushed");
        sr.sprite = buttonSprite;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        door.SetActive(true);
        sr.sprite = buttonOffSprite;

    }
}
