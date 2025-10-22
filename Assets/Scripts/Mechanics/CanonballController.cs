using UnityEngine;

public class CanonballController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ãæµ¹! " + collision.gameObject.name + "¿Í ºÎµúÇû½À´Ï´Ù.");
        DestroySelf();
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
