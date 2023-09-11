using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
    bool tapControl;
    Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        DetectTap();
    }

    void DetectTap()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);

            if (hit.collider != null)
            {
                TapObject(hit);
                tapControl = false;
            }
        }
    }

    void TapObject(RaycastHit2D hit)
    {
        if (hit.collider.gameObject.CompareTag("Enemy") && !tapControl)
        {
            tapControl = true;
            hit.collider.gameObject.GetComponent<Enemy>().Dead();
            hit.collider.gameObject.GetComponent<Enemy>().PlayAudio(tapControl);
            hit.collider.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            print(hit.transform.name);
        }
    }
}
