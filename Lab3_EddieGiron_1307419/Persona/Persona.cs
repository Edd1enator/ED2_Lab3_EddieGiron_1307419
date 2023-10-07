using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_EddieGiron_1307419
{
    public class Persona: IComparable<Persona>
    {
        public Persona() {
            name = "";
            dpi = "";
            datebirth = "";
            address = "";
            companies = new string[] { };
            CartasRecomendacion = new List<CartaRecomendacion>();
        }
        public string name { get; set; }
        public string dpi { get; set; }
        public string datebirth { get; set; }
        public string address { get; set; }
        public string[] companies {  get; set; }
        public List<Dictionary<char, Letra>> diccionarios { get; set; }
        public List<double> cifrados { get; set; }
        public List<CartaRecomendacion> CartasRecomendacion {  get; set; }


        public int CompareTo(Persona other)
        {
            if (other == null) return 0;
            int result = this.dpi.CompareTo(other.dpi);
            if (result == 0) 
            {
                result = this.name.CompareTo(other.name);
            }
            return result;
        }
    }
   
}
