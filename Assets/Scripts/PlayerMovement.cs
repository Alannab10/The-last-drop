using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid;

    float horizontalValue;
    [SerializeField]bool jumpActivated = false;

    [SerializeField] float speed;
    [SerializeField] float forceJump;
    [SerializeField] Transform detectionPoint;
    [SerializeField] float detectionSize;
    [SerializeField] LayerMask detectionLayer;
    [SerializeField] Collider2D[] collisions;
    [SerializeField] bool isGrounded;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontalValue = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            jumpActivated = true;
        }
    }
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(horizontalValue * speed, rigid.velocity.y);

        collisions = Physics2D.OverlapCircleAll(detectionPoint.position,detectionSize, detectionLayer);

        if(collisions.Length > 0 )
        {
            isGrounded = true;
        }

        if(collisions.Length == 1 && collisions[0].gameObject == gameObject)
        {
            isGrounded = false;
        }

        if(jumpActivated == true)
        {
            rigid.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            jumpActivated = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere (detectionPoint.position , detectionSize);
    }

}
