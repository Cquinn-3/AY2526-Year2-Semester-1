using UnityEngine;
using UnityEngine.UI;
public class hp : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    public Image HealthBar;

    void Start()
    {
        Health = MaxHealth;
    }

    private void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(Health / MaxHealth, 0, 1);
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Hit");
        Health -= damage;
        
    }

    public void healDamage(int heal)
    {

        Health += heal; 
    }



}
