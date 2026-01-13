using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;

public class dodajhp : Interactable
{
    public GameObject duszek;
     
    void Start()
    {
        float r1 = UnityEngine.Random.Range(-209f, -197f);
        float r2 = UnityEngine.Random.Range(6f, -2f);
        duszek.SetActive(true);
        
    }

     
    void Update()
    {
        
    }

    protected override void Interact()
    {
        float r1 = UnityEngine.Random.Range(-209f, -197f);
        float r2 = UnityEngine.Random.Range(6f, -2f);
        duszek.SetActive(true);
        duszek.transform.position = new Vector3(r1, 1.6f, r2);
        Instantiate(duszek,new Vector3(r1, 1.6f, r2), Quaternion.identity);
        duszek.transform.position = new Vector3(r1, 1.6f, r2);
    }

    
}
