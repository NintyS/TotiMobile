using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour
{
    private void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("Clicked");
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().ClickedOn(new Vector3(transform.position.x, transform.position.y, transform.position.z));
    }
}
