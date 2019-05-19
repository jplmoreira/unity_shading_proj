using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{

    public Transform pushText;

    private bool pushable, pushed, pushing;
    // Start is called before the first frame update
    void Start()
    {
        pushable = false;
        pushed = false;
        pushing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pushable && Input.GetKeyDown(KeyCode.E))
        {
            pushing = true;
        }
    }

    void FixedUpdate()
    {
        if (pushing)
        {
            GetComponent<Rigidbody>().AddForce(transform.right * 1000f, ForceMode.Force);
            pushing = false;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && !pushed)
        {
            pushable = true;
            pushText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            pushable = false;
            pushText.gameObject.SetActive(false);
        }
    }
}
