using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform gg;
    [SerializeField] Transform ball;
    [SerializeField] Camera cam;
    Touch touch;
    Vector3 finishPoint;
    int toucCount;
    public Vector3 distance { get; private set; }
    int speed = 10;
    bool run;
    void Update()
    {
        if (Input.touchCount > 0 && !run)
        {
            touch = Input.GetTouch(0);
            float posX = touch.position.x / 1080 - 0.5f;
            float posZ = touch.position.y / 1920 - 0.5f;
            float posY = 0;
            finishPoint = new Vector3(posX, posY, posZ) + gg.position;
            toucCount = 1;
        }
        if (Input.touchCount < toucCount)
        {
            distance = (finishPoint - gg.position) * speed;
            run = true;
            toucCount = 0;
        }
    }
    void LateUpdate()
    {
        if (run)
        {
            gg.position += distance * Time.deltaTime;
            ball.Rotate(new Vector3(distance.z, 0, -distance.x) * 360 * Time.deltaTime);
        }
    }
    public void stop()
    {
        run = false;
    }
}