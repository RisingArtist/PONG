using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    // Holds value and resets the timer
    public static float RESET_TIMER = 5.0f;
    public static float RESET_COUNTDOWN = 3.0f;

    // Used to increase ball speed 
    public static float SPEED_UP = 2.0f;

    // Used for Ball increase threshold
    public static float BY_QUARTER = 4.0f;

    // Easier to play tracks by their names 
    public enum SoundTracks { PaddleHit, GoalGet }

    // Easier to refer to the Scene names
    // Remember to update this if the scenes in the build are out of order
    public enum Levels { Title, Game }
}
