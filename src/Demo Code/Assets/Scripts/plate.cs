using UnityEngine;

public class Plate : MonoBehaviour
{
    public GameObject objectToMove;  // Reference to the object to move
    public GameObject levelCompleteText;  // Reference to the first 3D text GameObject
    public GameObject additionalText;  // Reference to the second 3D text GameObject
    [SerializeField] private Renderer objectRenderer; 
    [SerializeField] private Color doneColor;
    private Vector3 targetPosition = new Vector3(5.2f, 2.5f, 3.4f); // Target position
    private Quaternion targetRotation = Quaternion.Euler(90, 0, 0); // Target rotation to lay flat

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider is the player
        {
            if (objectToMove != null)
            {
                // Instantly teleport and rotate the specified object
                objectToMove.transform.position = targetPosition;
                objectToMove.transform.rotation = targetRotation;

                // Make the Level Complete text visible
                if (levelCompleteText != null)
                {
                    levelCompleteText.SetActive(true);
                }

                // Make the additional text visible
                if (additionalText != null)
                {
                    additionalText.SetActive(true);
                }
            }
            objectRenderer.material.SetColor("_Color", doneColor);
        }
    }
}
