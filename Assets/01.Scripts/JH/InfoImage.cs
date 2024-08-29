using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoImage : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void OnActive()
    {
        gameObject.SetActive(true);
    }
    public void OffActive()
    {
        gameObject.SetActive(false);
    }
}
