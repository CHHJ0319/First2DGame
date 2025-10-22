using System.Collections;
using UnityEngine;

public class CanonballController : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(CallFunctionAfterDelay(0.5f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�浹! " + collision.gameObject.name + "�� �ε������ϴ�.");
        DestroySelf();
    }
    IEnumerator CallFunctionAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        DestroySelf();
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
