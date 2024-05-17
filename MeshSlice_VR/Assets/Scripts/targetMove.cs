using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMove : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float moveSpeed;

    void FixedUpdate()
    {
        Vector3 moveDir = transform.forward;

        Vector3 targetVelocity = moveDir * moveSpeed;
        Vector3 velocityChange = targetVelocity - rigid.velocity;

        rigid.AddForce(velocityChange, ForceMode.VelocityChange);
    }
}