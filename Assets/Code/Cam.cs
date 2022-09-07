using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] Transform GG;
    [SerializeField] Transform cam;
    Vector3 offset = new Vector3(0, 10, 0);
    float speed = 10;
    void LateUpdate()
    {
        cam.position = Vector3.Lerp(cam.position, GG.position + offset, speed * Time.deltaTime);
    }
}