using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDataPoc.EventProcessor.Worker.EventStorages
{
    public class EventStorageBase : IEventStorage
    {
        public virtual StorageLevel Level { get; private set; }

        public string ReceivedAtHour { get; private set; }

        public string PartitionId { get; private set; }

        public virtual void Initialize(string partitionId, string receivedAtHour)
        {
            PartitionId = partitionId;
            ReceivedAtHour = receivedAtHour;


        }

        public void Flush()
        {
            throw new NotImplementedException();
        }

        

        public void IsFlushOverdue()
        {
            throw new NotImplementedException();
        }

        public void WriteAsync(byte[] value)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
