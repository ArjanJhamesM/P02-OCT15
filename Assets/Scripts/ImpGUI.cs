using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class ImpGUI : MonoBehaviour
{
    private PlayerOneStats playerOneStats;
    private PlayerTwoStats playerTwoStats;
    private PlayerThreeStats playerThreeStats;


    string playerOneName;
    int playerOneAttack;
    int playerOneDefense;
    int playerOneSpeed;
    int playerOneLuck;
    int playerOneIntelligence;
    int playerOneSpecial;

    string playerTwoName;
    int playerTwoAttack;
    int playerTwoDefense;
    int playerTwoSpeed;
    int playerTwoLuck;
    int playerTwoIntelligence;
    int playerTwoSpecial;

    string playerThreeName;
    int playerThreeAttack;
    int playerThreeDefense;
    int playerThreeSpeed;
    int playerThreeLuck;
    int playerThreeIntelligence;
    int playerThreeSpecial;


    // Reference variables for the label's text template
    string playerStatsName;
    int playerStatsAttack;
    int playerStatsDefense;
    int playerStatsSpeed;
    int playerStatsLuck;
    int playerStatsIntelligence;
    int playerStatsSpecial;


    private void ConstructClassObjects() // To be able to reference variables of classes from separate scripts
    {
        playerOneStats = new PlayerOneStats();
        playerTwoStats = new PlayerTwoStats();
        playerThreeStats = new PlayerThreeStats();
    }


    private void ReferenceStats() // To avoid redundant declaration of classes 
    {
        playerOneName = playerOneStats.playerOneName;
        playerOneAttack = playerOneStats.playerOneAttack;
        playerOneDefense = playerOneStats.playerOneDefense;
        playerOneSpeed = playerOneStats.playerOneSpeed;
        playerOneLuck = playerOneStats.playerOneLuck;
        playerOneIntelligence = playerOneStats.playerOneIntelligence;
        playerOneSpecial = playerOneStats.playerOneSpecial;

        playerTwoName = playerTwoStats.playerTwoName;
        playerTwoAttack = playerTwoStats.playerTwoAttack;
        playerTwoDefense = playerTwoStats.playerTwoDefense;
        playerTwoSpeed = playerTwoStats.playerTwoSpeed;
        playerTwoLuck = playerTwoStats.playerTwoLuck;
        playerTwoIntelligence = playerTwoStats.playerTwoIntelligence;
        playerTwoSpecial = playerTwoStats.playerTwoSpecial;

        playerThreeName = playerThreeStats.playerThreeName;
        playerThreeAttack = playerThreeStats.playerThreeAttack;
        playerThreeDefense = playerThreeStats.playerThreeDefense;
        playerThreeSpeed = playerThreeStats.playerThreeSpeed;
        playerThreeLuck = playerThreeStats.playerThreeLuck;
        playerThreeIntelligence = playerThreeStats.playerThreeIntelligence;
        playerThreeSpecial = playerThreeStats.playerThreeSpecial;
    }


    /*Assigns stats of respective players to reference variables (for the label's text template)
      The method takes the value of a player name variable as the (string) argument
      The if...else loops checks the argument and changes the reference variables according to the argument*/
    private void AssignStats(string player) 
    {
        if (player == playerOneName)
        {
            playerStatsName = playerOneName;
            playerStatsAttack = playerOneAttack;
            playerStatsDefense = playerOneDefense;
            playerStatsSpeed = playerOneSpeed;
            playerStatsLuck = playerOneLuck;
            playerStatsIntelligence = playerOneIntelligence;
            playerStatsSpecial = playerOneSpecial;
        }
        else if (player == playerTwoName)
        {
            playerStatsName = playerTwoName;
            playerStatsAttack = playerTwoAttack;
            playerStatsDefense = playerTwoDefense;
            playerStatsSpeed = playerTwoSpeed;
            playerStatsLuck = playerTwoLuck;
            playerStatsIntelligence = playerTwoIntelligence;
            playerStatsSpecial = playerTwoSpecial;
        }
        else if (player == playerThreeName)
        {
            playerStatsName = playerThreeName;
            playerStatsAttack = playerThreeAttack;
            playerStatsDefense = playerThreeDefense;
            playerStatsSpeed = playerThreeSpeed;
            playerStatsLuck = playerThreeLuck;
            playerStatsIntelligence = playerThreeIntelligence;
            playerStatsSpecial = playerThreeSpecial;
        }
        else
        {
            Debug.LogWarning("Invalid argument");
        }
    }
    

    private string CreateTextTemplate() // Use the reference variables (containing stats of respective players) in the label's text template
    {

        string textTemplate = $"Name: {playerStatsName}" +
                              $"\nAttack: {playerStatsAttack}" +
                              $"\nDefense: {playerStatsDefense}" +
                              $"\nSpeed: {playerStatsSpeed}" +
                              $"\nLuck: {playerStatsLuck}" +
                              $"\nIntelligence: {playerStatsIntelligence}" +
                              $"\nSpecial: {playerStatsSpecial}";

        return textTemplate;
    }


    private void Start()
    {
        // To able to reference variables of classes from other scripts
        ConstructClassObjects();
        ReferenceStats();
    }


    private void OnGUI()
    {
        GUI.Box(new Rect(10, 50, 875, 420), "Change Stats"); // Creates background box for the buttons and label


        /*Each button changes the info of the label according to its assigned player
          The (string) value of the player name variable gets passed as the (string) argument for the method
          The label gets updated with changes to the reference variable by the if...else loop in AssignStats()*/

        if (GUI.Button(new Rect(50, 100, 100, 100), "Player 1"))
        {
            AssignStats(playerOneName);
            GUI.Label(new Rect(530, 90, 1000, 500), CreateTextTemplate());
        }

        if (GUI.Button(new Rect(50, 210, 100, 100), "Player 2"))
        {
            AssignStats(playerTwoName);
            GUI.Label(new Rect(530, 90, 1000, 500), CreateTextTemplate());
        }

        if (GUI.Button(new Rect(50, 320, 100, 100), "Player 3"))
        {
            AssignStats(playerThreeName);
            GUI.Label(new Rect(530, 90, 1000, 500), CreateTextTemplate());
        }


        GUI.Label(new Rect(530, 90, 1000, 500), CreateTextTemplate()); // Creates the label for the text template
    }
}