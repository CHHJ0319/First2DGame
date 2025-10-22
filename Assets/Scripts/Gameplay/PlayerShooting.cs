using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    float throwX = 5;
    float throwY = 0;
    float offsetX = 0.7f;
    float offsetY = 0.5f;

    public GameObject canonball;
    public int maxCount = 20;

    bool pushFlag = false;
    bool leftFlag = false;

    void Update()
    {
        if (Input.GetKey("right"))
        {
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            leftFlag = true;
        }
        if (Input.GetKey("space"))
        {
            if (pushFlag == false)
            {
                pushFlag = true;

                Vector3 newPos = this.transform.position;
                if (leftFlag)
                {
                    newPos.x -= offsetX;
                    canonball.GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                    newPos.x += offsetX;
                    canonball.GetComponent<SpriteRenderer>().flipX = false;
                }
                newPos.y += offsetY;

                GameObject canonBallGameObject = Instantiate(canonball);
                newPos.z = -5;
                canonBallGameObject.transform.position = newPos;

                Rigidbody2D rbody = canonBallGameObject.GetComponent<Rigidbody2D>();
                if (leftFlag)
                {
                    rbody.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
                }
                else
                {
                    rbody.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
                }
            }
        }
        else
        {
            pushFlag = false;
        }
    }
}
