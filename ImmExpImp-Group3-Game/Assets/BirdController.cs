using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    public LayerMask whatIsGround, whatIsPlayer;

    public Transform player;

    public Transform[] target;
    public float speed;
    FieldOfView BirdVision;
    Animator birdAni;
    private int current;
    // Start is called before the first frame update
    void Start()
    {
        
        BirdVision = GetComponent<FieldOfView>();
        birdAni = GetComponent<Animator>();
        birdAni.SetBool("flying", true);

        agent.SetDestination(target[current].position);
        transform.LookAt(target[current]);


    }

    // Update is called once per frame
    void Update()
    {

   

     if (BirdVision.canSeePlayer == true)
     {
       
            //Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            agent.SetDestination(player.position);
            transform.LookAt(player);

                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (agent.velocity.sqrMagnitude < 1)
                    {
                       Debug.Log("TEST");
                    birdAni.SetBool("flying", false);

                    birdAni.SetBool("peck", true);


                }
            }
            

     }



        if (BirdVision.canSeePlayer == false)
        {
      
          
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (agent.velocity.sqrMagnitude < 1)
                    {
                        current = (current + 1) % target.Length;
                        agent.SetDestination(target[current].position);
                        transform.LookAt(target[current]);
                     }
                 }
            


        }





    }


}
