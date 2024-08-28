using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZasungChanger : MonoBehaviour
{
    public TextMeshProUGUI tmpText;
    private string currentTag;
    private float timer = 0f;
    private float interval = 15f;

    private void Start()
    {
        ChangeTextAndTag();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            ChangeTextAndTag();
            timer = 0f;
        }
    }

    private void ChangeTextAndTag()
    {
        int rand = Random.Range(0, 3);

        switch (rand)
        {
            case 0:
                tmpText.text = "悪切失端";
                currentTag = "A1";
                break;
            case 1:
                tmpText.text = "雌切失端";
                currentTag = "B1";
                break;
            case 2:
                tmpText.text = "鋼切失端";
                currentTag = "C1";
                break;
        }
    }

    public string GetCurrentTag()
    {
        return currentTag;
    }
}
