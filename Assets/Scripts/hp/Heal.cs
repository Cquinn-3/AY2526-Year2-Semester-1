using UnityEngine;

public class Heal : MonoBehaviour
{
    public hp phealth;
    public int heal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            phealth.healDamage(heal);

    }

    }
}
