using UnityEngine;
using TMPro;

public class game_loop : MonoBehaviour
{
    public TextMeshProUGUI Result;

    public string[] choices = { "Stone", "Paper", "Scissors" };

    string GetResult(string player, string computer)
    {
        if (player == computer)
            return "Draw";

        if ((player == "Stone" && computer == "Scissors") ||
            (player == "Paper" && computer == "Stone") ||
            (player == "Scissors" && computer == "Paper"))
            return "You Win!";

        return "You Lose!";
    }

    public void PlayerChoice(string playerChoice)
    {
        string comp_choice = choices[Random.Range(0, choices.Length)];

        string result = GetResult(playerChoice, comp_choice);

        Result.text = "Result: " + result;

        Debug.Log("Clicked: " + playerChoice);
    }
}