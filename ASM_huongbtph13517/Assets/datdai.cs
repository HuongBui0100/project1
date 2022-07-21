using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datdai : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ler")
        {
            Destroy(gameObject);
        }
    }

}
