using UnityEngine;

public class kloc : Interactable
{
    public GameObject siusiak;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        siusiak.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        siusiak.SetActive(true);
    }
}
