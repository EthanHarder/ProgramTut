using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitioner : MonoBehaviour
{

    [SerializeField]
    AudioClip transitionOut;
    [SerializeField]
    AudioClip sceneExit;

    [SerializeField]
    string sceneChangeTarget;
    public void OnEnable()
    {
        StartCoroutine(FadeInStack());
    }

    public void FadeOutCall(bool toPlacing)
    {
        StartCoroutine(FadeOutStack());
    }

    public IEnumerator FadeOutStack()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        FadeOut();
        yield return new WaitForSeconds(2);
            SetFaderInactive();

    }
    public IEnumerator FadeInStack()
    {

        transform.GetChild(0).gameObject.SetActive(true);
        FadeIn();
        yield return new WaitForSeconds(2);
        SetFaderInactive();
    }


    public void FadeIn()
    {
        transform.GetChild(0).GetComponent<Animator>().SetBool("FadeIn", true);
    }

    public void FadeOut()
    {
        transform.GetChild(0).GetComponent<Animator>().SetBool("FadeOut", true);
    }

    public void SetFaderInactive()
    {
        Debug.Log("SetFalse");
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
