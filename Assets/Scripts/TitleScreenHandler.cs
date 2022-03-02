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
    public void OnClick()
    {
        switch (gameObject.name)
        {
            case "EnLanguageBtn":
                mainCanvasAnimator.SetTrigger("EnglishButtonIsClicked");
                break;
            case "FrLanguageBtn":
                mainCanvasAnimator.SetTrigger("FrenchButtonIsClicked");
                break;
        }
    }
}
