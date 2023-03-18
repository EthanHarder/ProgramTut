using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overmind : MonoBehaviour
{
    public static Overmind _manager;
    AtmosphereManager atmoM;
    protected Transitioner TransitionSheet { get; private set; }

    public float atmoPace;
    public List<GameObject> AtmoParticleList;
    // Start is called before the first frame update
    private void Awake()
    {
        if (_manager != this)
        {
            if (_manager == null)
                _manager = this;
            else
                Destroy(this);
        }

        atmoM = new AtmosphereManager(AtmoParticleList, atmoPace);
        atmoM = GetComponent<AtmosphereManager>();
        TransitionSheet = GameObject.Find("Transition").GetComponent<Transitioner>();
        
    }

    public void TransitionIn()
    {
        TransitionSheet.FadeInCall();
    }

    public void TransitionOut(bool died)
    {
        TransitionSheet.FadeOutCall(died);
    }






    
}
