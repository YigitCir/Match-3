using UnityEngine;

public class SetFrameRate : MonoBehaviour
{
    void Start()
    {
        // Set the target frame rate to 30 FPS
        Application.targetFrameRate = 30;
    }
}