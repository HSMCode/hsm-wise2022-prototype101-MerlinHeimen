using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnSpeed;
    public float force;
    public float gravityModifier = 1f;
    public float jumpTimer;
    public float jumpButtonPressedTime = 1f;

    public bool isOnGround;
    public bool isJumping;
    public bool isFalling;
    public bool isLanding;
    public bool jumpCanceled;

    private Animator _playerAnim;
    private Rigidbody _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerAnim = GetComponent<Animator>();
        _playerRB = GetComponent<Rigidbody>();

        //Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //Player is walking and running
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

        //_playerAnim.SetFloat("Run", forwardInput);

        //Play Walk Animations
        if(forwardInput == 1)
        {
            _playerAnim.SetBool("Walk", true);
            
        }
        else
        {
            _playerAnim.SetBool("Walk", false);
        }

        // Player is Jumping
        if (Input.GetKeyDown("space") && isOnGround)
        {
            isOnGround = false;
            isJumping = true;

            /*if (isJumping)
            {
                _playerRB.AddForce(force, ForceMode.Impulse);

                _playerAnim.SetTrigger("Jump");

            }*/
        }

        /*void FixedUpdate()
        {
            if (isJumping)

                gravityModifier = 1f;
            _playerRB.AddForce(Vector3.up * force, ForceMode.Force);


        }*/

        /*void OnTriggerEnter(Collider other)
        {
            isOnGround = true;
            isJumping = false;
        }*/
        
    } //End of "void Update()"

    void FixedUpdate()
    {
        if (isJumping)
        {
            gravityModifier = 1f;
            _playerRB.AddForce(Vector3.up * force, ForceMode.Impulse);

        }

        if (isFalling || isOnGround || isLanding || jumpCanceled)
        {
            // _playerRb.AddForce(Vector3.down * forceDown * _playerRb.mass);
            gravityModifier = 30f;
        }

        _playerRB.AddForce(Physics.gravity * (gravityModifier - 1) * _playerRB.mass);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            if (isFalling)
            {

            }
        }
    } // End of "void OnCollisionEnter(Collision collision)"
}
        

