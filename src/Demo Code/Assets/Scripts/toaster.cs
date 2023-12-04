using System.Collections;
using UnityEngine;

public class Toaster : MonoBehaviour
{
    public GameObject bread; // Reference to the bread GameObject
    public float moveDownDistance = 2.9f; // Distance to move bread down initially
    public float popUpDistance = 1.9f; // Total distance to pop bread up
    public Color toastedColor = new Color(0.8f, 0.52f, 0.25f); // Example toasted bread color
    [SerializeField] private Renderer objectRenderer; 
    [SerializeField] private Color doneColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if collider is the player
        {
            StartCoroutine(ToastBread());
            objectRenderer.material.SetColor("_Color", doneColor);
        }
    }

    private IEnumerator ToastBread()
    {
        // Move bread down slightly
        Vector3 initialDownPosition = bread.transform.position - new Vector3(0, moveDownDistance, 0);
        bread.transform.position = initialDownPosition;

        // Wait for 3 seconds
        yield return new WaitForSeconds(3);

        // Change the color of the bread to simulate toasting
        Renderer breadRenderer = bread.GetComponent<Renderer>();
        if (breadRenderer != null)
        {
            breadRenderer.material.color = toastedColor;
        }

        // Pop the bread up fully
        Vector3 finalPopUpPosition = bread.transform.position + new Vector3(0, popUpDistance - moveDownDistance, 0);
        bread.transform.position = finalPopUpPosition;
        
    }
}
