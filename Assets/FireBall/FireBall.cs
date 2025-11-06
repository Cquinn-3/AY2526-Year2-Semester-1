using UnityEngine;

public class FireBall : MonoBehaviour
{

   // public float bulletSpeed = 10f;
    //public float shootCooldown = 0.1f;
    public float launchVelocity = 700f;
    public GameObject Projectl;
   
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Has shot");
            GameObject FBall = Instantiate(Projectl,transform. position,transform.rotation);
            FBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity));
        }
    }
}