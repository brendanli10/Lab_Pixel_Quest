using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "PQLevel2";
    public int coinCount = 0;
    public int Health = 3;
    public int maxHealth = 3;
    private PlayerUIController _PUC;
    public Transform RespawnPoint;

   private void Start()
    {
        _PUC = GetComponent<PlayerUIController>();
        _PUC.UpdateHealth(Health, maxHealth);
    } 
private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Death": //damage system
                {
                    Health--;
                    _PUC.UpdateHealth(Health, maxHealth);
                    if (Health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                    break;
                }
            case "Finish":
                {
                    string nextLevel = other.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(other.gameObject);
                    break;
                }
            case "Health":
                {
                    if (Health < 3)
                    {
                        Health++;
                        _PUC.UpdateHealth(Health, maxHealth);
                        Destroy(other.gameObject);
                    }
                    break;
                }
            case "Respawn":
                {
                    RespawnPoint.position = other.transform.Find("Point").position;
                    break;
                }
        }
    }
}