using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeText : MonoBehaviour
{
    public TMP_Text Score;
    public TMP_Text Heart;
    public TMP_Text Magnetic;
    public List<string> MagneticList = new List<string>();
    [SerializeField] private float ChangeTime = 15f;
    public PlayerCheckItem CheckItem;
    public int CheckInt;

    private void Start()
    {
        StartCoroutine(ChangeMagnetic());
    }

    private IEnumerator ChangeMagnetic()
    {
        Magnetic.text = null;
        int a = Random.Range(0, 3);
        Magnetic.text = MagneticList[a];
        CheckInt = a;
        yield return new WaitForSeconds(ChangeTime);
        StartCoroutine(ChangeMagnetic());
    }

    private void Update()
    {
        Score.text = "Score : " + CheckItem.nowScore.ToString();
        Heart.text = "Heart : " + CheckItem.nowHeart.ToString();

        if(CheckItem.nowHeart <= 0)
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
}
