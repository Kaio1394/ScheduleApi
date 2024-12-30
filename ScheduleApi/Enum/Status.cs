namespace ScheduleApi.Enum
{
    public enum Status
    {
        STARTED,
        RUNNING,
        STOPPED,
        NONE /* Init Status after the job its created */,
        FINISH,
        WAITING
    }
}
