using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaLuciaController : ShootingSceneController
{

    public Fan fan;
    public Thermometer thermometer;

    private State currentFanState;
    public State CurrentFanState {
        get => currentFanState;
        set 
        {
            thermometer.SetTemperature(value);
            currentFanState = value;
        }
    }

    override public void KillPlayer()
    {
        fan.ResetScene();
        thermometer.SetTemperature(State.FAST);
        base.KillPlayer();
    }
}
