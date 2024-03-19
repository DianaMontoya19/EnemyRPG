using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public Animator anim;
    public float speed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = Player.position;
        anim.SetBool("Walk", true);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //anim.SetBool("Walk", false);
            Debug.Log("Choco");
        }
    }
}
