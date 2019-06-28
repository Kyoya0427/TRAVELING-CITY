using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class corContllor : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 30.0f;

    private float verticalVelocity = 0.0f;
    private float gravity = 8.0f;

    private float animationDuration = 2.0f;

    private bool isDead = false;

    void Start ()
    {

        controller = GetComponent<CharacterController>();
 		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Time.time<animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }

        moveVector = Vector3.zero;

        if(controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.x = Input.GetAxisRaw("Horizontal") * speed / 3;

        moveVector.y = verticalVelocity;

        moveVector.z = speed;

      
        controller.Move(moveVector * Time.deltaTime);


        if(isDead == true)
        {
            SceneManager.LoadScene("Result");
        }
    }

    public void SetSpeed(float modifier)
    {
        speed = 30.0f + (modifier *  10.0f);
        Debug.Log(speed);
    }

    public float GetNowSpeed()
    {
        return speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "block")
        {
            Death();
        }
        
    }

    private void Death()
    {
        isDead = true;
        Debug.Log("死");
    }

    public bool GetPlayerState()
    {
        return isDead;
    }

}
