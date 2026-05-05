using UnityEngine;

public class LogDisabler : MonoBehaviour
{
    public GameObject objectToTurnOff;

    // OnEnable runs the exact moment this object gets turned ON
    private void OnEnable()
    {
        if (objectToTurnOff != null)
        {
            objectToTurnOff.SetActive(false); // Turns the log off
        }
    }
}
