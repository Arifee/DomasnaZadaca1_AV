using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    
    protected Joystick joystick;
    protected Joybutton joybutton;
    Animator animPlayer;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
        moveSpeed = 10f;
        animPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(joystick.Horizontal
                  , joystick.Vertical) * Mathf.Rad2Deg, transform.eulerAngles.z);
        //Animate Walk
        animPlayer.SetBool("Walk", true);
        
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,
                   moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(moveSpeed * joystick.Horizontal * Time.deltaTime, 0f, moveSpeed *
                    joystick.Vertical * Time.deltaTime);
      



    }
}
