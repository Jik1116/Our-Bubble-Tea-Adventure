using System;
using UnityEngine;

[ExecuteInEditMode]
public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform trackedObject;

    public Vector3 offset;
    public Vector3 allowance;
    [Flags]
    public enum TrackedAxes
    {
        None = 0,
        X = 1,
        Y = 2,
    }
    [EnumButtons] public TrackedAxes trackedAxes;

    [Header("Debug")]
    public bool showCamera;
    public bool showTracked;

    // Update is called once per frame
    void Update()
    {
        transform.position = CalculateCameraPos();
    }

    Vector3 CalculateCameraPos()
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = trackedObject.position + offset;
        Vector3 diff = newPos - currentPos;
        if (trackedAxes.HasFlag(TrackedAxes.X) && Math.Abs(diff.x) >= allowance.x) currentPos.x = newPos.x;
        if (trackedAxes.HasFlag(TrackedAxes.Y) && Math.Abs(diff.y) >= allowance.y) currentPos.y = newPos.y;
        return currentPos;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow * new Vector4(1, 1, 1, 0.4f);
        Vector3 trackedPos = CalculateCameraPos();
        trackedPos.z = 0.0f;
        if (showCamera) Gizmos.DrawCube(trackedPos, Vector3.one);
        Vector3 trackedObjectPos = trackedObject.position;
        if (trackedAxes.HasFlag(TrackedAxes.X)) trackedObjectPos.x = trackedPos.x - offset.x;
        if (trackedAxes.HasFlag(TrackedAxes.Y)) trackedObjectPos.y = trackedPos.y - offset.y;
        if (showTracked) Gizmos.DrawCube(trackedObjectPos, Vector3.one);
    }
}
