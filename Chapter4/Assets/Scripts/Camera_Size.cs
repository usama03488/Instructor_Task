using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Size : MonoBehaviour
{
    private Transform player;
    private Transform enyme;
    private Vector3 camerainitial;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>().transform;
        enyme = GameObject.Find("Enemy").GetComponent<Transform>().transform;
        camerainitial = transform.position;
        position=player.position - enyme.position ;

    }

    // Update is called once per frame
    void Update()
    {
        if(position.x < 5f && position.z<5f) {
            transform.position = new Vector3(camerainitial.x - 5f, camerainitial.y - 5f, camerainitial.z - 5f);

        }
        else
        {
            transform.position = camerainitial;
        }
        
    }
}
