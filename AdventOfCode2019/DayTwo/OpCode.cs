
namespace AdventOfCode2019.DayTwo
{
    public enum CurrentOpCode
    {
        SUM,
        MULTIPLY,
        HALT,
        NONE
    }

    public class OpcodeFinder
    {
        public static CurrentOpCode GetOpcode(int number)
        {
            if (number == 1)
            {
                return CurrentOpCode.SUM;
            }
            else if (number == 2)
            {
                return CurrentOpCode.MULTIPLY;
            }
            else if (number == 99)
            {
                return CurrentOpCode.HALT;
            }
            else
            {
                return CurrentOpCode.NONE;
            }
        }
    
    }
    
}
