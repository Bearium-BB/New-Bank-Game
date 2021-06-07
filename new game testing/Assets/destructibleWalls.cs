using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructibleWalls : MonoBehaviour
{
    public int durability;
    public int BreakingLevel;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void dodamage(int tool , int damage)
    {
        if(tool >= BreakingLevel)
        {
            durability -= damage;
            BeingDestroyed();
        }
    }
    void BeingDestroyed()
    {
        if(durability <= 0)
        {
            Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
