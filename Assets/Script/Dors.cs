using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dors : MonoBehaviour
{
    //private Levelmanager lm;
    public bool haveKey = false;

    void Start()
    {
        //lm = GameObject.Find("RoomManager").GetComponent<Levelmanager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (haveKey)
        {
            GetComponent<Animator>().SetBool("opened", true);
            //lm.ChangeLevel();
        }
    }

    public void HaveKey()
    {
        haveKey = true;
    }
}
