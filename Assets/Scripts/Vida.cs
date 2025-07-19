using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida = 3;
    public bool destruirAoMorrer = true;

    public void LevarDano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            if (destruirAoMorrer)
                Destroy(gameObject);
            else
                gameObject.SetActive(false);

            // Se for o jogador:
            if (CompareTag("Player"))
                FindObjectOfType<GameManager>().ReiniciarFase();
        }
    }
}