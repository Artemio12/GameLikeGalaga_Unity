using UnityEngine;

public sealed class Timer
{
    private float timeCounter;
    public float Counter
    {
        get { return timeCounter; }
        set { timeCounter = value; }
    }
    public float TimeCount()
    {
        this.timeCounter += Time.deltaTime;
        return this.timeCounter;
    }
}