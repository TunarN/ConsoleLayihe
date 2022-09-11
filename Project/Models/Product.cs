namespace Project.Models
{
    class Product
    {
        private static int _id;
        private string _name;
        private string _inqredint;
        private int _price;
        
        public int Id { get; }
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (value!=null)
                {
                    _name = value;
                }
            }
                }
        public string Inqredint {
            get
            {
                return _inqredint;
            }
            set
            {
                if (value!=null)
                {
                    _inqredint = value;
                }
            }
                }
        public int Price {
            get
            {
                return _price;
            }

            set
            {
                if (value>0)
                {
                    _price = value;
                }
            }
                }

        public Product()
        {
            _id++;
            Id = _id;
        }
        //public override string ToString()
        //{
        //    return $"Id:{Id} Name:{Name} Inqredint:{Inqredint} Price:{Price}";
        //}
    }
}
