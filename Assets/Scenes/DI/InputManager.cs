using UnityEngine;

public class InputManager : IInputManager
{

    public void ReadInput()
    {

        /*        if (Input.GetKeyDown(KeyCode.RightArrow))       { Rotation = 1; }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))   { Rotation = -1;}
                if (Input.GetKeyDown(KeyCode.Space))            { Thrust = 1; }*/

        Rotation = Input.GetAxis("Horizontal");
        Thrust = Input.GetAxis("Vertical");
    }

    public float Rotation { get; private set; }
    public float Thrust { get; private set; }

}
