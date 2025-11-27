using UnityEngine;

public class FireBall : MonoBehaviour
{

   // public float bulletSpeed = 10f;
    //public float shootCooldown = 0.1f;
    public float launchVelocity = 700f;
    public GameObject fBall;
    public GameObject spawnpoint;
    public GameObject onCollectEffect;
   
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Has shot");
            GameObject FBall = Instantiate(fBall,transform.position,transform.rotation);
            FBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
        }
    }

    //public void OnCollision(Collider other)
    //{
    //    Debug.Log("Collided");
    //    if (other.CompareTag("Wall"))
    //    {
    //        Instantiate(onCollectEffect, transform.position, transform.rotation);
    //        Debug.Log("hit wall");
    //    }
    //}
}