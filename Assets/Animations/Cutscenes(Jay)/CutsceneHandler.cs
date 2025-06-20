using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneHandler : MonoBehaviour
{
    private CutsceneElementBase[] cutsceneElements;
    private int index = -1;

    public void Start()
    {
        cutsceneElements = GetComponents<CutsceneElementBase>();
    }

    private void ExecuteCurrentElement()
    {
        if(index >= 0 && index < cutsceneElements.Length)
            cutsceneElements[index].Execute();
    }

    public void PlayNextElement()
    {
        if(index < cutsceneElements.Length -1)
        {
            index++;
            ExecuteCurrentElement();
        }
    }

     public void ResetCutscene()
    {
        index = -1;
    }
}
