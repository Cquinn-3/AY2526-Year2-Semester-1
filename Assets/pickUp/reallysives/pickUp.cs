using UnityEngine;
using Unity.VisualScripting;

public class pickUp : MonoBehaviour
{
    public GameObject oncollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
        Destroy(gameObject);
        Instantiate(oncollectEffect, transform.position, transform.rotation);
        
    }

}
