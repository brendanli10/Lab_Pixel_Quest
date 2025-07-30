using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUIController : MonoBehaviour
{
    public TextMeshProUGUI TMPU;
    public Image heartImage;
    public void StartUI()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        TMPU = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(string newText) { TMPU.text = newText; }

    public void UpdateHealth(float Health, float maxHealth)
    {
        heartImage.fillAmount = Health / maxHealth;
    }
}
