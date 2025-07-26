using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image heartImage;
    private void Start()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    public void UpdateHealth(float Health, float maxHealth)
    {
        heartImage.fillAmount = Health / maxHealth;
    }
}
