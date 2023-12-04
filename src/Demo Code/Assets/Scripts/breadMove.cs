using System.Collections;
using UnityEngine;

public class BreadMove : MonoBehaviour
{
    public Vector3 toasterPosition = new Vector3(0.11f, 2.2f, 4.11f); // Toaster's position
    [SerializeField] private Renderer objectRenderer; 
    [SerializeField] private Color doneColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if collider is the player
        {
            objectRenderer.material.SetColor("_Color", doneColor);
            StartCoroutine(MoveBreadToToaster());
        }
    }

    private IEnumerator MoveBreadToToaster()
    {
        // Rotate the bread to make it upright and face the desired direction
        transform.rotation = Quaternion.Euler(new Vector3(0, 90, 90));

        // Adjust the position to move the bread above the toaster
        Vector3 adjustedPosition = new Vector3(toasterPosition.x - .2f, toasterPosition.y + 0.5f, toasterPosition.z - .3f);
        transform.position = adjustedPosition;

        yield return null;
    }
}
