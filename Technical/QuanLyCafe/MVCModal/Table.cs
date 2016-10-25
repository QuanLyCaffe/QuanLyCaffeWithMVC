
namespace MVCModal
{
    public class Table
    {
        private string id;
        private string name;
        private bool isBusy;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }


        public Table(string name, string id, bool isBusy)
        {
            Name = name;
            IsBusy = isBusy;
            Id = id;
        }

        public Table()
        {

        }
    }
}
