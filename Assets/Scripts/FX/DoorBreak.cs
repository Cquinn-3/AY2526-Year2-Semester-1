using UnityEngine;
using UnityEngine.Audio;

public class DoorBreak : MonoBehaviour
{
    public GameObject doorHealth1;
    public GameObject doorHealth2;
    public GameObject doorHealth3;
    public GameObject oncollectEffect;

    int doorDamageLevel;


    void Start()
    {
        doorHealth1.SetActive(true);
        doorHealth2.SetActive(false);
        doorHealth3.SetActive(false);

        doorDamageLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DamageDoor();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fireball")
        {
            Debug.Log("Fireball : " + collision.gameObject.name);
            DamageDoor();
        }
    }

    void DamageDoor()
    {
        Instantiate(oncollectEffect, this.gameObject.transform.localPosition, this.gameObject.transform.localRotation);
        doorDamageLevel++; //damaget goes to 1, 2 ,3
        soundManager.PlaySound(SoundType.WallBeracking, 1f);

        //switch between door damages
        switch (doorDamageLevel)
        {
            case 1:
                Debug.Log("door damage level 1");
                doorHealth1.SetActive(false);
                doorHealth2.SetActive(true);
                doorHealth3.SetActive(false);
                break;
            case 2:
                Debug.Log("door damage level 2");
                doorHealth1.SetActive(false);
                doorHealth2.SetActive(false);
                doorHealth3.SetActive(true);

                this.gameObject.GetComponent<Collider>().enabled = false;

                break;
            default:
                Debug.Log("no door left");
                break;




        }
    }
}
