using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbattoggiaUnoController : ShootingSceneController
{
    public ScoreScript scoreMultaVelox;
    public VeloxScript velox;

    public void VeloxNull()
    {
        scoreMultaVelox.VeloxNull();
    }

    public void ShootPlate()
    {
        velox.SetActive(false);        
    }

    override public void GeneratedPlayer()
    {
        if (velox == null)
        {
            velox = (VeloxScript)FindObjectOfType(typeof(VeloxScript));
        }
        velox.SetActive(true);
        base.GeneratedPlayer();
    }
}
