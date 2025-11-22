using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject ghostPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(SpawnGhosts());
    }

    private IEnumerator SpawnGhosts()
    {   
        
        float b1 = 2;//poczatkowy
        while (true)
        {   
            
            
        
            
            float z1 = UnityEngine.Random.Range(-209f, -197f);//z w jakim moze sie respic
            float x1 = UnityEngine.Random.Range(0f, 5f);
            
        
            Instantiate(ghostPrefab, new Vector3(x1, transform.position.y, z1), Quaternion.Euler(-90, 0, 180));
            yield return new WaitForSeconds(b1);
          if(b1>0.2f){  
          b1-=0.01f;
          
                    }
          Debug.Log(b1);
        }
    }
}
