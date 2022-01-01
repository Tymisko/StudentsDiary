namespace StudentsDiary
{
    internal class Group
    {
        private readonly int _id;
        public Group(int id)
        {
            _id = id;
        }

        public int Id 
        { 
            get
            {
                return _id;
            }
        }
    }
}
