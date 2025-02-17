 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class HealthBar : NetworkBehaviour
{
    // Start is called before the first frame update
    public Gradient gradient;
    public Slider slider;
    public Image fill;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health) 
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
