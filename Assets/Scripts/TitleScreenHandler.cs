using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenHandler : MonoBehaviour
{
    [SerializeField]
    public Animator mainCanvasAnimator;
    // Start is called before the first frame update
    public void EnglishButtonOnClick()
    {
        SetTrigger();
        Debug.Log("English Button Is Clicked");
    }
    public void FrenchButtonOnClick()
    {
        SetTrigger();
        Debug.Log("French Button Is Clicked");
    }

    public void SetTrigger()
    {
        mainCanvasAnimator.Play("ExitTitleScreenAnimation");
    }
}

    
