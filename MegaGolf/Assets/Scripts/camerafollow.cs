using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform Target;

    private float speed = 10f;
    public Vector3 Offset;

    private void FixedUpdate()
    {
        Vector3 despos = Target.position + Offset;
        Vector3 smoPos = Vector3.Lerp(a: transform.position, b: despos, t: speed * Time.deltaTime);
        transform.position = despos;

        transform.LookAt(Target);
    }
}
