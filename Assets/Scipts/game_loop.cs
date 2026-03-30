using UnityEngine;
using TMPro;

public class game_loop : MonoBehaviour
{
    public TextMeshProUGUI Result;

    public string[] choices = { "Stone", "Paper", "Scissors" };

    string GetResult(string playerChoice, string computer)
    {   
        Debug.Log(playerChoice);    
        if (playerChoice == computer)
            return "Draw";

        else if ((playerChoice == "Stone" && computer == "Scissors") ||
            (playerChoice == "Paper" && computer == "Stone") ||
            (playerChoice == "Scissors" && computer == "Paper"))
            return "You Win!";
        
        return "You Lose!";   
    }

    public void PlayerChoice(string playerChoice)
    {
        string comp_choice = choices[Random.Range(0, choices.Length)];

        string result = GetResult(playerChoice, comp_choice);
        Result.text = "You: " + playerChoice +
              "\nComputer: " + comp_choice +
              "\nResult: " + result;

        Debug.Log("Player: " + playerChoice + " | Computer: " + comp_choice);

        
    }
}