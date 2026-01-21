using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {;

        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -100f)
        {
            Destroy(gameObject);
        }
    }
}
