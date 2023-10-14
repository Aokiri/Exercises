// Link to the exercise: https://exercism.org/tracks/csharp/exercises/need-for-speed

using System;

class RemoteControlCar
{
    private int TotalBattery { get; set; }
    private int DrivenDistance { get; set; }
    private int Speed { get; set; }
    private int BatteryDrain { get; set; }

    public RemoteControlCar(int speed, int batteryDrain)
    {
        TotalBattery = 100;
        DrivenDistance = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => TotalBattery < BatteryDrain;

    public int DistanceDriven() => DrivenDistance;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            DrivenDistance += Speed;
            TotalBattery -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new(speed: 50, batteryDrain: 4);
}

class RaceTrack
{
    private int TrackDistance { get; set; }

    public RaceTrack(int trackDistance)
    {
        TrackDistance = trackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do
        {
            
            car.Drive();
        } while (!car.BatteryDrained());

        return car.DistanceDriven() >= TrackDistance;
    }
}