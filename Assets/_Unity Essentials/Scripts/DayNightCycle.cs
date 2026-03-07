using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The time in real-world seconds it takes for one full day to pass.")]
    public float dayDurationInSeconds = 120f;

    void Update()
    {
        // Prevent dividing by zero if the duration is set to 0 in the Inspector
        if (dayDurationInSeconds > 0)
        {
            // A full circle is 360 degrees. We divide that by the total seconds.
            float degreesPerSecond = 360f / dayDurationInSeconds;

            // Rotate the light smoothly around its X-axis (Vector3.right)
            transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
        }
    }
}