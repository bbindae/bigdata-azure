using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDataPoc.EventProcessor.Worker.EventStorages
{
    public class MemoryEventStorage : EventStorageBase
    {
        public override StorageLevel Level => StorageLevel.Memory;
    }
}
