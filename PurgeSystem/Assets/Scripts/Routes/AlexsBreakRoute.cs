using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexsBreakRoute : MonoBehaviour
{
    public int timesroutewalked;
    public float speed;
    private float step;
    public GameObject currentTarget;
    public GameObject wp0, wp1, wp2, wp3, wp4, wp5, wp6;
    Coroutine Route1Co;
    private bool forward;
    private int counter;
    private AlexsBreakRoute alexBreakRouteScript;
    private AlexToAmeliaRoute toAmeliaRouteScript;
    public GameObject alex;

    private Animator _anim;
    public float animX;
    public float animY;
    public float moveMagnitude;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        alexBreakRouteScript = GetComponent<AlexsBreakRoute>();
        toAmeliaRouteScript = GetComponent<AlexToAmeliaRoute>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Route1Co = null;
        step = speed * Time.fixedDeltaTime;
        currentTarget = wp0;
        forward = true;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timesroutewalked = counter;
        AlexMove();
        Animate();
    }
    private void AlexMove()
    {
        if (counter == 1)
        {
            counter = 0;
            toAmeliaRouteScript.enabled = true;
            alexBreakRouteScript.enabled = false;
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
                    Route1Co = StartCoroutine(AlexBreakRoomCO());
                }

                else
                {
                    Route1Co = StartCoroutine(AlexAmeilaCO());
                }
            }
        }
    }

    private void AlexBreakRoom()
    {
        transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

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
            currentTarget = wp6;
        }
        if (Vector2.Distance(transform.position, wp6.transform.position) < 0.2f)
        {
            forward = false;
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
    private void AlexAmeila()
    {
        transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);
        if (Vector2.Distance(transform.position, wp6.transform.position) < 0.2f)
        {
            currentTarget = wp5;
        }
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

    private IEnumerator AlexBreakRoomCO()
    {
        AlexBreakRoom();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
    }
    private IEnumerator AlexAmeilaCO()
    {
        AlexAmeila();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
    }

}
