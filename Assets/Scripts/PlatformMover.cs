using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float speed;
    public Vector3 target;
    private Vector3 pos, dir;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        dir = (target - pos).normalized;
    }

    private void FixedUpdate()
    {
        if ((target - transform.position).magnitude > (target-pos).magnitude)
        {
            Vector3 aux = target;
            target = pos;
            pos = aux;
            dir = (target - pos).normalized;
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }

        GetComponent<Rigidbody>().AddForce(dir * speed);
    }
}
