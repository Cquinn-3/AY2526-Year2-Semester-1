using UnityEngine;
using UnityEngine.UI;
public class hp : MonoBehaviour
{
    public int maxHealth = 100;
    public int cyrrentHealth;

    public hp_bar bar;
    //public Healthbar healthBar;
    void Start()
    {
        cyrrentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            TakeDamge(20);
        }
    }

    void TakeDamge(int damage)
    {
        cyrrentHealth -= damage;
        bar.slider.value -= damage;
    }


}
