using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overmind : MonoBehaviour
{
    public static Overmind _manager;
    AtmosphereManager atmoM;
    public TimeManager tiM { get; private set; }

    public SaveLoadManager slM { get; private set; }
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

        //atmoM = new AtmosphereManager(AtmoParticleList, atmoPace);
        atmoM = GetComponent<AtmosphereManager>();
        tiM = GetComponent<TimeManager>();
        slM = GetComponent<SaveLoadManager>(); 
        TransitionSheet = GameObject.Find("Transition").GetComponent<Transitioner>();


        Invoke("LoadRequest",0.1f); //I am very unhappy that it seems to need this...
        
    }

    public void TransitionIn()
    {
        TransitionSheet.FadeInCall();
    }

    public void TransitionOut(bool died)
    {
        TransitionSheet.FadeOutCall(died);
    }

    public void LoadRequest()
    {
        slM.LoadGame();
    }
    





    
}
