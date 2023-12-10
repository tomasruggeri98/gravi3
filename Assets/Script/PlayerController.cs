using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10.0f;
    public float moveSpeed = 5.0f;
    public Transform playerCamera; // referencia a la cam en primera persona
    private Rigidbody rb;
    public bool canJump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        Vector3 moveDirection = playerCamera.forward * verticalInput + playerCamera.right * horizontalInput;
        moveDirection.y = 0;

        
        rb.velocity = moveDirection.normalized * moveSpeed + new Vector3(0, rb.velocity.y, 0);

       
        if (Input.GetButtonDown("Jump") && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = true;
        }

        if (collision.transform.tag == "Enemigo")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = false;
        }

        if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
    }

}




