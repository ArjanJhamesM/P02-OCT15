using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class ImpGUI : MonoBehaviour
{
    private GUIStyle textStyle;
 
    private string statName = "sir maynard";
    private int statAttack = 90;

    private string stats;

    private void OnGUI()
    {
        // Position, Size
        // GUI.Box(new Rect(position, size), "");
        // (no need to copy these comments)
        GUI.Box(new Rect(10, 50, 875, 420), "Change Stats");



        

        #region chatgpt
        textStyle = new GUIStyle(GUI.skin.label);
        textStyle.fontSize = 30;
        #endregion

        if (GUI.Button(new Rect(50, 100, 100, 100), "Player 1"))
        {
            stats = @$"Name: {statName}
Attack: {statAttack}";
        }

        if (GUI.Button(new Rect(50, 210, 100, 100), "Player 2"))
        {

        }

        if (GUI.Button(new Rect(50, 320, 100, 100), "Player 3"))
        {

        }

        GUI.Label(new Rect(530, 90, 1000, 500), stats);




    }

}
