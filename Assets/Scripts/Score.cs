using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameController.Instancia != null && GameController.Instancia.score != null)
            {
                GameController.Instancia.score.AddScore(score);
                gameObject.SetActive(false);
            }
        }
        }
}
