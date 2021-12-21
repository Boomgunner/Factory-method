using cars;

namespace builder
{
    abstract class firm
    {
       public string type;
        public firm(string type)
        {
            this.type=type;
        }
        public virtual car make(){return null;}
        
    }
    class jeep :firm
    {
        public string name;
        public jeep(string type,string name):base(type)
        {
            this.name=name;
        }
        public override car make()
        {
            return new Rubikon(type);
        }
    }
    class mercedes :firm
    {
        public string name;
        public mercedes(string type,string name):base(type)
        {
            this.name=name;
        }
        public override car make()
        {
            return new S(type);
        }
    }

    
}