
using UnityEngine;
using UnityEngine.AI;
//using UnityEngine.InputSystem;

public class BadGuymove : MonoBehaviour
{
    public float lookRadius = 10f;
    Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = PlayerMager.Instance.player.transform;
        agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <=lookRadius)
        {
            agent.SetDestination(target.position);
            if(distance <= agent.stoppingDistance)
            {

                //attck the player 
                //face the target 
            }
        }
    }
    void FaceceTatget ()
    {
       Vector3 direction = (target.position - transform.position).normalized;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
