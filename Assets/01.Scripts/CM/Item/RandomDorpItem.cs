using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDorpItem : MonoBehaviour
{
    [SerializeField] private List<GameObject> _item = new List<GameObject>();
    [SerializeField] private float _yCoordinate = 9f;
    [SerializeField] private float SpawnTime = 0.5f;
    private bool IsCanDrop = true;

    private void Update()
    {
        if(IsCanDrop)
        {
            StartCoroutine(DropItem());
        }
    }

    private IEnumerator DropItem()
    {
        IsCanDrop = false;
        int rand = Random.Range(0, _item.Count);
        float xCoordinate = Random.Range(-8.5f, 8.5f);
        Instantiate(_item[rand]);
        _item[rand].transform.position = new Vector2(xCoordinate, _yCoordinate);
        yield return new WaitForSeconds(SpawnTime);
        IsCanDrop = true;
    }
}
