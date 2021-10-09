namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        private string _id;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public virtual void Talk() { }

    }
}