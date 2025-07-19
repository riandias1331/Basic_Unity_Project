using UnityEngine;

public class JogadorAtira : MonoBehaviour
{
    public GameObject prefabProjetil;
    public Transform pontoDeSaida;
    public float tempoEntreTiros = 0.5f;
    private float cronometro = 0f;

    void Update()
    {
        cronometro += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && cronometro >= tempoEntreTiros)
        {
            Instantiate(prefabProjetil, pontoDeSaida.position, pontoDeSaida.rotation);
            cronometro = 0f;
        }
    }
}