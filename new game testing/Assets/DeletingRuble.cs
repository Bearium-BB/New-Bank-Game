using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingRuble : MonoBehaviour
{
    float scale = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale -= new Vector3(scale, scale, scale);
        if (gameObject.transform.localScale.x <= 0)
        {
            Destroy(gameObject);
        }
    }
}
