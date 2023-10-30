using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, PlayerControls.IPlayerActions
{
    public PlayerControls controls;

    private Rigidbody2D _rb;
    public int speed;
    public float _inputX;
    public float _inputY;
    private Animator _anim;
    private Vector2 moveDirection;
    public float moveMag;
    public bool useOffice2Comp, useOffice1Comp, useBobsComp, useAlexsComp;

    public Office2 office2Script;
    public Office1 office1Script;
    public BobsOffice bobsOfficeScript;
    public AlexsComp alexsCompScript;
    //public DialogueManager dm;

    void Awake()
    {
        controls = new PlayerControls();
        controls.Player.SetCallbacks(this);
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveMag = moveDirection.magnitude;
    }


    public void OnWalk(InputAction.CallbackContext context)
    {
        if (context.started)
        {
        }
        if (context.performed)
        {
            _inputX = context.ReadValue<Vector2>().x;
            _inputY = context.ReadValue<Vector2>().y;

            _rb.velocity = new Vector2(_inputX, _inputY) * speed * Time.fixedDeltaTime;
            moveDirection = new Vector2(_rb.velocity.x, _rb.velocity.y).normalized;

            _anim.SetFloat("moveX", _inputX);
            _anim.SetFloat("moveY", _inputY);
            _anim.SetFloat("moveMag", moveDirection.magnitude);
        }
        if (context.canceled)
        {
            _rb.velocity = new Vector2(0, 0); // stop player from moving
            moveDirection = new Vector2(_rb.velocity.x, _rb.velocity.y).normalized;
            _anim.SetFloat("moveMag", moveDirection.magnitude);
        }
    }

    private void OfficeComp2()
    {
        if (office2Script.OfficeComputer2)
        {
            useOffice2Comp = true;
        }
        else
        {
            useOffice2Comp = false;
        }
    }

    private void OfficeComp1()
    {
        if (office1Script.OfficeComputer1)
        {
            useOffice1Comp = true;
        }
        else
        {
            useOffice1Comp = false;
        }
    }

    private void BobsComp()
    {
        if (bobsOfficeScript.bobsOfficeComputer)
        {
            useBobsComp = true;
        }
        else
        {
            useBobsComp = false;
        }
    }

    private void AlexsComp()
    {
        if (alexsCompScript.alexsComp)
        {
            useAlexsComp = true;
        }
        else
        {
            useAlexsComp = false;
        }
    }
    public void OnTalk(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            return;
        }
        if (context.performed)
        {
            //if (dm.isOpen)

            //    dm.NextMessage();
            return;
        } 
        if (context.canceled)
        {
            return;
        }
    }
    public void OnUse(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            return;
        }
        if (context.performed)
        {
            OfficeComp2();
            OfficeComp1();
            BobsComp();
            AlexsComp();
        }
        if (context.canceled)
        {
            return;
        }
    }
}
