using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchJumpMelee : MonoBehaviour
{
    public CharacterController characterCollider;
    public CapsuleCollider capsuleCollider;

    Vector3 CrouchFix;
    Vector3 vecloity;
    public float gravity = -75f;
    public float jumpHeight = 100f;
    public WalkingM _WalkingM;
    public WalkingR _WalkingR;
    public WalkingS _WalkingS;
    public WalkingJ _WalkingJ;
    public WalkingB _WalkingB;

    public GameObject RickNMorty, Summer, Jerry, Beth;

    public bool isGrounded;

    public bool isCrouching;

    public bool isJumping;

    public AbilitiesMain _AbilitiesMain;
    public ChangingCharacter _ChangingCharacter;
    public WalkMInjured _WalkMInjured;
    public WalkRInjured _WalkRInjured;
    public WalkSInjured _WalkSInjured;
    public WalkJInjured _WalkJInjured;
    public WalkBInjured _WalkBInjured;
    public AbilitiesMainB _AbilitiesMainB;

    void Awake()
    {
        // Make the game run as fast as possible in Windows
        Application.targetFrameRate = 300;
    }

    void Update()
    {

        if(characterCollider.isGrounded)
        {
            isGrounded = true;
        }else if (!characterCollider.isGrounded)
        {
            isGrounded = false;
        }
           

        if (isGrounded)
        {
            vecloity.y = -2f;
            isJumping = false;
            if (Globals.Character == "Rick And Morty")
            {
                if (Input.GetKeyDown(KeyCode.Space) && !_ChangingCharacter.Changing && !_AbilitiesMain.Teleporting && _AbilitiesMain.Teleported && !_WalkRInjured.RDying && !_WalkMInjured.MDying)
                {
                    isJumping = true;
                    vecloity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }else if (Globals.Character == "Summer")
            {
                if (Input.GetKeyDown(KeyCode.Space) && !_WalkSInjured.SDying)
                {
                    isJumping = true;
                    vecloity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }
            else if (Globals.Character == "Jerry")
            {
                if (Input.GetKeyDown(KeyCode.Space) && !_WalkJInjured.JDying)
                {
                    isJumping = true;
                    vecloity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }
            else if (Globals.Character == "Beth")
            {
                if (Input.GetKeyDown(KeyCode.Space) && !_WalkBInjured.BDying)
                {
                    isJumping = true;
                    vecloity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }
        }

        if(Globals.Character == "Rick And Morty")
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingR.walkSpeed = 125;
                _WalkingM.walkSpeed = 125;
            }
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingR.walkSpeed = 80;
                _WalkingM.walkSpeed = 80;
            }
        }
        else if (Globals.Character == "Summer")
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingS.walkSpeed = 250;
            }
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingS.walkSpeed = 160;
            }
        }
        else if (Globals.Character == "Jerry")
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingJ.walkSpeed = 250;
            }
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                _WalkingJ.walkSpeed = 160;
            }
        }
        else if (Globals.Character == "Beth")
        {
            if (Input.GetKey(KeyCode.LeftShift) && !_AbilitiesMainB.Dash)
            {
                _WalkingB.walkSpeed = 250;
            }
            if (!Input.GetKey(KeyCode.LeftShift) && !_AbilitiesMainB.Dash)
            {
                _WalkingB.walkSpeed = 160;
            }
        }

        vecloity.y += gravity * Time.deltaTime;

        characterCollider.Move(vecloity * Time.deltaTime);
    }
}
