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
        FadeInCall();
    }

    public void FadeInCall()
    {
        StartCoroutine(FadeInStack());
    }
    public void FadeOutCall(bool died)
    {
        StartCoroutine(FadeOutStack(died));
    }

    public IEnumerator FadeOutStack(bool died)
    {
        transform.GetChild(0).gameObject.SetActive(true);
        Debug.Log("Test1");
        FadeOut();
        yield return new WaitForSeconds(2f);
        if (died)
        {
            SceneManager.LoadScene("DeadScene");
        }
        else
            SetFaderInactive();

    }
    public IEnumerator FadeInStack()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        FadeIn();
        yield return new WaitForSeconds(1.5f);
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
