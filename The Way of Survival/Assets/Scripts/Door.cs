using UnityEngine;

public class Door : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Open()
    {
        anim.SetBool("Open", true);
    }
    public void Close()
    {
        anim.SetBool("Open", false);
    }
}
