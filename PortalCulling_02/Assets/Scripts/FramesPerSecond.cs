using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesPerSecond : MonoBehaviour
{
    Rect fpsRect;
    Rect commandRect;
    float fps;
    GUIStyle style;
    GUIStyle commandStyle;

    void Start()
    {
        fpsRect = new Rect(20, 20, 400, 200);
        commandRect = new Rect(970, 270, 400, 200);
        style = new GUIStyle();
        style.fontSize = 18;
        style.normal.textColor = Color.white;

        //commandStyle = new GUIStyle();
        //commandStyle.fontSize = 18;
        //commandStyle.normal.textColor = Color.white;

        StartCoroutine(RecalculatorFPS());
    }
    
    private IEnumerator RecalculatorFPS()
    {
        while(true)
        {
            fps = 1 / Time.deltaTime;
            yield return new WaitForSeconds(1);
        }
    }

    void OnGUI()
    {
        
    //    GUI.Label(fpsRect, "FPS: " + string.Format("{0:0.0}", fps), style);
       
        GUI.Label(commandRect, "WSAD - movement", style);
        GUI.Label(commandRect, "\nMouse - view rotation", style);
        
    }


}
