using UnityEngine;

public class InimigoSeguir : MonoBehaviour
{
    public Transform alvo;
    public float velocidade = 3f;

    void Update()
    {
        if (alvo != null)
        {
            Vector3 direcao = (alvo.position - transform.position).normalized;
            transform.position += direcao * velocidade * Time.deltaTime;
        }
    }
}
