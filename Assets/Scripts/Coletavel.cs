using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public AudioClip somColeta;

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(somColeta, transform.position);
            Destroy(gameObject);
        }
    }
}