using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : ShootingSceneController
{

    public DestroyerAtCommand destroyerDx;
    public Firework[] fireworks;

    public void StartFireworks()
    {
        destroyerDx.savePlayer = true;
        foreach (var firework in fireworks)
        {
            firework.Shoot();
        }
    }

    public int GetBossIndex()
    {
        return waiting.First.Value;
    }

}
