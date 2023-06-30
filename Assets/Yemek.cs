using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yemek : MonoBehaviour
{
    public BoxCollider2D serhed;

    private void Start()
    {
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.serhed.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "İlan")
        {
            RandomizePosition();
        }
    }
}
