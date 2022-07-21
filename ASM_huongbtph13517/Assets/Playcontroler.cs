using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Playcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    public static int diem = 0;
    Animator animator;
    string state = "state";
    public float jumb;
    private AudioSource audio;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumb);
            animator.SetInteger(state, 1);
        }else
        { animator.SetInteger(state, 2); }    
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("vang"))
        {
            Destroy(col.gameObject);
            Text text = GameObject.Find("diem").GetComponent<Text>();
            diem += 1;

            text.text = diem + "";
            audio.Play();

        }
    }
}
