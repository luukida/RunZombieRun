using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{
    public FixedJoystick LeftJoystick;
    public FixedJoystick Button;
    public ThirdPersonUserControl Control;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Control.m_Jump = Button.Pressed;
        //Control.Hinput = LeftJoystick.inputVector.x;
        //Control.Vinput = LeftJoystick.inputVector.y;
    }
}
