using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scored) return;

        if (collision.CompareTag("Bird"))
        {
            scored = true;
            GameManager.instance.AddScore();
            Debug.Log("SCORE BERTAMBAH");
        }
    }
}
