using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobsBreakRoute : MonoBehaviour
{
    public int timesroutewalked;
    public float speed;
    private float step;
    public GameObject currentTarget;
    public GameObject wp0, wp1, wp2, wp3, wp6, wp7, wp8, wp9;
    public Coroutine Route2Co;
    public bool forward;
    public int counter;
    private BobsOfficeRoute officeRouteScript;
    private BobsBreakRoute breakRouteScript;
    private Rigidbody2D _rb;
    private Animator _anim;
    public GameObject bob;

    public float animX;
    public float animY;
    public float moveMagnitude;

    private void Awake()
    {
        officeRouteScript = GetComponent<BobsOfficeRoute>();
        breakRouteScript = GetComponent<BobsBreakRoute>();
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        currentTarget = wp0;
        counter = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Route2Co = null;
        step = speed * Time.fixedDeltaTime;
        forward = true;
    }

    // Update is called once per frame
    void Update()
    {
        timesroutewalked = counter;
        BobMove();
        Animate();
    }
    private void BobMove()
    {
        //_anim.SetFloat("WalkLeft", _rb.velocity.x);
        //_anim.SetFloat("WalkRight", _rb.velocity.x);
        //_anim.SetFloat("WalkUp", _rb.velocity.y);
        //_anim.SetFloat("WalkDown", _rb.velocity.y);

        if (counter == 1)
        {
            counter = 0;
            officeRouteScript.enabled = true;
            breakRouteScript.enabled = false;
        }
        else
        {
            if (Route2Co != null)
            {
                return;
            }
            else
            {
                if (forward)
                {
                    Route2Co = StartCoroutine(Break1Co());
                }
                else
                {
                    Route2Co = StartCoroutine(Break2Co());
                }
            }
        }
    }
    private void Animate()
    {
        Vector3 direction = currentTarget.transform.position - transform.position;
        direction.Normalize();
        //Debug.Log("sprites direction is : " + direction);
        animX = direction.x;
        animY = direction.y;

        _anim.SetFloat("moveX", animX);
        _anim.SetFloat("moveY", animY);
        _anim.SetFloat("moveMagnitude", direction.magnitude);

    }
    private void BreakForward()
    {
        bob.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

        if (Vector2.Distance(transform.position, wp0.transform.position) < 0.2f)
        {
            currentTarget = wp1;
        }
        if (Vector2.Distance(transform.position, wp1.transform.position) < 0.2f)
        {
            currentTarget = wp2;
        }
        if (Vector2.Distance(transform.position, wp2.transform.position) < 0.2f)
        {
            currentTarget = wp3;
        }
        if (Vector2.Distance(transform.position, wp3.transform.position) < 0.2f)
        {
            currentTarget = wp6;
        }
        if (Vector2.Distance(transform.position, wp6.transform.position) < 0.2f)
        {
            currentTarget = wp7;
        }
        if (Vector2.Distance(transform.position, wp7.transform.position) < 0.2f)
        {
            currentTarget = wp8;
        }
        if (Vector2.Distance(transform.position, wp8.transform.position) < 0.2f)
        {
            currentTarget = wp9;
        }
        if (Vector2.Distance(transform.position, wp9.transform.position) < 0.2f)
        {
            forward = false;
        }
    }

    private void BreakBackwards()
    {
        bob.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

        if (Vector2.Distance(transform.position, wp9.transform.position) < 0.2f)
        {
            currentTarget = wp8;
        }
        if (Vector2.Distance(transform.position, wp8.transform.position) < 0.2f)
        {
            currentTarget = wp7;
        }
        if (Vector2.Distance(transform.position, wp7.transform.position) < 0.2f)
        {
            currentTarget = wp6;
        }
        if (Vector2.Distance(transform.position, wp6.transform.position) < 0.2f)
        {
            currentTarget = wp3;
        }
        if (Vector2.Distance(transform.position, wp3.transform.position) < 0.2f)
        {
            currentTarget = wp2;
        }
        if (Vector2.Distance(transform.position, wp2.transform.position) < 0.2f)
        {
            currentTarget = wp1;
        }
        if (Vector2.Distance(transform.position, wp1.transform.position) < 0.2f)
        {
            currentTarget = wp0;
        }
        if (Vector2.Distance(transform.position, wp0.transform.position) < 0.2f)
        {
            forward = true;
            counter++;
        }
    }

    private IEnumerator Break1Co()
    {
        BreakForward();
        yield return new WaitForSeconds(0.01f);
        Route2Co = null;
    }
    private IEnumerator Break2Co()
    {
        BreakBackwards();
        yield return new WaitForSeconds(0.01f);
        Route2Co = null;
    }

}
