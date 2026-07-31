class RemoteControlCar
{
    private int _battery = 100;
    private int _batteryDrain;
    private int _speed;
    private int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _batteryDrain = batteryDrain;
        _speed = speed;
    }

    public bool BatteryDrained()
    {
        return _battery < _batteryDrain;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }
        _distanceDriven += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _raceTrackDistance;

    public RaceTrack(int raceTrackDistance)
    {
        _raceTrackDistance = raceTrackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < _raceTrackDistance)
        {
            if (car.BatteryDrained())
            {
                return false;
            }
            car.Drive();
        }

        return true;
    }
}
