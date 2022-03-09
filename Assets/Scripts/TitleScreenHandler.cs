using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenHandler : MonoBehaviour
{
    private string sceneName;
    [SerializeField]
    public Animator mainCanvasAnimator;
    // Start is called before the first frame update
    public void EnglishButtonOnClick()
    {
        sceneName = "EnglishMenu";
        StartCoroutine(SwitchToSelectedMenu());
        Debug.Log("English Button Is Clicked");
    }
    public void FrenchButtonOnClick()
    {
        sceneName = "FrenchMenu";
        StartCoroutine(SwitchToSelectedMenu());
        Debug.Log("French Button Is Clicked");
    }

    public void SetTrigger()
    {
        mainCanvasAnimator.Play("ExitTitleScreenAnimation");
    }
    
    IEnumerator SwitchToSelectedMenu()
    {
        SetTrigger();
        yield return new WaitForSeconds(1f);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;
        while (asyncOperation.isDone == false)
        {
            if (Mathf.Clamp01(asyncOperation.progress / .9f)>=0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}

    
