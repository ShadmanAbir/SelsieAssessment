using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConflict
{
    public class TimeSlot
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class CalculateTime
    {
        public List<bool> Calculate(TimeSlot givenSlot, TimeSlot[] existingSlots)
        {
            var result = new List<bool>();
            if (existingSlots.Length < 1)
                result.Add(false);

            foreach (var slot in existingSlots)
            {
                if (givenSlot.StartTime <= slot.StartTime && givenSlot.EndTime <= slot.EndTime)
                {
                    result.Add(true);
                }
                else if (givenSlot.StartTime >= slot.StartTime && givenSlot.EndTime <= slot.EndTime)
                {
                    result.Add(true);
                }
                else if (givenSlot.StartTime <= slot.StartTime && givenSlot.EndTime >= slot.EndTime)
                {
                    result.Add(true);
                }
                
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
    }
}
