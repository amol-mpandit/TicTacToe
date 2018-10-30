namespace TicTacToe
{
    public class CrossMark : IMarks
    {
        public int Mark { get; set; }
        public int NoOfMarks { get; set; }
        public CrossMark()
        {
            Mark = 1;
        }

        public int GetMark()
        {
            return Mark;
        }
    }
    public class ZeroMark : IMarks
    {
        public int Mark { get; set; }
        public int NoOfMarks { get; set; }
        public ZeroMark()
        {
            Mark = 0;
        }

        public int GetMark()
        {
            return Mark;
        }
    }
}
