using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onfoot;

    private PlayerMotor motor;

    private PlayerLook look;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        playerInput = new PlayerInput();
        onfoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        onfoot.Jump.performed += ctx => motor.Jump();

        
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.ProcessMove(onfoot.Movement.ReadValue<Vector2>());
        
    }

    void LateUpdate()
    {
        look.ProcessLook(onfoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onfoot.Enable();
    }
    private void OnDisable()
    {
        onfoot.Disable();
    }
}
