using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Player1HealthSystem healthSystem;
    public Image fillImage;
    public Slider slider;


    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }
        float fillValue = healthSystem.currentHealth / healthSystem.maxhealth;
        if (fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.white;
        }
        slider.value = fillValue;
    }
}