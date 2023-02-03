using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollor : MonoBehaviour
{

    public GameObject player;
    private Transform pt;
    public Vector3 offset;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Ranger");
        pt = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != pt.position + offset)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, pt.position.x + offset.x, t), Mathf.Lerp(transform.position.y, pt.position.y + offset.y, t), Mathf.Lerp(transform.position.z, pt.position.z + offset.z, t));
        }
        
    }
}
