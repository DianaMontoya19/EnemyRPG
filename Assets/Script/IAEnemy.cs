using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{
    public Transform Player;
    private NavMeshAgent agent;
    public GameObject ia;
    private Animator anim;
    public bool prueba = true;
    public float speed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        prueba = true;
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
            
            prueba = false;
            Debug.Log("Choco");
        }
    }
}
