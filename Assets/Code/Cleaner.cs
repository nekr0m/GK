using UnityEngine;

public class Cleaner : MonoBehaviour
{
    [SerializeField] float timer;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) Destroy(gameObject);
    }
}
