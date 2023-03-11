using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overmind : MonoBehaviour
{

    AtmosphereManager atmoM;
    Transitioner TransitionSheet;

    public float atmoPace;
    public List<GameObject> AtmoParticleList;
    // Start is called before the first frame update
    private void Awake()
    {
        atmoM = new AtmosphereManager(AtmoParticleList, atmoPace);
        TransitionSheet = GetComponent<Transitioner>();
        
    }




    
}
