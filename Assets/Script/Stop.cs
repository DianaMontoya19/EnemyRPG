using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public Animator anim;
    public IAEnemy ia;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ia.prueba == false)
        {
            anim.SetBool("Walk", false);
            ia.enabled = false;
        }
    }

}
