using UnityEngine;
using UnityEngine.UI;
public class hp_bar : MonoBehaviour
{
   public Slider slider;
    public void SetMaxHealth(int health)
    {  slider.value = health;
       slider.maxValue = health;
    }
   
  public void SetHealth(int health)
    {
    slider.value = health;
    }
  

    
}
