using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private float move;
    public float speed = 5;
    public float speedY = 2;
    public float jumpForce = 5;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, move)){
            transform.rotation = move > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        }

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }


    void ManagerCollision (GameObject collider)
    {
        if(collider.CompareTag("tree") && Input.GetButtonDown("Jump")){
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * speedY;
        }
    }

     void OnTriggerEnter2D(Collider2D colliderObj)
    {
        ManagerCollision(colliderObj.gameObject);
    }
}
