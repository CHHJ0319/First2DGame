using UnityEngine;

public class CanonballController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�浹! " + collision.gameObject.name + "�� �ε������ϴ�.");
        DestroySelf();
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
