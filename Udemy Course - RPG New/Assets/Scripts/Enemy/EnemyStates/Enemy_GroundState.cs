using UnityEngine;

public class Enemy_GroundState : EnemyState
{
    public Enemy_GroundState(Enemy enemy, StateMachine stateMachine, string animBoolName) : base(enemy, stateMachine, animBoolName)
    {
    }

    public override void Update()
    {
        base.Update();


        if (enemy.PlayerDetected() == true)
            stateMachine.ChangeState(enemy.battleState);
        //假如敵人偵測到玩家
        //則進入戰鬥狀態
    }
}
