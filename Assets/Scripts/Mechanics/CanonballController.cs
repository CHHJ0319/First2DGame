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
        Debug.Log("Ãæµ¹! " + collision.gameObject.name + "¿Í ºÎµúÇû½À´Ï´Ù.");
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
