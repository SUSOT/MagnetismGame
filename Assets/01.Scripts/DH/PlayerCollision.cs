using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public ZasungChanger tmpChanger; 
    public int score = 0;
    public int heartCount = 5;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI heartCountText;

    private void Start()
    {
        UpdateUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string objectTag = collision.gameObject.tag;
        string currentTag = tmpChanger.GetCurrentTag();

        if (objectTag == currentTag)
        {
            score++;
        }
        else
        {
            heartCount--;
        }

        UpdateUI();

        if (heartCount <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score.ToString();
        heartCountText.text = "Hearts: " + heartCount.ToString();
    }
}
