using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private float countdown = 5f;

    private ajatopi waveSpawner;

    // private void Start()
    // {
    //     waveSpawner = GetComponentInParent<ajatopi>();
    // }
    // private void Update()
    // {
    //     transform.Translate(transform.forward * speed * Time.deltaTime);

    //     countdown -= Time.deltaTime;

    //     if (countdown <= 0)
    //     {
    //         Destroy(gameObject);

    //         waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
    //     }
    // }
}
