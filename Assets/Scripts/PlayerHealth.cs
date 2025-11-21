using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float health;
    private float lerpTimer;
    public float maxHealth = 100f;
    public float chipSpeed = 2f;
    public Image frontHealthBar;
    public Image backHealthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        health = Mathf.Clamp(health, 0, maxHealth);
        UpdateHealthUI();
        if (Input.GetKeyDown(KeyCode.B))
        {
            takeDamage(Random.Range(5, 10));
        }
    }
    public void UpdateHealthUI()
    {
        
        Debug.Log(health);
    }

    // Update is called once per frame
    public void takeDamage(float damage)
    {
        health -= damage;
        lerpTimer = 0f;
    }
    
}
