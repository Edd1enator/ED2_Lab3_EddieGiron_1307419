using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Es_Arboles;

namespace Lab3_EddieGiron_1307419
{
    public partial class Form1 : Form
    {
        private List<Persona> listPersona = new List<Persona>();
        private Es_Arboles.AVL<Persona> AVL = new Es_Arboles.AVL<Persona>();
        private List<Persona> listBusquedas = new List<Persona>();
        private int tlist;
        private int max;
        private int min;
        private int ncont;
        private Persona Buscando;
        public Form1()
        {
            InitializeComponent();
            CargarArchivo();
        }
        public void CargarArchivo()
        {
            Persona aux = new Persona();
            Aritmetica aritmetica = new Aritmetica();

            string ruta = "C:/Users/eddie/OneDrive - Universidad Rafael Landivar/U/Año 5/Segundo Ciclo/Estructura de datos 2 (lab)/Laboratorio 2/input lab2.csv";

            foreach (string item in File.ReadLines(ruta))
            {
                if (item.StartsWith("INSERT;"))
                {
                    string json = item.Substring(7);
                    Persona persona = JsonConvert.DeserializeObject<Persona>(json);
                    List<Dictionary<char, Letra>> lista = new List<Dictionary<char, Letra>>();
                    Array.Sort(persona.companies, (x, y) => String.Compare(x, y));
                    List<double> codigos = new List<double>();
                    for (int i = 0; i < persona.companies.Length; i++)
                    {
                        Dictionary<char, Letra> dictionary = new Dictionary<char, Letra>();
                        string codigo = persona.dpi + i.ToString();
                        foreach (var c in codigo)
                        {
                            Letra nueva = new Letra(); //Se llena el diccionario de todas las letras
                            if (!dictionary.ContainsKey(c))
                            {
                                dictionary.Add(c, nueva);
                            }
                            dictionary[c].frecuencia++; //Se aumenta la frecuencia de cada letra
                        }

                        double inf = 0, sup = 0, p = 0;
                        foreach (var c in dictionary)
                        {
                            //Se calcula la probabilidad y los limites inferior y superior
                            p = (double)c.Value.frecuencia / codigo.Length;
                            sup = inf + p;
                            dictionary[c.Key].probabilidad = p;
                            dictionary[c.Key].inferior = inf;
                            dictionary[c.Key].superior = sup;
                            inf = sup;
                        }

                        double newCode = aritmetica.Coding(codigo, dictionary);
                        codigos.Add(newCode);
                        lista.Add(dictionary);
                    }
                    persona.diccionarios = lista;
                    persona.cifrados = codigos;
                    listPersona.Add(persona);
                    AVL.Add(persona);

                }
                else if (item.StartsWith("DELETE;"))
                {
                    bool verifica = true;
                    string json = item.Substring(7);
                    Persona persona = JsonConvert.DeserializeObject<Persona>(json);
                    for (int i = 0; i < listPersona.Count; i++)
                    {
                        if (persona.name == listPersona[i].name && persona.dpi == listPersona[i].dpi)
                        {
                            listPersona.RemoveAt(i);
                            AVL.Remove(persona);
                            verifica = false;
                        }
                    }
                    if (verifica)
                    {
                        MessageBox.Show("Error, una persona a eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (item.StartsWith("PATCH;"))
                {
                    string json = item.Substring(6);
                    Persona persona = JsonConvert.DeserializeObject<Persona>(json);
                    Persona ext;
                    for (int i = 0; i < listPersona.Count; i++)
                    {
                        if (persona.dpi == listPersona[i].dpi)
                        {
                            ext = listPersona[i];
                            if (persona.companies == listPersona[i].companies)
                            {
                                listPersona[i] = persona;
                                listPersona[i].cifrados = ext.cifrados;
                            }
                            else
                            {
                                List<Dictionary<char, Letra>> lista = new List<Dictionary<char, Letra>>();
                                Array.Sort(persona.companies, (x, y) => String.Compare(x, y));
                                List<double> codigos = new List<double>();
                                for (int o = 0; o < persona.companies.Length; o++)
                                {
                                    Dictionary<char, Letra> dictionary = new Dictionary<char, Letra>();
                                    string codigo = persona.dpi + o.ToString();
                                    foreach (var c in codigo)
                                    {
                                        Letra nueva = new Letra(); //Se llena el diccionario de todas las letras
                                        if (!dictionary.ContainsKey(c))
                                        {
                                            dictionary.Add(c, nueva);
                                        }
                                        dictionary[c].frecuencia++; //Se aumenta la frecuencia de cada letra
                                    }

                                    double inf = 0, sup = 0, p = 0;
                                    foreach (var c in dictionary)
                                    {
                                        //Se calcula la probabilidad y los limites inferior y superior
                                        p = (double)c.Value.frecuencia / codigo.Length;
                                        sup = inf + p;
                                        dictionary[c.Key].probabilidad = p;
                                        dictionary[c.Key].inferior = inf;
                                        dictionary[c.Key].superior = sup;
                                        inf = sup;
                                    }

                                    double newCode = aritmetica.Coding(codigo, dictionary);
                                    codigos.Add(newCode);
                                    lista.Add(dictionary);
                                }
                                listPersona[i].diccionarios = lista;
                                listPersona[i].cifrados = codigos;
                            }
                        }
                    }
                }
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            lstPersona.Items.Clear();
            tlist = listPersona.Count;
            max = tlist / 1000;
            min = 0;
            ncont = 0;
            if (tlist < 1000)
            {
                for (int i = 0; i < tlist; i++)
                {
                    lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                }
            }
            else
            {
                for (int i = 0; i < 1000; i++)
                {
                    lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Persona> prueba = new List<Persona>();
            lstPersona.Items.Clear();
            if (txtBuscar.Text.Length == 0)
            {
                MessageBox.Show("No se digitó ningún nombre", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string nombre = txtBuscar.Text;
            nombre = nombre.ToLower();
            Persona Buscar = new Persona();
            Buscar.name = nombre;
            Node<Persona> BuscarN = new Node<Persona>();
            BuscarN.Valor = Buscar;
            foreach (Persona item in listPersona)
            {
                if (item.name == nombre)
                {
                    lstPersona.Items.Add($"{item.name} {item.dpi} {item.datebirth} {item.address}");
                }
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            lstPersona.Items.Clear();
            if (ncont <= max)
            {
                ncont++;
                int indice = ncont * 1000;
                if (indice + 1000 > tlist)
                {
                    for (int i = indice; i < tlist; i++)
                    {
                        lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                    }
                }
                else
                {
                    for (int i = indice; i < indice + 1000; i++)
                    {
                        lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                    }
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            lstPersona.Items.Clear();
            if (ncont > min)
            {
                ncont--;
                int indice = ncont * 1000;
                if (indice + 1000 > tlist)
                {
                    indice = tlist - 1000;
                    for (int i = indice; i < tlist; i++)
                    {
                        lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                    }
                }
                else
                {
                    for (int i = indice; i < indice + 1000; i++)
                    {
                        lstPersona.Items.Add($"{listPersona[i].name} {listPersona[i].dpi} {listPersona[i].datebirth} {listPersona[i].address}");
                    }
                }
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            string rutasalida = "C:/Users/eddie/OneDrive - Universidad Rafael Landivar/U/Año 5/Segundo Ciclo/Estructura de datos 2 (lab)/Laboratorio 2/output.json";
            string jsonout = JsonConvert.SerializeObject(listPersona, Formatting.Indented);
            File.WriteAllText(rutasalida, jsonout);
        }
        private void btnBuscarDPI_Click(object sender, EventArgs e)
        {
            try
            {
                cmbCompanies.Items.Clear();
                List<Persona> prueba = new List<Persona>();
                lstPersona.Items.Clear();
                if (txtBuscarDPI.Text.Length == 0)
                {
                    MessageBox.Show("No se digitó ningún dpi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string dpi = txtBuscarDPI.Text;
                Persona Buscar = new Persona();
                Buscar.dpi = dpi;
                Node<Persona> BuscarD = new Node<Persona>();
                BuscarD.Valor = Buscar;
                string companiesLine = "";
                string cifradosLine = "";
                foreach (Persona item in listPersona)
                {
                    if (item.dpi == dpi)
                    {
                        foreach (string empresa in item.companies)
                        {
                            companiesLine = companiesLine + " # " + empresa;
                            cmbCompanies.Items.Add(empresa);
                        }
                        foreach (double codificado in item.cifrados)
                        {
                            cifradosLine = cifradosLine + " # " + codificado;
                        }
                        lstPersona.Items.Add("Compañías: " + companiesLine);
                        lstPersona.Items.Add("Cifrados: " + cifradosLine);
                        Buscando = item;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            try
            {
                Aritmetica aritmetica = new Aritmetica();
                lstPersona.Items.Clear();
                string comp = cmbCompanies.Text;
                if (cmbCompanies.Text == null)
                {
                    MessageBox.Show("No se seleccionó ninguna compañia", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int indice = Array.BinarySearch(Buscando.companies, comp);
                double cifrado = Buscando.cifrados[indice];
                Dictionary<char, Letra> DicBuscando = Buscando.diccionarios[indice];
                string result = aritmetica.Decode(cifrado, DicBuscando);
                lstPersona.Items.Add("DPI decodificado: " + result);
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Sin uso
        private void cmbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtBuscarDPI_TextChanged(object sender, EventArgs e)
        {
        }
        private void lstPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
