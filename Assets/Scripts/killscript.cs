using UnityEngine;

public class killscript : MonoBehaviour
{
    public GameObject postac;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (Input.GetMouseButtonDown(0) && other.CompareTag("kill_variable"))
        {
            Debug.Log("dziala");
        }
    }
    

}

