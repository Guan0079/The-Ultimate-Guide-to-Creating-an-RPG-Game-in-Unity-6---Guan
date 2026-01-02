using UnityEngine;

public class Player_JumpState : Player_AiredStated
{
    public Player_JumpState(Player player, StateMachine stateMachine, string animeBoolName) : base(player, stateMachine, animeBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();


        player.SetVelocity(rb.linearVelocity.x, player.jumpForce);
    }

    public override void Update()
    {
        base.Update();

        // 我們需要確保，在進入完整個狀態時，不處於跳躍攻擊狀態當我們是落下狀態時。
        if (rb.linearVelocity.y < 0  && stateMachine.currentState != player.jumpAttackState)
            stateMachine.ChangeState(player.fallState);
    }
}
