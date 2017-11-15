using System;

namespace practice
{
    public class Can
    {
        public int percentageFull;
        public bool isOpen = false;

        internal void ReduceVolume()
        {
            percentageFull -= 10;
        }
        public bool OpenCan()
        {
            if (isOpen)
            {
                return true;
            }
            isOpen = true;

        }
    }
}