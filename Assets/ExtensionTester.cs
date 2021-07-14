using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Test_Vector2ToAngle();
        //Test_FaceDirectionToFloat();
        //Test_AngleToCardinal_4Way();
        //Test_AngleToCardinal_8Way();
        //Test_ToCardinalSmoothed_4Way();
    }

    void Test_Vector2ToAngle()
    {
        Debug.Log("North is " + new Vector2(0, 1).ToAngle());
        Debug.Log("NorthEast is " + new Vector2(1, 1).ToAngle());
        Debug.Log("East is " + new Vector2(1, 0).ToAngle());
        Debug.Log("SouthEast is " + new Vector2(1, -1).ToAngle());
        Debug.Log("South is " + new Vector2(0, -1).ToAngle());
        Debug.Log("SouthWest is " + new Vector2(-1, -1).ToAngle());
        Debug.Log("West is " + new Vector2(-1, 0).ToAngle());
        Debug.Log("NorthWest is " + new Vector2(-1, 1).ToAngle());
    }

    void Test_FaceDirectionToFloat()
    {
        Debug.Log("North facing is " + FaceDirection.North.ToAngle() + " degrees");
        Debug.Log("NorthEast facing is " + FaceDirection.NorthEast.ToAngle() + " degrees");
        Debug.Log("East facing is " + FaceDirection.East.ToAngle() + " degrees");
        Debug.Log("SouthEast facing is " + FaceDirection.SouthEast.ToAngle() + " degrees");
        Debug.Log("South facing is " + FaceDirection.South.ToAngle() + " degrees");
        Debug.Log("SouthWest facing is " + FaceDirection.SouthWest.ToAngle() + " degrees");
        Debug.Log("West facing is " + FaceDirection.West.ToAngle() + " degrees");
        Debug.Log("NorthWest facing is " + FaceDirection.NorthWest.ToAngle() + " degrees");
    }

    void Test_AngleToCardinal_4Way()
    {
        Debug.Log("4-Way at 0 degrees is " + ExtensionMethods.AngleToCardinal(0,DirectionStyle.FourWay));
        Debug.Log("4-Way at 40 degrees is " + ExtensionMethods.AngleToCardinal(40, DirectionStyle.FourWay));
        Debug.Log("4-Way at 90 degrees is " + ExtensionMethods.AngleToCardinal(90, DirectionStyle.FourWay));
        Debug.Log("4-Way at 130 degrees is " + ExtensionMethods.AngleToCardinal(130, DirectionStyle.FourWay));
        Debug.Log("4-Way at 180 degrees is " + ExtensionMethods.AngleToCardinal(180, DirectionStyle.FourWay));
        Debug.Log("4-Way at 220 degrees is " + ExtensionMethods.AngleToCardinal(220, DirectionStyle.FourWay));
        Debug.Log("4-Way at 270 degrees is " + ExtensionMethods.AngleToCardinal(270, DirectionStyle.FourWay));
        Debug.Log("4-Way at 310 degrees is " + ExtensionMethods.AngleToCardinal(310, DirectionStyle.FourWay));
    }

    void Test_AngleToCardinal_8Way()
    {
        Debug.Log("8-Way at 0 degrees is " + ExtensionMethods.AngleToCardinal(0, DirectionStyle.EightWay));
        Debug.Log("8-Way at 40 degrees is " + ExtensionMethods.AngleToCardinal(40, DirectionStyle.EightWay));
        Debug.Log("8-Way at 90 degrees is " + ExtensionMethods.AngleToCardinal(90, DirectionStyle.EightWay));
        Debug.Log("8-Way at 130 degrees is " + ExtensionMethods.AngleToCardinal(130, DirectionStyle.EightWay));
        Debug.Log("8-Way at 180 degrees is " + ExtensionMethods.AngleToCardinal(180, DirectionStyle.EightWay));
        Debug.Log("8-Way at 220 degrees is " + ExtensionMethods.AngleToCardinal(220, DirectionStyle.EightWay));
        Debug.Log("8-Way at 270 degrees is " + ExtensionMethods.AngleToCardinal(270, DirectionStyle.EightWay));
        Debug.Log("8-Way at 310 degrees is " + ExtensionMethods.AngleToCardinal(310, DirectionStyle.EightWay));
    }

    void Test_ToCardinalSmoothed_4Way()
    {
        Debug.Log("Facing East.  Move direction at (1,2).  Tolerance of 0.  New direction is " + new Vector2(1f, 2f).ToCardinalSmoothed(FaceDirection.East, 0, DirectionStyle.FourWay));
        //Debug.Log("Facing East.  Move direction at (1.1,1).  Tolerance of 0.  New direction is " + new Vector2(1.1f, 1f).ToCardinalSmoothed(FaceDirection.East, 0, DirectionStyle.FourWay));
        //Debug.Log("Facing East.  Move direction at (1,-1.1).  Tolerance of 0.  New direction is " + new Vector2(1f, -1.1f).ToCardinalSmoothed(FaceDirection.East, 0, DirectionStyle.FourWay));
        //Debug.Log("Facing East.  Move direction at (1.1,-1).  Tolerance of 0.  New direction is " + new Vector2(1.1f, -1f).ToCardinalSmoothed(FaceDirection.East, 0, DirectionStyle.FourWay));
    }


}
