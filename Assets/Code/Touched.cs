using UnityEngine;

public class Touched : MonoBehaviour
{
    [SerializeField] UI Ui;
    [SerializeField] Move Mo;
    [SerializeField] GameObject boom;
    void OnTriggerEnter(Collider body)
    {
        if (body.gameObject.tag == "money")
        {
            Coins Co = body.gameObject.GetComponent<Coins>();
            Ui.AddScore(Co.value);
            Co.dead();
        }
    }
    void OnCollisionEnter(Collision body)
    {
        if (body.gameObject.tag == "wall")
        {
            ContactPoint contact = body.contacts[0];
            Quaternion rot = body.gameObject.transform.rotation;
            Vector3 pos = contact.point;
            Instantiate(boom, pos, rot);
            Mo.stop();
        }
    }
}
