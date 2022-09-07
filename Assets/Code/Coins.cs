using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Transform self;
    [SerializeField] Transform boomPos;
    [SerializeField] GameObject boom;
    [SerializeField] Animator Anim;
    public int value { get; private set; }
    void Start()
    {
        value = score;
    }
    void Update()
    {
        if (self.localScale.x == 0.1f)
        {
            boomPos.position = self.position;
            Instantiate(boom);
            Destroy(gameObject);
        }
    }
    public void dead()
    {
        Anim.SetBool("dead", true);
    }
}
