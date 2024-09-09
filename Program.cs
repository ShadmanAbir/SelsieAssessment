// See https://aka.ms/new-console-template for more information
using TimeConflict;
var Cal = new CalculateTime();
TimeSlot givenSlot = new TimeSlot
{
    StartTime = new DateTime(2024, 8, 19, 14, 0, 0),
    EndTime = new DateTime(2024, 8, 19, 15, 0, 0)
};
TimeSlot[] existingSlots = new TimeSlot[] {
 new TimeSlot
 {
 StartTime = new DateTime(2024, 8, 19, 13, 30, 0),
 EndTime = new DateTime(2024, 8, 19, 14, 30, 0)
 },
 new TimeSlot
 {
 StartTime = new DateTime(2024, 8, 19, 14, 45, 0),
 EndTime = new DateTime(2024, 8, 19, 15, 15, 0)
 },
 new TimeSlot
 {
 StartTime = new DateTime(2024, 8, 19, 16, 0, 0),
 EndTime = new DateTime(2024, 8, 19, 17, 0, 0)
 }

};


var result = Cal.Calculate(givenSlot, existingSlots);
foreach (var item in result)
{
    Console.WriteLine(item.ToString());
}
