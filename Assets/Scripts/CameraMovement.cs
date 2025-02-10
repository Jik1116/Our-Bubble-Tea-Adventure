using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform trackedObject;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CalculateCameraPos();
    }

    Vector3 CalculateCameraPos()
    {
        Vector3 currentPos = transform.position;
        currentPos.x = trackedObject.position.x;
        currentPos = currentPos + offset;
        return currentPos;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow * new Vector4(1, 1, 1, 0.4f);
        Vector3 trackedPos = CalculateCameraPos();
        trackedPos.z = 0.0f;
        Gizmos.DrawCube(trackedPos, Vector3.one);
    }
}
