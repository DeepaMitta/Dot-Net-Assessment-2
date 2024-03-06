using System;

public class Stopwatch
{
    private DateTime _startTime;
    private bool _isRunning;

    public void Start()
    {
        if (_isRunning)
            throw new InvalidOperationException("Stopwatch is already running.");

        _startTime = DateTime.Now;
        _isRunning = true;
    }

    public TimeSpan Stop()
    {
        if (!_isRunning)
            throw new InvalidOperationException("Stopwatch is not running.");

        TimeSpan duration = DateTime.Now - _startTime;
        _isRunning = false;
        return duration;
    }
}
