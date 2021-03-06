﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Programacion_i_jonathan_rondon_2017_30_3_0019_p1
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        string op;
        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            px9cuadrado.Visible = false;
            px9rectangulo.Visible = false;
            _soundPlayer = new SoundPlayer("beat.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {

        }

        private void btncln_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            //txtresultado.Text = Convert.ToString("1");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
            btnpunto.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "1";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "2";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "3";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "4";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "5";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "6";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "7";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "8";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "9";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text.Length == 0)
            {
                txtvalor.Text = "0";
            }
            else if (txtvalor.Text.Substring(0) != "0")
            {
                txtvalor.Text = txtvalor.Text + "0";
            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "+";
        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "-";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "/";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {          

            
            if (txtvalor.Text == "")
            {
                btnpunto.Enabled = true;
                return;
            }
            else
            {
                txtvalor.Text = txtvalor.Text.Remove(txtvalor.Text.Length - 1, 1);
            }
            btnpunto.Enabled = !txtvalor.Text.Contains(".") && txtvalor.Text != "";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //Codigo para hacer el cuadro de guardado
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Cálculo.txt";
            savefile.Filter = "Text files (*.txt)|*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(
                        "El primer valor fue: " + num1 + Environment.NewLine +
                        "El segundo valor fue: " + num2 + Environment.NewLine +
                        "El operador utilizado fue: " + op + Environment.NewLine +
                        "El resultado fue: " + result
                        );
                //Esto abre el archivo una vez guardado
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstb1actividades_Enter(object sender, EventArgs e)
        {

        }

        private void lstb1actividades_Leave(object sender, EventArgs e)
        {

        }

        private void txt1apellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1nombre_Enter(object sender, EventArgs e)
        {
            if (txt1nombre.Text == "Nombre")
            {
                txt1nombre.Text = "";
                txt1nombre.ForeColor = Color.Black;
            }
        }

        private void txt1nombre_Leave(object sender, EventArgs e)
        {
            if (txt1nombre.Text == "")
            {
                txt1nombre.Text = "Nombre";
                txt1nombre.ForeColor = Color.Silver;
            }
        }

        private void txt1apellido1_Enter(object sender, EventArgs e)
        {
            if (txt1apellido1.Text == "P. Apellido")
            {
                txt1apellido1.Text = "";
                txt1apellido1.ForeColor = Color.Black;
            }
        }

        private void txt1apellido1_Leave(object sender, EventArgs e)
        {
            if (txt1apellido1.Text == "")
            {
                txt1apellido1.Text = "P. Apellido";
                txt1apellido1.ForeColor = Color.Silver;
            }
        }

        private void txt1apellido2_Enter(object sender, EventArgs e)
        {
            if (txt1apellido2.Text == "S. Apellido")
            {
                txt1apellido2.Text = "";
                txt1apellido2.ForeColor = Color.Black;
            }
        }

        private void txt1apellido2_Leave(object sender, EventArgs e)
        {
            if (txt1apellido2.Text == "")
            {
                txt1apellido2.Text = "S. Apellido";
                txt1apellido2.ForeColor = Color.Silver;
            }
        }

        private void txt1descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1descripcion_Leave(object sender, EventArgs e)
        {
            if (txt1descripcion.Text == "")
            {
                txt1descripcion.Text = "Descripción";
                txt1descripcion.ForeColor = Color.Silver;
            }
        }

        private void txt1descripcion_Enter(object sender, EventArgs e)
        {
            if (txt1descripcion.Text == "Descripción")
            {
                txt1descripcion.Text = "";
                txt1descripcion.ForeColor = Color.Black;
            }
        }

        private void txt1apellido2_TextChanged(object sender, EventArgs e)
        {

        }

        string genero;
        private void btn1guardar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            string nombre, apellido1, apellido2, descripcion, fecha, nacionalidad, preferencias;
            Boolean marcado;
            //conversion de variables
            nombre = Convert.ToString(txt1nombre.Text);
            apellido1 = Convert.ToString(txt1apellido1.Text);
            apellido2 = Convert.ToString(txt1apellido2.Text);
            descripcion = Convert.ToString(txt1descripcion.Text);
            fecha = Convert.ToString(date1fecha.Text);
            nacionalidad = Convert.ToString(cb1nacionalidad.Text);
            preferencias = Convert.ToString(lstb1actividades.Text);
            marcado = Convert.ToBoolean(chk1datos.Checked);
            //genero = Convert.ToString();

            //Codigo para hacer el cuadro de guardado
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Datos del usuario.txt";
            savefile.Filter = "Text files (*.txt)|*.txt";
            StreamWriter sw;
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //using (sw = new StreamWriter(savefile.FileName))
                //    sw.WriteLine( 
                //        "Nombre: " + nombre + Environment.NewLine +
                //        "Primer Apellido: " + apellido1 + Environment.NewLine +
                //        "Segundo Apellido: " + apellido2 + Environment.NewLine +
                //        "Nacionalidad: " + nacionalidad + Environment.NewLine +
                //        "Sexo: " + genero + Environment.NewLine +
                //        "Descripción: " + descripcion + Environment.NewLine +
                //        "Preferencia: " + preferencias + Environment.NewLine);
                //if (marcado)
                //{
                    using (sw = new StreamWriter(savefile.FileName))
                        sw.WriteLine(
                            "Nombre: " + nombre + Environment.NewLine +
                            "Primer Apellido: " + apellido1 + Environment.NewLine +
                            "Segundo Apellido: " + apellido2 + Environment.NewLine +
                            "Nacionalidad: " + nacionalidad + Environment.NewLine +
                            "Sexo: " + genero + Environment.NewLine +
                            "Descripción: " + descripcion + Environment.NewLine +
                            "Preferencia: " + preferencias + Environment.NewLine + 
                            (chk1datos.Checked ? "Fecha de Nacimiento: " + fecha : String.Empty));
                //}
                //Esto abre el archivo una vez guardado
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        private void btn1nuevo_Click(object sender, EventArgs e)
        {
            txt1nombre.Clear();
            txt1apellido1.Clear();
            txt1apellido2.Clear();
            cb1nacionalidad.ResetText();
            date1fecha.ResetText();
            txt1descripcion.Clear();
            chk1datos.Checked = false;
            lstb1actividades.ResetText();
            rdb1masculino.Checked = false;
            rdb1femenino.Checked = false;
            rdb1otro.Checked = false;
            txt1nombre.Text = "Nombre";
            txt1nombre.ForeColor = Color.Silver;
            txt1descripcion.Text = "Descripción";
            txt1descripcion.ForeColor = Color.Silver;
            txt1apellido2.Text = "S. Apellido";
            txt1apellido2.ForeColor = Color.Silver;
            txt1apellido1.Text = "P. Apellido";
            txt1apellido1.ForeColor = Color.Silver;
        }

        private void rdb1masculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Masculino";
        }

        private void rdb1femenino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Femenino";
        }

        private void rdb1otro_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Otro";
        }

        private void btn2calc_Click(object sender, EventArgs e)
        {
            //declarar variables
            double num1, num2, sum, rest, mult, div, pot, rai;
            //entrada de datos
            num1 = double.Parse(txt2valor1.Text);
            num2 = Convert.ToDouble(txt2valor2.Text);
            //proceso
            sum = num1 + num2;
            rest = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            pot = Math.Pow(num1, num2);
            rai = Math.Pow(num1, (1 / num2));
            //salida de info
            txt2sum.Text = Convert.ToString(sum);
            txt2rest.Text = Convert.ToString(rest);
            txt2div.Text = Convert.ToString(rest);
            txt2mult.Text = Convert.ToString(mult);
            txt2pot.Text = Convert.ToString(pot);
            txt2rai.Text = Convert.ToString(rai);
        }

        private void btn2cln_Click(object sender, EventArgs e)
        {
            txt2valor1.Clear();
            txt2valor2.Clear();
            txt2sum.Clear();
            txt2rest.Clear();
            txt2mult.Clear();
            txt2div.Clear();
            txt2pot.Clear();
            txt2rai.Clear();
        }

        private void btn3cls_Click(object sender, EventArgs e)
        {
            txt3capital.Clear();
            txt3interes.Clear();
            txt3monto.Clear();
            txt3razon.Clear();
            txt3tiempo.Clear();
        }

        private void btn3calc_Click(object sender, EventArgs e)
        {
            //Declaraciñon de variables
            double capital, razon, tiempo, interes, monto;
            //Entrada de datos
            capital = double.Parse(txt3capital.Text);
            razon = double.Parse(txt3razon.Text);
            tiempo = double.Parse(txt3tiempo.Text);
            //Proceso
            monto = Math.Pow((1 + razon), tiempo) * capital;
            interes = monto - capital;
            //Salida de la información
            txt3monto.Text = Convert.ToString(monto);
            txt3interes.Text = Convert.ToString(interes);
        }

        private void dud4hijos_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btn4calcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int horasextras, horasnormales;
            double pagohnormal, pagohextra, sueldobruto, sueldoneto, bonificacion;
            byte nhijos;
            Boolean marcado;
            //Entrada de datos
            horasnormales = Convert.ToInt32(txt4horasnormales.Text);
            horasextras = Convert.ToInt32(txt4horasextras.Text);
            pagohnormal = Convert.ToDouble(txt4pagonormal.Text);
            pagohextra = Convert.ToDouble(txt4horasextras.Text);
            nhijos = Convert.ToByte(dud4hijos.Value);
            marcado = Convert.ToBoolean(chk4bonificacion.Checked);
            //Inicializar
            bonificacion = 0.0;
            //Proceso
            sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra);
            //Evaluar bonificación
            if (marcado == true)
            {
                bonificacion = nhijos * 20;
            }
            sueldoneto = sueldobruto + bonificacion;
            //Salida
            txt4sueldobruto.Text = "$. "+Convert.ToString(sueldobruto);
            txt4bonificacion.Text = "$. " + Convert.ToString(bonificacion);
            txt4sueldoneto.Text = "$. " + Convert.ToString(sueldoneto);
        }

        private void btn4salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn4nuevo_Click(object sender, EventArgs e)
        {
            txt4bonificacion.Clear();
            txt4horasextras.Clear();
            txt4horasnormales.Clear();
            txt4pagohora.Clear();
            txt4pagonormal.Clear();
            txt4sueldobruto.Clear();
            txt4sueldoneto.Clear();
            chk4bonificacion.Checked = false;
            dud4hijos.Value = 0;
        }

        private void btn9calcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            double ladoa, ladob, area, perimetro;
            //Entrada de datos
            ladoa = Convert.ToDouble(txt9ladoa.Text);
            ladob = Convert.ToDouble(txt9ladob.Text);
            //Proceso
            //Evaluar si es un cuadrado o un rectangulo
            if (ladoa == ladob)
            {
                px9cuadrado.Visible = true;
                px9rectangulo.Visible = false;
            }
            else
            {
                px9cuadrado.Visible = false;
                px9rectangulo.Visible = true;
            }
            //Calcular el área y perímetro
            area = ladoa * ladob;
            perimetro = 2 * (ladoa + ladob);
            //Salida de datos
            txt9area.Text = Convert.ToString(area);
            txt9perimetro.Text = Convert.ToString(perimetro);
        }

        private void btn9salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn9nuevo_Click(object sender, EventArgs e)
        {
            txt9area.Clear();
            txt9ladoa.Clear();
            txt9ladob.Clear();
            txt9perimetro.Clear();
            px9rectangulo.Visible = false;
            px9cuadrado.Visible = false;
        }

        private void btn5calcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            byte temperatura;
            string clima;
            //Entrada de datos
            temperatura = Convert.ToByte(txt5temperatura.Text);
            //Proceso
            if (temperatura < 10)
            {
                clima = "Frio";
            }
            else if (temperatura >=10 && temperatura <=20)
            {
                clima = "Nublado";
            }
            else if (temperatura >20 && temperatura <= 30)
            {
                clima = "Calor";
            }
            else
            {
                clima = "Tropical";
            }
            //Salida de datos
            txt5clima.Text = clima;
        }

        private void btn5nuevo_Click(object sender, EventArgs e)
        {
            txt5clima.Clear();
            txt5temperatura.Clear();
            txt5temperatura.Text = "Expresado en Cº";
            txt5temperatura.ForeColor = Color.Silver;
        }

        private void btn5salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Declarar variables
            byte numero;
            string dia;
            //Entrada de datos
            numero = Convert.ToByte(txt6numero.Text);
            //Proceso
            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Ingrese un numero del 1 al 7";
                    break;
            }
            //Salida de datos
            txt6semana.Text = dia;
        }

        private void btn6nuevo_Click(object sender, EventArgs e)
        {
            txt6numero.Clear();
            txt6semana.Clear();
        }

        private void btn6salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl7timer.Text = DateTime.Now.ToLongTimeString();
        }

        private int num7num = 0;

        private void tm7timer2_Tick(object sender, EventArgs e)
        {
            num7num = num7num + 1;
            if (num7num % 2==0)
            {
                lbl7rojo.Visible = true;
                lbl7azul.Visible = false;
            }
            else
            {
                lbl7rojo.Visible = false;
                lbl7azul.Visible = true;
            }
        }

        private void btn7comenzar_Click(object sender, EventArgs e)
        {
            tm7timer2.Enabled = true;
            _soundPlayer.PlayLooping();
        }

        private void btn7parar_Click(object sender, EventArgs e)
        {
            tm7timer2.Enabled = false;
            _soundPlayer.Stop();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir de la aplicación?", "Salir del Programa", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Close();
            }
        }

        private void btn8datos_Click(object sender, EventArgs e)
        {
            //Declarar variables
            string nombre;
            //Inicio
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su nombre de usuario:", "Registro de Datos", "Usuario", 100,0);
            if (nombre != "admin")
            {
                MessageBox.Show("El nombre de usuario: '" + nombre +"' no es un nombre de usuario valido.", "Error en Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bienvenido: " + nombre, "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt5temperatura_Enter(object sender, EventArgs e)
        {
            if (txt5temperatura.Text == "Expresado en Cº")
            {
                txt5temperatura.Text = "";
                txt5temperatura.ForeColor = Color.Black;
            }
        }

        private void txt5temperatura_Leave(object sender, EventArgs e)
        {
            if (txt5temperatura.Text == "")
            {
                txt5temperatura.Text = "Expresado en Cº";
                txt5temperatura.ForeColor = Color.Silver;
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "0.";
            }
            //else
            //{
            //    txtvalor.Text = txtvalor.Text + ".";
            //}
            if (txtvalor.Text.Contains("."))
            {
                btnpunto.Enabled = false;
            }
            else
            {
                txtvalor.Text = txtvalor.Text + ".";
            }
        }

        private void btncalc_Click_1(object sender, EventArgs e)
        {
            if (txtvalor.Text == "" || txtvalor.Text == "Por favor introducir los valores.")
            {
                txtvalor.Text = "Por favor introducir los valores.";
            }
            else
            {
            num2 = Convert.ToDouble(txtvalor.Text);
            if (op == "+")
            {
                result = (num1 + num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "-")
            {
                result = (num1 - num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "*")
            {
                result = (num1 * num2);
                txtvalor.Text = Convert.ToString(result);
                num1 = result;
            }
            if (op == "/")
            {
                if (num2 == 0)
                {
                    txtvalor.Text = "No se puede dividir entre cero.";
                }
                else
                {
                    result = (num1 / num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
            }
        }
    }
}
