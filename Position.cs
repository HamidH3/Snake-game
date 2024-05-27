namespace snake{
    public class Position{
        public int Row {get;}
        public int Col {get;}

        public Position(int row, int col){
            Row = row;
            Col = col;
        }

        public Position Translate(Direction dir)
        //this returns position by moving one step in a given direction
        {
            return new Position (Row + dir.RowOffset, Col + dir.ColOffset);

        }

        public override bool Equals(object obj)
        {
            if (obj is Position position)
            {
                return Row == position.Row && Col == position.Col;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);

        }
        public static bool operator != (Position left, Position right)
        {
            return !(left == right);
        }

    }
}