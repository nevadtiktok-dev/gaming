using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject postac;
    private Transform target; // Referencja do obiektu gracza ustawiana w Inspectorze
    [SerializeField] private float moveSpeed = 3f; // Prędkość poruszania się potwora


    void Start()
    {
        target = GameObject.Find("Target").transform;

        if(GetComponent<PlayerHealth>() == null)
            return;
            
        postac.GetComponent<PlayerHealth>();
        PlayerHealth playerhealth = postac.GetComponent<PlayerHealth>();
        float health = playerhealth.health;      
    }
    private void Update()
    {
        // Obliczamy kierunek od potwora w stronę gracza
        Vector3 direction = target.position - transform.position;

        // Normalizujemy kierunek, aby zachować stałą prędkość
        Vector3 normalizedDirection = direction.normalized;

        // Przesuwamy potwora w stronę gracza z określoną prędkością
        transform.position += normalizedDirection * moveSpeed * Time.deltaTime;

        
    }

    void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy czy obiekt, z którym weszliśmy w kolizję, ma tag "bariera"
        if (other.gameObject.CompareTag("barrier"))
        {
            // Wywołujemy komendę zadawania obrażeń
            DealDamage(other.gameObject.GetComponent<PlayerHealth>());
            Destroy(this.gameObject);
        }
    }

    private void DealDamage(PlayerHealth health)
    {
        // Tutaj wpisz logikę zadawania obrażeń graczowi, prawdopodobnie player.DealDamage() i wtedy na graczu w skrypcie robimy ten skrypt
        health.takeDamage(Random.Range(5f, 10f));
    }
}