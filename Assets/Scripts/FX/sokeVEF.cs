using UnityEngine;

public class sokeVEF : MonoBehaviour

{
    public GameObject oncollectEffect;

    int doorDamageLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fireball")
        {
            Debug.Log("Fireball : " + collision.gameObject.name);
            Instantiate(oncollectEffect, transform.position, transform.rotation);
            //DamageDoor();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
