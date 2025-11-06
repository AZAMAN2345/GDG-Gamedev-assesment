using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("Assign the player's transform here")]
    public Transform target;

    [Tooltip("Offset from the target (z usually -10 for 2D)")]
    public Vector3 offset = new Vector3(0f, 1f, -10f);

    [Tooltip("Smoothing time for camera movement")]
    public float smoothTime = 0.12f;

    [Tooltip("If true, camera position will be clamped to the min/max bounds")]
    public bool useBounds = false;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desired = target.position + offset;
        Vector3 smoothed = Vector3.SmoothDamp(transform.position, desired, ref velocity, smoothTime);

        if (useBounds)
        {
            smoothed.x = Mathf.Clamp(smoothed.x, minBounds.x, maxBounds.x);
            smoothed.y = Mathf.Clamp(smoothed.y, minBounds.y, maxBounds.y);
        }

        // Keep camera z at offset.z to avoid accidentally moving the camera forward/back
        transform.position = new Vector3(smoothed.x, smoothed.y, offset.z);
    }
}
