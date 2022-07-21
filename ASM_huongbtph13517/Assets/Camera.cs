using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 ofset;
    [Range(1, 10)]
    public float muot;
    private void FixedUpdate()
    {
        Vector3 targetPostion = target.position + ofset;
        Vector3 domuot = Vector3.Lerp(transform.position, targetPostion, muot * Time.fixedDeltaTime);
        transform.position = targetPostion;
    }
}
