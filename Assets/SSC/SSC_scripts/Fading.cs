using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

    public CanvasGroup uiElement;

    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageCompleted = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageCompleted = timeSinceStarted / lerpTime;

            float CurrentValue = Mathf.Lerp(start, end, percentageCompleted);
            cg.alpha = CurrentValue;

            if (percentageCompleted >= 1) break;

            yield return new WaitForEndOfFrame();
        }
    }

	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
