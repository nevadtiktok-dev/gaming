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

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.CompareTag("kill_variable"))
        {
            Debug.Log(other.gameObject.name + " hit");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        
    }
    

}

