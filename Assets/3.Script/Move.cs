using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class Move : MonoBehaviour
{

    public float moveSpeed = 3f; 
    private SkeletonAnimation animation;
    private Rigidbody2D rb;

    private void Start()
    {
        animation = GetComponent<SkeletonAnimation>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        HandleMovement();
        HandleAttack();
    }

    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;
        rb.velocity = movement;

        if(movement !=Vector2.zero)
        {
            animation.AnimationName = "02. Walk";

            Vector3 newScale = transform.localScale; // 현재 scale을 저장
            if (moveX > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else if (moveX < 0)
                transform.localScale = new Vector3(-1, 1, 1);
            transform.localScale = newScale; // scale 적용

        }
        else
        {
            animation.AnimationName = "01. Idle";
        }
    }
    private void HandleAttack()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("공격!");
            animation.AnimationName = "05. Attack";
        }
    }
}
