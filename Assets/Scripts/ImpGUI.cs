/* sir hindi pa po ito tapos, wag niyo po muna i-grade */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class ImpGUI : MonoBehaviour
{
    private GUIStyle textStyle;

    private string statsTemplate;

    private PlayerOneStats playerOneStats;
    private PlayerTwoStats playerTwoStats;
    private PlayerThreeStats playerThreeStats;

    string playerStatsName;
    int playerStatsAttack;
    int playerStatsDefense;
    int playerStatsSpeed;
    int playerStatsLuck;
    int playerStatsIntelligence;
    int playerStatsSpecial;

    private void Stats()
    {
        
        playerTwoStats = new PlayerTwoStats();
        playerThreeStats = new PlayerThreeStats();

        

        string playerTwoName = playerTwoStats.playerTwoName;
        int playerTwoAttack = playerTwoStats.playerTwoAttack;
        int playerTwoDefense = playerTwoStats.playerTwoDefense;
        int playerTwoSpeed = playerTwoStats.playerTwoSpeed;
        int playerTwoLuck = playerTwoStats.playerTwoLuck;
        int playerTwoIntelligence = playerTwoStats.playerTwoIntelligence;
        int playerTwoSpecial = playerTwoStats.playerTwoSpecial;

        string playerThreeName = playerThreeStats.playerThreeName;
        int playerThreeAttack = playerThreeStats.playerThreeAttack;
        int playerThreeDefense = playerThreeStats.playerThreeDefense;
        int playerThreeSpeed = playerThreeStats.playerThreeSpeed;
        int playerThreeLuck = playerThreeStats.playerThreeLuck;
        int playerThreeIntelligence = playerThreeStats.playerThreeIntelligence;
        int playerThreeSpecial = playerThreeStats.playerThreeSpecial;


        


        
    }

    private void ShowPlayerOneStats()
    {
        playerOneStats = new PlayerOneStats();

        string playerOneName = playerOneStats.playerOneName;
        print(playerOneName);
        int playerOneAttack = playerOneStats.playerOneAttack;
        int playerOneDefense = playerOneStats.playerOneDefense;
        int playerOneSpeed = playerOneStats.playerOneSpeed;
        int playerOneLuck = playerOneStats.playerOneLuck;
        int playerOneIntelligence = playerOneStats.playerOneIntelligence;
        int playerOneSpecial = playerOneStats.playerOneSpecial;

        

        playerStatsName = playerOneName;
        playerStatsAttack = playerOneAttack;
        playerStatsDefense = playerOneDefense;
        playerStatsSpeed = playerOneSpeed;
        playerStatsSpeed = playerOneSpeed;
        playerStatsLuck = playerOneLuck;
        playerStatsSpecial = playerOneSpecial;

        statsTemplate = @$"Name: {playerStatsName}
Attack: {playerStatsAttack}
Defense: {playerStatsDefense}
Speed: {playerStatsSpeed}
Intelligence: {playerStatsIntelligence}
Luck: {playerStatsLuck}
Special: {playerStatsSpecial}";

        GUI.Label(new Rect(530, 90, 1000, 500), statsTemplate);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 50, 875, 420), "Change Stats");


        

        if (GUI.Button(new Rect(50, 100, 100, 100), "Player 1"))
        {
            ShowPlayerOneStats();
            
        }

        if (GUI.Button(new Rect(50, 210, 100, 100), "Player 2"))
        {

        }

        if (GUI.Button(new Rect(50, 320, 100, 100), "Player 3"))
        {

        }

/*        GUI.Label(new Rect(530, 90, 1000, 500), stats);*/
    }

}
