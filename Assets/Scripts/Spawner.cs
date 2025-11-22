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
        
        while (true)
        {   float r1 = UnityEngine.Random.Range(5f, 10f);//poczatkowy
            float b1 = 1;//poczatkowy
            
        if(b1==b1+3){
            r1 = UnityEngine.Random.Range(-4f, -8f);
            float z1 = UnityEngine.Random.Range(-209f, -197f);
            float x1 = UnityEngine.Random.Range(0f, 5f);
            
            }
        else{
            float z1 = UnityEngine.Random.Range(-209f, -197f);
            float x1 = UnityEngine.Random.Range(0f, 5f);
            Instantiate(ghostPrefab, new Vector3(x1, transform.position.y, z1), Quaternion.Euler(-90, 0, 180));
            yield return new WaitForSeconds(r1);
            b1=b1+1;
            }
            Debug.Log(b1);
            Debug.Log(r1);
        }
    }
}
