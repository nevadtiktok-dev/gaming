
using UnityEngine;

public class Movmentscript : MonoBehaviour
{
    [SerializeField] private float speed = 3f; // prędkość lotu
    private Transform target;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Wyłączamy wpływ fizyki – inaczej będzie hamował
        rb.useGravity = false;
        rb.linearDamping = 0f;
        rb.angularDamping = 0f;
        rb.freezeRotation = true;

        // Szukanie celu
        GameObject foundTarget = GameObject.FindGameObjectWithTag("Cel");
        if (foundTarget != null)
            target = foundTarget.transform;
        else
            Debug.LogWarning("Nie znaleziono obiektu z tagiem 'Cel'");
    }

    void FixedUpdate()
    {
        if (target == null) return;

        // Stały ruch w stronę celu
        Vector3 direction = (target.position - transform.position).normalized;
        Vector3 newPos = transform.position + direction * speed * Time.fixedDeltaTime;

        rb.MovePosition(newPos);
    }
}
