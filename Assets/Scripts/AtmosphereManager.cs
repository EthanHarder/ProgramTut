using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtmosphereManager: MonoBehaviour
{
    public enum Mood
    {
        Calm,
        Neutral,
        Panic
    }

    public Mood currentMood;
    [SerializeField]
    protected float timeBetweenParticles;
    protected float particleTimer;
    private Transform camLocalReferance;
    [SerializeField]
    protected List<GameObject> particleAtmoList;
    private GameObject particleAtmoReference;

    private void Awake() //I cant seem to construct this properly, so im adding this to replace the constructer untill i can find a fix.
    {
        camLocalReferance = GameObject.Find("Main Camera").transform;
        currentMood = FindMood();
        Debug.Log(currentMood.ToString());
    }
    public AtmosphereManager(List<GameObject> pAL, float timeBP)
    {
        particleAtmoList = pAL;
        timeBetweenParticles = timeBP;
        camLocalReferance = GameObject.Find("Main Camera").transform;
        currentMood = FindMood();
    }

    public void Update()
    {
        particleTimer -= Time.deltaTime;
        if (particleTimer <= 0)
        { //Yeah...its a bit ugly. But it works.
            camLocalReferance = GameObject.Find("Main Camera").transform;
            particleAtmoReference = Instantiate(particleAtmoList[(int)currentMood], camLocalReferance);
            particleAtmoReference.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);
            particleTimer = timeBetweenParticles;
            NewMood();
        }
    }

    public void NewMood()
    {
        currentMood = FindMood();
    }
    public Mood FindMood()
    {
        
        if (Random.Range(0,10)>= 5)
            return (Mood)0;
        else if (Random.Range(0,10) >= 2)
            return (Mood)1;
        else return (Mood)2;

    }

}
