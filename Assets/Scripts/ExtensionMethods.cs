using UnityEngine;

public static class ExtensionMethods
{
    public static FaceDirection AngleToCardinal( float angle, DirectionStyle directionStyle) {

        if (directionStyle == DirectionStyle.FourWay)
        {
            if (angle >= 0 && angle < 45 || angle <= 360 && angle > 270)
                return FaceDirection.North;
            if (angle >= 45 && angle < 135)
                return FaceDirection.East;
            if (angle >= 135 && angle < 225)
                return FaceDirection.West;
            if (angle >= 225 && angle < 315)
                return FaceDirection.East;
        }
        else if (directionStyle == DirectionStyle.EightWay)
        {
            if (angle >= 0 && angle < 22.5 || angle <= 360 && angle > 292.5)
                return FaceDirection.North;
            if (angle >= 22.5 && angle < 67.5)
                return FaceDirection.NorthEast;
            if (angle >= 67.5 && angle < 112.5)
                return FaceDirection.East;
            if (angle >= 112.5 && angle < 157.5)
                return FaceDirection.SouthEast;
            if (angle >= 157.5 && angle < 202.5)
                return FaceDirection.South;
            if (angle >= 202.5 && angle < 247.5)
                return FaceDirection.SouthWest;
            if (angle >= 247.5 && angle < 292.5)
                return FaceDirection.West;
            else
                return FaceDirection.NorthWest;
        }

        Debug.LogError("Script Incorrectly calls for cardinal directions with a noncardinal setup is applied.");
        return FaceDirection.South;

    }

    public static FaceDirection ToCardinalSmoothed(this Vector2 v2, FaceDirection faceDirection, float forgiveness, DirectionStyle directionStyle)
    {
        float currentAngle = v2.ToAngle();
        FaceDirection suggestedDirection = AngleToCardinal(currentAngle, directionStyle);
        if (suggestedDirection == faceDirection)
        {
            return faceDirection;
        }
        else
        {
            forgiveness += (directionStyle == DirectionStyle.FourWay) ? 22.5f : 45f;
            if (v2.ToAngle() < faceDirection.ToAngle() - forgiveness ||
                v2.ToAngle() > faceDirection.ToAngle() + forgiveness)
                return faceDirection;
            else
            {
                return suggestedDirection;
            }
        }
    }

    public static float ToAngle (this Vector2 v2)
    {
        float angle = Vector2.SignedAngle(Vector2.up, v2);
        if (angle < 0) angle = 360 - angle;
        return angle;
    }

    public static float ToAngle(this FaceDirection faceDirection) {
        switch (faceDirection) {
            case FaceDirection.North:
                return 0f;
            case FaceDirection.NorthEast:
                return 45f;
            case FaceDirection.East:
                return 90f;
            case FaceDirection.SouthEast:
                return 135f;
            case FaceDirection.South:
                return 180f;
            case FaceDirection.SouthWest:
                return 225f;
            case FaceDirection.West:
                return 270f;
            default:
                return 315;
        }
    }

}