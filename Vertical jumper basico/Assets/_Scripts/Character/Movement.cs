using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool canJump;
    public float jumpForce;
    bool jumpLeft,jumpRight;
    Rigidbody2D rdbd;
    Vector3 charPos;
    private void Start()
    {
        canJump = true;
        rdbd = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Debug.Log(canJump);
        charPos = this.transform.position;
        JumpDir();
    }
    private void OnBecameInvisible()
    {
        GameManager.INS.GameOver();
    }
    void JumpDir()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canJump)
        {
            jumpLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && canJump)
        {
            jumpRight = true;
        }
    }
    private void FixedUpdate()
    {
        if (jumpLeft)
        {
            jumpLeft = false;
            rdbd.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
            rdbd.AddForce(Vector2.left * (jumpForce * 13));
        }
        if (jumpRight)
        {
            jumpRight = false;
            rdbd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            rdbd.AddForce(Vector2.right * (jumpForce * 13));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("platform"))
        {
            canJump = true;
            GameManager.INS.spawnPlat = true;
            GameManager.INS.Points();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
        GameManager.INS.spawnPlat = false;
    }
}
