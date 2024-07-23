using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

    public float energyDecreaseRate = 0.1f;
    public float energyIncreaseRate = 1.0f;
    public Image energyBarImage;

    //comentarios
    private float currentEnergy = 100.0f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // Decrease energy over time
        currentEnergy -= energyDecreaseRate * Time.deltaTime;

        // Update energy bar
        energyBarImage.fillAmount = currentEnergy / 100.0f;
    }

    public void IncreaseEnergy(float amount)
    {
        currentEnergy += amount;
        currentEnergy = Mathf.Clamp(currentEnergy, 0.0f, 100.0f);
    }
}
