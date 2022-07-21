using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nendat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject wall;
    void Start()
    {
        StartCoroutine(auto());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator auto()
    {
        yield return new WaitForSeconds(2.3f);
        Vector3 temp = wall.transform.position;
        temp.y = Random.Range(-7f, -3.3f);
        Instantiate(wall, temp, Quaternion.identity);
        StartCoroutine(auto());
    }
}
