using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobsOfficeRoute : MonoBehaviour
{
    public int timesroutewalked;
    public float speed;
    private float step;
    public GameObject currentTarget;
    public GameObject wp0, wp1, wp2, wp3, wp4, wp5, wp6, wp7, wp8, wp9;
    public Coroutine Route1Co;
    public bool forward;
    public int counter;
    private BobsOfficeRoute officeRouteScript;
    private BobsBreakRoute breakRouteScript;
    private Rigidbody2D _rb;
    public GameObject bob;
    private Animator _anim;
    public float animX;
    public float animY;
    public float moveMagnitude;
    //public Vector2 velocityXY;


    private void Awake()
    {
        officeRouteScript = GetComponent<BobsOfficeRoute>();
        breakRouteScript = GetComponent<BobsBreakRoute>();
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        currentTarget = wp0;
        counter = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Route1Co = null;
        step = speed * Time.fixedDeltaTime;
        forward = true;
    }

    // Update is called once per frame
    void Update()
    {
        //velocityXY = _rb.velocity; // if position is getting going negative, player is moving 

        timesroutewalked = counter;
        BobMove();
        Animate();
    }
    private void BobMove()
    { 
        if (counter == 1)
        {
            counter = 0;
            breakRouteScript.enabled = true;
            officeRouteScript.enabled = false;
        }
        else
        {
            if (Route1Co != null)
            {
                return;
            }
            else
            {
                if (forward)
                {
                    Route1Co = StartCoroutine(Office1RouteCo());
                }
                else
                {
                    Route1Co = StartCoroutine(Office2RouteCo());
                }
            }
        }
    }


    private void Route1Office1Forward()
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
            currentTarget = wp4;
        }
        if (Vector2.Distance(transform.position, wp4.transform.position) < 0.2f)
        {
            currentTarget = wp5;
        }
        if (Vector2.Distance(transform.position, wp5.transform.position) < 0.2f)
        {
            forward = false;
        }
    }

    private void Route1Office1Backwards()
    {
        bob.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

        if (Vector2.Distance(transform.position, wp5.transform.position) < 0.2f)
        {
            currentTarget = wp4;
        }
        if (Vector2.Distance(transform.position, wp4.transform.position) < 0.2f)
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

    private IEnumerator Office1RouteCo()
    {
        Route1Office1Forward();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
    }
    private IEnumerator Office2RouteCo()
    {
        Route1Office1Backwards();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
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
}
