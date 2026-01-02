using UnityEngine;

public class Player_Combat : Entity_Combat
{
    [Header("Counter attack details")]
    [SerializeField] private float counterRecovery;

    public bool CounterAttackPerformed()
    {
        bool fasPerformedCounter = false;

        foreach (var target in GetDetectedColliders())
        {
            ICounterable counterable = target.GetComponent<ICounterable>();

            if (counterable == null)
                continue;

            if (counterable.CanBeCountered)
            {
                counterable.HandleCounter();
                fasPerformedCounter = true;
            }
        }
        return fasPerformedCounter;
    }

    public float GetCounterRecoveryDuration() => counterRecovery;
}
