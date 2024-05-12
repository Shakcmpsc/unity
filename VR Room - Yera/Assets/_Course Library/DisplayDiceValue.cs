using UnityEngine;
using TMPro;

public class DisplayDiceValue : MonoBehaviour
{
    public DiceRoll dice; // Reference to the DiceRoll script
    public TextMeshProUGUI textMesh; // For UI text

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        if (textMesh == null)
        {
            Debug.LogError("TextMeshProUGUI component not found on the GameObject.");
        }
    }

    void Update()
    {
        if (textMesh != null && dice != null)
        {
            // Display the top face value of the dice
            textMesh.text = dice.faceUpValue.ToString();
        }

        
{
    if (dice != null && textMesh != null)
    {
        int currentFaceValue = dice.faceUpValue;
        textMesh.text = currentFaceValue.ToString();
        Debug.Log("Current Dice Value: " + currentFaceValue); // This will log to the console
    }
    else
    {
        Debug.LogError("Dice or TextMeshPro is not assigned.");
    }

    {
    if (dice != null && textMesh != null)
    {
        textMesh.text = dice.faceUpValue.ToString();
        Debug.Log("Text set to: " + textMesh.text); // Confirm what's being set
        Debug.Log("Is TextMesh Active? " + textMesh.gameObject.activeInHierarchy); // Check if the TextMesh object is active
    }
}
}
    }
}