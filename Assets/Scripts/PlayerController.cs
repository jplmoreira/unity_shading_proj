using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

    float camera_rotation;


    // Start is called before the first frame update
    void Start()
    {
        camera_rotation = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position.Set(this.transform.position.x + 3, this.transform.position.y + 3, this.transform.position.z + 3);
        camera.transform.LookAt(this.transform); // para olhar para o player


    }
}
