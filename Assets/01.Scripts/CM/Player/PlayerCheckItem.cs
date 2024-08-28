using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckItem : MonoBehaviour
{
    public ChangeText changeText;
    private int nowState;
    public int nowScore;
    public int nowHeart = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("A1") && changeText.CheckInt == 0)
        {
            nowScore++;
        }
        else if (collision.gameObject.CompareTag("B1") && changeText.CheckInt == 1)
        {
            nowScore++;
        }
        else if (collision.gameObject.CompareTag("C1") && changeText.CheckInt == 2)
        {
            nowScore++;
        }
        else if(collision.gameObject.CompareTag("HealItem"))
        {
            nowHeart++;
        }
        else
        {
            nowHeart--;
        }

        Destroy(collision.gameObject);
    }
}
