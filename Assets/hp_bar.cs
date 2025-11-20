using UnityEngine;
using UnityEngine.UI;
public class hp_bar : MonoBehaviour
{
   public Slider slider;

    public hp HP;
    public void SetMaxHealth(int health)
    {  slider.value = health;
       slider.maxValue = HP. maxHealth;
    }
   
  public void SetHealth(int health)
    {
    slider.value = health;
    }
  

    
}
