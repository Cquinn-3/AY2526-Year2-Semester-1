using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class palerWalk : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity  = - 9.8f;
    public Transform groundcheack;
    public float groundDistanc = 0.4f;
    public LayerMask groundMask;
    public float jumpHeigt = 3f;
    Vector3 velocity;
    bool isGrounded;
    private footSeps footSeps;
    void Start()
    {
        footSeps = FindAnyObjectByType<footSeps>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //if(isPlaying == false)
        //{
        //    isPlaying = true;
        //    StartCoroutine(PlaySound());
        //}      
        isGrounded = Physics.CheckSphere(groundcheack.position, groundDistanc, groundMask);
        if (isGrounded && velocity .y <0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move *speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeigt * -2 * gravity);

        }

        controller.Move(velocity * Time.deltaTime);
        {
            if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
            {
                //StartCoroutine(PlaySound());
                footSeps.PlayFootSteps();

            }
            else if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical"))
            {
                footSeps.StopFootSteps();
            }
        }
        
        

    }
    private IEnumerator PlaySound()
    {
        footSeps.PlayFootSteps();
        yield return new WaitForSecondsRealtime(1);
    }
}
