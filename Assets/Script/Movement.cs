using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 goTo;
    private Vector3 pos;

    private Rigidbody rb;

    private readonly float speed = 0.05f;

    private Animator anim;

    void Start()
    {
        Debug.Log("Setup");
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (goTo == Vector3.zero)
        {
            return;
        }

        if(Vector3.Distance(pos, goTo) < 1)
        {
            anim.SetBool("walking", true);
            return;
        }

        anim.SetBool("walking", true);

        float angle = Mathf.Atan2(goTo.x - transform.position.x, goTo.z - transform.position.z) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, angle, 0);

        pos = Vector3.MoveTowards(transform.position, goTo, speed);
        rb.MovePosition(pos);
    }

    public void ClickedOn(Vector3 obiectPosition)
    {
        Debug.Log("ClickedOn");
        goTo = new Vector3(obiectPosition.x, 0, obiectPosition.z);
    }
}
