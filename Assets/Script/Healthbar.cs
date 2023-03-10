using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBar;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }
}
