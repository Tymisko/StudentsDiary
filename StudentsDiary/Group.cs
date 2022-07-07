namespace StudentsDiary
{
    public class Group
    {
        private readonly string _name;
        private readonly int _id;

        private Group()
        {
            // This ctor exists to fix "class cannot be serialized because it does not have a parameterless constructor"
        }

        public Group(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Id
        {
            get { return _id; }
        }
    }
}
