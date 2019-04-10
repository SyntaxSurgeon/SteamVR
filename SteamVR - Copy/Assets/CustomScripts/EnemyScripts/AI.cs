using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateScripts;

public class AI : MonoBehaviour
{
    Animator anim;

    public bool switchState = false;

    public StateMachine<AI> stateMachine { get; set; }

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        stateMachine = new StateMachine<AI>(this);

        stateMachine.ChangeState(FirstState.Instance);
    }

    private void Update()
    {
        stateMachine.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bunker")
        {
            switchState = !switchState;
        }
    }

    public void Attack()
    {
        anim.SetBool("IsAttacking", true);
    }
}

