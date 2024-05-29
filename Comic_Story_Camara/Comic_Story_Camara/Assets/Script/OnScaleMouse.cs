using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScaleMouse : MonoBehaviour
{
    public void PointEnter()
    {
        transform.localScale = new Vector2(1.2f, 1.2f); //Scala del objeto cuando entra el raton se hace grande
    }

    public void PointExit()
    {
        transform.localScale = new Vector2(1f, 1f); //Scala del objeto cuando entra el raton se hace normal
    }
}
