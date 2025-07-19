using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float tempoDeVida = 2f;
    public int dano = 1;

    void Start()
    {
        Destroy(gameObject, tempoDeVida);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Inimigo"))
        {
            // Dano no inimigo aqui se ele tiver script de vida
            Destroy(gameObject);
        }
    }
}
