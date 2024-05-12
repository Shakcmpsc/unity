using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int faceUpValue; // The value of the top face of the dice
    private Vector3[] rayDirections = { Vector3.up, Vector3.down, Vector3.left, Vector3.right, Vector3.forward, Vector3.back };
    private float rayLength = 0.9f; // Slightly more than half the dice's size to ensure it reaches the ground
    private int[] oppositeFaces = { 5, 2, 3, 4, 6, 1 }; // Opposite faces of a standard dice

    void Update()
    {
        CastRaysToDetectTopFace();
    }

    private void CastRaysToDetectTopFace()
    {
        RaycastHit hit;
        for (int i = 0; i < rayDirections.Length; i++)
        {
            // Convert ray direction from local to world space
            Vector3 worldDirection = transform.TransformDirection(rayDirections[i]);
            // Cast a ray from the dice's center in the specified world direction
            if (Physics.Raycast(transform.position, worldDirection, out hit, rayLength))
            {
                // If the bottom face ray hits the ground, the opposite face is up
                faceUpValue = oppositeFaces[i];
                //faceUpValue = 6 - faceUpValue;
                Debug.Log("Face up value: " + faceUpValue);
                break; // Exit the loop once we've found the ground
            }
        }
    }
}