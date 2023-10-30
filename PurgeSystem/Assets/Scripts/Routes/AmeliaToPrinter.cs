using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeliaToPrinter : MonoBehaviour
{
    public int timesroutewalked;
    public float speed;
    private float step;
    public GameObject currentTarget;
    public GameObject wp0, wp1, wp2, wp3;
    Coroutine Route1Co;
    private bool forward;
    private int counter;
    private AmeliaToPrinter ameliaPrinterScript;
    private AmeliaAbout ameliaAboutScript;
    public GameObject amelia;

    private Animator _anim;
    public float animX;
    public float animY;
    public float moveMagnitude;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        ameliaPrinterScript = GetComponent<AmeliaToPrinter>();
        ameliaAboutScript = GetComponent<AmeliaAbout>();
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
        AmeliaMove();
        Animate();
    }
    private void AmeliaMove()
    {
        if (counter == 1)
        {
            counter = 0;
            ameliaAboutScript.enabled = true;
            ameliaPrinterScript.enabled = false;
            return;
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
                    Route1Co = StartCoroutine(AmeliaPrinterCo());
                }

                else
                {
                    Route1Co = StartCoroutine(AmeliaDeskCo());
                }
            }
        }
    }

    private void AmeliaPrinter()
    {
        amelia.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);

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
    private void AmeliaToDesk()
    {
        amelia.transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, step);
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

    private IEnumerator AmeliaPrinterCo()
    {
        AmeliaPrinter();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
    }
    private IEnumerator AmeliaDeskCo()
    {
        AmeliaToDesk();
        yield return new WaitForSeconds(0.01f);
        Route1Co = null;
    }
}