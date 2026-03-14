using AH3829;
using UnityEngine;

public class playerAnimator : MonoBehaviour
{
    private const string IS_WALKING ="IsWalking";
    private Animator anim;
    [SerializeField]private player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool(IS_WALKING, player.IsWalking);
    }
}
