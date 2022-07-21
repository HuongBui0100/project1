using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer bg;
    public float speed;
    float of;
    void Start()
    {
        bg = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        of += Time.deltaTime * speed;
        bg.material.SetTextureOffset("_MainTex", new Vector2(of, 0));
    }
}
