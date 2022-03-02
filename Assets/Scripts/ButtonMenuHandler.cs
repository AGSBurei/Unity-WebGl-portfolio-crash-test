using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuHandler : MonoBehaviour
{
    public void ButtonMenuOnClick()
    {
        switch (gameObject.name)
        {
            case "HomeBtn":
                Debug.Log("Home has been pressed");
                break;
            case "AboutBtn":
                Debug.Log("About has been pressed");
                break;
            case "SkillBtn":
                Debug.Log("Skill has been pressed");
                break;
            case "ProjectBtn":
                Debug.Log("Project has been pressed");
                break;
        }
    }
}
