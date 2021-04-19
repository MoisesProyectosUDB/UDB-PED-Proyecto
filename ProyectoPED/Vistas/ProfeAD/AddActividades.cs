using ProyectoPED.Estructuras.ABL;
using ProyectoPED.Model;
using ProyectoPED.Model.CargarInfo;
using System;

using System.Windows.Forms;

namespace ProyectoPED.Vistas.ProfeAD
{
    public partial class AddActividades : Form
    {
        public AddActividades()
        {
            InitializeComponent();
        }
        Arbol<String> raiz = null;
        int noCoicidio = 0;
        CargarCombox OpcionCargaCombox = new CargarCombox();
        Funciones funciones = new Funciones();
        private void AddActividades_Load(object sender, EventArgs e)
        {
            cmboxCarrera.DataSource = OpcionCargaCombox.CargarCarrerasporUsario(Login.idUsuario);
            cmboxCarrera.DisplayMember = "NombreCarrera";
            cmboxCarrera.ValueMember = "IDCarrera";

            cmboxTipoActividad.DataSource = OpcionCargaCombox.CargarTipoActividades();
            cmboxTipoActividad.DisplayMember = "NombreActividad";
            cmboxTipoActividad.ValueMember = "IDActividades";
            button2.Enabled = false;
        }

        private void cmboxCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idcarera =int.Parse(cmboxCarrera.SelectedValue.ToString());
            cmboxMateria.DataSource = OpcionCargaCombox.CargarMateriasporCarreraUsuario(Login.idUsuario, idcarera);
            cmboxMateria.DisplayMember = "NombreMateria";
            cmboxMateria.ValueMember = "IDMateria";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(monthCalendar1.SelectionStart.ToShortDateString());

            
            

            if (raiz != null)
            {  
                crearhijos(cmboxTipoActividad.Text,textBox1.Text);
            }
            else
            { 
                CreaABLinicial(cmboxMateria.Text, cmboxTipoActividad.Text,textBox1.Text);
                cmboxCarrera.Enabled = false;
                cmboxMateria.Enabled = false;
                button2.Enabled = true;
            }
        }


       
        private void CreaABLinicial(string nameRaiz,  string hijotipo,string hijoNombre)
        {

            raiz = new Arbol<String>(null, nameRaiz.Substring(1, 6));//Se crea la Raiz papa
            Arbol <String> tipos = new Arbol<String>(raiz, hijotipo);//Se Crea  el nivel de tipo
            Arbol<String> nomAc = new Arbol<String>(tipos, hijoNombre);//Se crea eñ nivel de actividades
            tipos.agregarHijo(nomAc);
            raiz.agregarHijo(tipos);

        }

        private void crearhijos(string hijotipo,string hijosTareaname)
        {
            ////Recorremos la raiz
            for (int iRaiz = 0; iRaiz < raiz.getHijos().Count; iRaiz++)
            {
                if (raiz.getHijos()[iRaiz].getValor() == hijotipo)
                {
                    //MessageBox.Show("Este tipo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Arbol<String> nomAc = new Arbol<String>(raiz.getHijos()[iRaiz], hijosTareaname);//Se crea hijo  segun lo capturado
                    raiz.getHijos()[iRaiz].agregarHijo(nomAc);//se añade el hijo al padre
                    noCoicidio = 1;
                }
               
            
            }
            if (noCoicidio == 0)
            {
                //le crea otro el nuevo hijo tipo y su respectiva actividad
                Arbol<String> tipos = new Arbol<String>(raiz, hijotipo);//Se Crea  el nivel de tipo
                Arbol<String> nomAc = new Arbol<String>(tipos, hijosTareaname);//Se crea eñ nivel de actividades
                tipos.agregarHijo(nomAc);
                raiz.agregarHijo(tipos);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Cadena = DibujarFijura();//Obtienen la cadena a utilzar por Graphviz 
            if (string.IsNullOrEmpty(Cadena) != true)//Evaluamos si no esta null o vacia 
            {

                if (funciones.CrearArchivos(Cadena) == true) //Metodo para generar el Archivo
                {
                    if (funciones.Generate_Graph() == true)//metodo que genera la img y ejecuta el Comando // dot -Tjpg C:/ResultadoArbol\abbT.txt -o C:/ResultadoArbol\abbT.jpg
                    {
                        //Cargamos la img al picture
                        System.IO.FileStream AliasFigura; // Declaración del alias del archivo  Figura.jpg
                        try // Intenta abrir el archivo
                        {
                            AliasFigura = new System.IO.FileStream(@"C:\ResultadoArbol\abbT.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            abbIMG.Image = System.Drawing.Bitmap.FromStream(AliasFigura);// Intenta cargar la imagen en el pictureBox
                            AliasFigura.Close(); // Cierra el archivo   
                        }
                        catch (Exception x) // En caso de error ...
                        {

                            MessageBox.Show("No se pudo cargar la imagen del archivo", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                        finally
                        {

                            abbIMG.Refresh(); // Refresca la imagen
                        }




                    }
                }
                else
                {
                    MessageBox.Show("Error al Crear al Arbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ningun Valor Agregado al Arbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public string DibujarFijura()
        {
            String Resultado = null;
            if (raiz.getHijos().Count != 0)
            {



                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\n" + raiz.getValor() + "->";//Cabeza de la Raiz
                for (int iRaiz = 0; iRaiz < raiz.getHijos().Count; iRaiz++)//Recoriendo los hijos  del nivel uno
                {
                   if (iRaiz == 0) {
                        Resultado = Resultado + raiz.getHijos()[iRaiz].getValor() + ";";//Complemento de la Cabeza del Arbol
                                  }else { Resultado = Resultado + "\n" + raiz.getValor() + "->" + raiz.getHijos()[iRaiz].getValor() + ";"; }

                   
                    for (int hijostipos = 0; hijostipos < raiz.getHijos()[iRaiz].getHijos().Count; hijostipos++)//Recorremos hijos de  Genero
                        {
                            Resultado = Resultado + "\n" + raiz.getHijos()[iRaiz].getValor() + "->" + raiz.getHijos()[iRaiz].getHijos()[hijostipos].getValor() + ";";
                            for (int hijosactividad = 0; hijosactividad < raiz.getHijos()[iRaiz].getHijos()[hijostipos].getHijos().Count; hijosactividad++)
                            {
                                Resultado = Resultado + "\n" + raiz.getHijos()[iRaiz].getHijos()[hijostipos].getValor() + "->" + raiz.getHijos()[iRaiz].getHijos()[hijostipos].getHijos()[hijosactividad].getValor() + ";";
                            }
                        }
                    


                }
                Resultado = Resultado + "\n}";
                Console.WriteLine(Resultado);
                return Resultado;


            }
            else
            {

                return Resultado;
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "(PDE941)";
            char[] arr;

            arr = str.ToCharArray(1, 6);
            Console.WriteLine("The letters in '{0}' are: '", str);
            Console.WriteLine(arr);
        }
    }
}
