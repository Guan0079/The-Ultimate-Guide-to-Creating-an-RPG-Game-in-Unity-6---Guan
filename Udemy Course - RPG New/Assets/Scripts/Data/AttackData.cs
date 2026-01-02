using UnityEngine;
using System;

[Serializable]
public class AttackData
{
    public float phyiscalDamage;
    public float elementDamage;
    public bool isCrit;
    public ElementType element;

    public ElementalEffectData effectData;

    public AttackData(Entity_Stats entityStats, DamageScaleData scaleData)
    {
        phyiscalDamage = entityStats.GetPhyiscalDamage(out isCrit, scaleData.phyiscal);
        elementDamage = entityStats.GetElementalDamage(out element, scaleData.elemental);

        effectData = new ElementalEffectData(entityStats, scaleData);
    }

}
