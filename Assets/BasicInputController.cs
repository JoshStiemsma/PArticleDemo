using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicInputController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[Key.T].isPressed)
        {
            this.transform.Rotate(Vector3.right, 1);
        }
        if (Keyboard.current[Key.G].isPressed)
        {
            this.transform.Rotate(Vector3.right, -1);
        }
        if (Keyboard.current[Key.F].isPressed)
        {
            this.transform.Rotate(Vector3.forward, 1);
        }
        if (Keyboard.current[Key.H].isPressed)
        {
            this.transform.Rotate(Vector3.forward, -1);
        }
    }
}
