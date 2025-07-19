using UnityEngine;

public class TiroSimples : MonoBehaviour
{
    public GameObject projetilPrefab;
    public float forcaTiro = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projetil = Instantiate(projetilPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.right * forcaTiro;
        }
    }
}