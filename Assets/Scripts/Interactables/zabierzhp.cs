using Unity.VisualScripting;
using UnityEngine;

public class zabierzhp : Interactable
{
    public GameObject postac;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        postac.GetComponent<PlayerHealth>();
        PlayerHealth playerhealth = postac.GetComponent<PlayerHealth>();
        float health = playerhealth.health;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        PlayerHealth playerHealth = postac.GetComponent<PlayerHealth>();
        playerHealth.takeDamage(20f);
    }
}
