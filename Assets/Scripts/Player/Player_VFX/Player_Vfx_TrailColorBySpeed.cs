using UnityEngine;

public class Player_Vfx_TrailColorBySpeed : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private TrailRenderer[] trails; // Array of trails
    [SerializeField] private Gradient[] gradients; // Array of gradients
    [SerializeField] private float maxSpeed = 20f; // Set approximate max speed to normalize

    private void Update()
    {
        // Normalize speed to a range of 0 to 1
        float normalizedSpeed = Mathf.Clamp01(rb.linearVelocity.magnitude / maxSpeed);

        // Determine the index range for interpolation
        int gradientCount = gradients.Length;
        int lowerIndex = Mathf.FloorToInt(normalizedSpeed * (gradientCount - 1));
        int upperIndex = Mathf.Clamp(lowerIndex + 1, 0, gradientCount - 1);

        // Interpolation factor between the two gradients
        float t = (normalizedSpeed * (gradientCount - 1)) - lowerIndex;

        // Interpolate between the chosen gradients
        Gradient interpolatedGradient = LerpGradient(gradients[lowerIndex], gradients[upperIndex], t);

        // Apply the gradient to each trail in the array
        foreach (TrailRenderer trail in trails)
        {
            trail.colorGradient = interpolatedGradient;
        }
    }

    private Gradient LerpGradient(Gradient a, Gradient b, float t)
    {
        Gradient result = new Gradient();

        GradientColorKey[] colorKeys = new GradientColorKey[a.colorKeys.Length];
        GradientAlphaKey[] alphaKeys = new GradientAlphaKey[a.alphaKeys.Length];

        // Interpolate between color keys
        for (int i = 0; i < colorKeys.Length; i++)
        {
            Color color = Color.Lerp(a.colorKeys[i].color, b.colorKeys[i].color, t);
            float time = Mathf.Lerp(a.colorKeys[i].time, b.colorKeys[i].time, t);
            colorKeys[i] = new GradientColorKey(color, time);
        }

        // Interpolate between alpha keys
        for (int i = 0; i < alphaKeys.Length; i++)
        {
            float alpha = Mathf.Lerp(a.alphaKeys[i].alpha, b.alphaKeys[i].alpha, t);
            float time = Mathf.Lerp(a.alphaKeys[i].time, b.alphaKeys[i].time, t);
            alphaKeys[i] = new GradientAlphaKey(alpha, time);
        }

        result.SetKeys(colorKeys, alphaKeys);
        return result;
    }
}
