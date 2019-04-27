using System;

namespace BigDataPoc.EventProcessor.Worker.EventStorages
{
    public interface IEventStorage : IDisposable
    {
        StorageLevel Level { get; }
        string ReceivedAtHour { get; }
        string PartitionId { get; }
        
        void Initialize(string partitionId, string receivedAtHour);
        void WriteAsync(byte[] value);
        void Flush();
        void IsFlushOverdue();

    }
}
