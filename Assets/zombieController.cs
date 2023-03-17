using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour
{

    Transform player;
    


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        transform.LookAt(player.position);
        
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
