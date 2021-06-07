using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon : MonoBehaviour
{
    RaycastHit hit;
    public int tool = 10;
    public int damage = 1;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit);
            var i = hit.transform.gameObject.GetComponent<destructibleWalls>();
            if(i != null)
            {
                i.dodamage(tool, damage);
                GameObject ii = Instantiate(prefab, hit.point, gameObject.transform.rotation);
                TextMeshPro iii = ii.GetComponentInChildren<TextMeshPro>();
                iii.text = damage.ToString();
                Destroy(ii, 0.5f);
                iii = null;
                Debug.Log(damage.ToString());
            }
            i = null;
        }

    }
}
