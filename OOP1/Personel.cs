
namespace OOP1
{
    public class Personel : IEntity
    {
        public static int PS_Ver = 5; 
        protected int id;//personeli miras alan sınıf ulaşabilir
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int CreatedByUser { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
 
        public Personel()
        {
        }
        public Personel(int id)
        {
            this.id = id;
        }
        

        public virtual string BilgisiniGetir()
        {
            return $"Personel: {Id} - {Ad} {Soyad}";
        }

        public override string ToString()
        {
            return $"{Id} - {Ad} {Soyad}";
        }
    }
}
