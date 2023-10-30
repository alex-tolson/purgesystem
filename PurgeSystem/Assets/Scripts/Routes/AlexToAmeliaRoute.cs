using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexToAmeliaRoute : MonoBehaviour
{
    public int timesroutewalked;
    public float speed;
    private float step;
    public GameObject currentTarget;
    public GameObject wp0, wp7, wp8, wp9, wp10, wp11, wp12, wp13, wp14, wp15;
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
            alexBreakRouteScript.enabled = true;
            toAmeliaRouteScript.enabled = false;
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
        alex.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

        if (Vector2.Distance(transform.position, wp0.transform.position) < 0.2f)
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
            currentTarget = wp10;
        }
        if (Vector2.Distance(transform.position, wp10.transform.position) < 0.2f)
        {
            currentTarget = wp11;
        }
        if (Vector2.Distance(transform.position, wp11.transform.position) < 0.2f)
        {
            currentTarget = wp12;
        }
        if (Vector2.Distance(transform.position, wp12.transform.position) < 0.2f)
        {
            currentTarget = wp13;
        }
        if (Vector2.Distance(transform.position, wp13.transform.position) < 0.2f)
        {
            currentTarget = wp14;
        }
        if (Vector2.Distance(transform.position, wp14.transform.position) < 0.2f)
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
        alex.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);
        if (Vector2.Distance(transform.position, wp14.transform.position) < 0.2f)
        {
            currentTarget = wp13;
        }
        if (Vector2.Distance(transform.position, wp13.transform.position) < 0.2f)
        {
            currentTarget = wp15;
        }
        if (Vector2.Distance(transform.position, wp15.transform.position) < 0.2f)
        {
            currentTarget = wp9;
        }
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

