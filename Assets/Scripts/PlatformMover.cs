using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float speed;
    public Vector3 target;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.localPosition;
    }

    private void FixedUpdate()
    {
        Vector3 currPos = transform.localPosition;
        if ((currPos - target).magnitude <= 1f)
        {
            Vector3 aux = target;
            target = pos;
            pos = aux;
        }
        transform.localPosition = Vector3.MoveTowards(currPos, target, speed * Time.deltaTime);
    }
}
