using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollor : MonoBehaviour
{
    
    public Vector3 offset;
    public float t;


    // Update is called once per frame
    void Update()
    {
        if (PlayerSingleton.pInstance != null)
        {
            if (transform.position != PlayerSingleton.pInstance.pTransform.position + offset)
            {
                transform.position = new Vector3(Mathf.Lerp(transform.position.x, PlayerSingleton.pInstance.pTransform.position.x + offset.x, t), Mathf.Lerp(transform.position.y, PlayerSingleton.pInstance.pTransform.position.y + offset.y, t), Mathf.Lerp(transform.position.z, PlayerSingleton.pInstance.pTransform.position.z + offset.z, t));
            }
        }
        
    }
}
