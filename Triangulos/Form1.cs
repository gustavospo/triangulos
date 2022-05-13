using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
           
        {
            InitializeComponent();
        }
        
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            const double PI = 3.1415926;
            int  nc = 0;
            string msg;
            double saa = 0;
            double sb=0; double t2=0; double vaa=0; double vB = 0; double vA = 0; double vC = 0; double t = 0; double sa = 0; double sc = 0; double sbb = 0;
            bool HayError = false;
            try
            {
                //destildo si el dato a ingresar es igual a la incognita
                if (Option_a.Checked)
                {
                    Check_a.Checked = false;
                }

                if (OptionB.Checked)
                {
                    CheckB.Checked = false;
                }

                if (OptionA.Checked)
                {
                    CheckA.Checked = false;
                }

                if (OptionC.Checked)
                {
                    CheckC.Checked = false;
                }

                TxtRst.Text = ("\r\n" + " - Datos ingresados - ");
            if ((CheckA.Checked))
            {
                // evalua los check box
                msg = "Ingrese el valor de A, (hipotenusa)";
                vA = float.Parse(Microsoft.VisualBasic.Interaction.InputBox(msg, "datos", 0.ToString()));
                TxtRst.Text = (TxtRst.Text + ("\r\n" + ('\t' + ("A= " + vA))));
                nc = 1;
            }

            if ((CheckB.Checked))
            {
                msg = "Ingrese el valor de B, (catero opuesto)";
                vB = float.Parse(Microsoft.VisualBasic.Interaction.InputBox(msg, "datos", 0.ToString()));
                TxtRst.Text = (TxtRst.Text + ("\r\n" + ('\t' + ("B= " + vB))));
                nc = nc + 1;
            }
                if ((CheckC.Checked))
                {
                    msg = "Ingrese el valor de C, (catero adyacente)";
                    vC = float.Parse(Microsoft.VisualBasic.Interaction.InputBox(msg, "datos", 0.ToString()));
                    TxtRst.Text = (TxtRst.Text + ("\r\n" + ('\t' + ("C= " + vC))));
                    nc = nc + 1;
                }
                if ((Check_a.Checked))
            {
                //compruebo que el angulo este dentro de los parametros, sino le vuelvo a pedir que reingrese
                while (((vaa <= 0)  || (vaa > 90)))
                {
                    msg = "Ingrese el valor del angulo a";
                    vaa = float.Parse(Microsoft.VisualBasic.Interaction.InputBox(msg, "datos", 0.ToString()));
                    if (((vaa > 90)  || (vaa <= 0)))
                    {
                        MessageBox.Show("Ingreso un angulo incorrecto", "Error al ingresar angulo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       
                    }

                }

                TxtRst.Text = (TxtRst.Text + ("\r\n" + ('\t' + ("Ang. a= " + vaa + "°"))));
                vaa = vaa * ( PI / 180);
                nc = (nc + 1);
                
            }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Error al ingresar datos \r\n" + ex.Message, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }
            // si los datos son menos de 2 a ocurrido un error
            if (nc < 2)
            {
                MessageBox.Show  ("Ingreso menos de dos dato o " + "\r\n" + "los datos ingresados son invalidos", "Error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                //******da formato a la presentación*********
                TxtRst.Text = TxtRst.Text + "\r\n" + "\r\n" + " - Datos calculados - ";

                //Empieza a calcular segun la incognita

                try
                {

                    if (OptionA.Checked )
                    {
                        if (vaa != 0)
                        {
                            if (vB != 0)
                            {
                                sa = vB / Math.Sin(vaa);
                            }
                            
                            else
                            {
                                sa = vC / Math.Cos(vaa);
                            }
                        }
                        else
                        {
                            sa = Math.Sqrt(Math.Pow(vC, 2) + Math.Pow(vB, 2));
                        }
                        
                        TxtRst.Text = TxtRst.Text + "\r\n" + "\t" + "A= " + sa.ToString("#0.00#", CultureInfo.InvariantCulture);
                    }
                    
                    // ************* Calcula el valor de B************
                    else if (OptionB.Checked)
                    {
                        if (vaa != 0)
                        {
                            if (vA != 0)
                            {
                                sb = vA * Math.Sin(vaa);
                            }
                            else
                            {
                                sb = vC * Math.Tan(vaa);
                            }
                        }
                        else
                        {
                            sb = Math.Sqrt(Math.Pow(vA, 2) - Math.Pow(vC, 2));
                        }
                        
                        TxtRst.Text = TxtRst.Text + "\r\n" + "\t" + "B= " + sb.ToString("#,##0.00#", CultureInfo.InvariantCulture);
                    }
                    
                    // ************** Calcula el valor de C***************
                    
                    else if (OptionC.Checked)
                    {
                        if (vaa != 0)
                        {
                            if (vA != 0)
                            {
                                sc = vA * Math.Cos(vaa);
                            }
                            else
                            {
                                sc = vB / Math.Tan(vaa);
                            }
                        }
                        else
                        {
                            sc = Math.Sqrt(Math.Pow(vA, 2) - Math.Pow(vB, 2));
                        }
                        
                        TxtRst.Text = TxtRst.Text + "\r\n" + "\t" + "C= " + sc.ToString("#,##0.00#", CultureInfo.InvariantCulture);
                    }
                    
                    // ********** Calcula el valor de a*************
                    
                    else if (Option_a.Checked )
                    {
                        if (vA != 0)
                        {
                            if (vB != 0)
                            {
                                t = vB / vA;
                                t2 = -t * t + 1;
                                if (t2 > 0)
                                {
                                   // Arcsin(X) = Atn(X / Sqr(-X * X + 1))
                                    saa = Math.Atan(t / Math.Sqrt(t2)) * (180 / PI);
                                }

                                else
                                {
                                HayError = true;
                                }
                            }
                            else
                            {
                                t = vC / vA;
                                t2 = -t * t + 1;
                                if (t2 > 0)
                                {
                                // Arccos(X) = Atn(-X / Sqr(-X * X + 1)) + 2 * Atn(1)
                                saa = (Math.Atan(-t / Math.Sqrt(t2)) + 2d * Math.Atan(1d)) * (180 / PI);
                                }

                                else
                                {
                                HayError = true;
                            }
                            }
                        }
                        else
                        {
                            saa = Math.Atan(vB / vC) * (180 / PI);
                        }
                        
                        TxtRst.Text = TxtRst.Text + "\r\n" + "\t" + "Angulo a= " + saa.ToString("#0.00#", CultureInfo.InvariantCulture) + "°";
                    }
                    
                    // **************calcula el angulo b*********
                    
                    else if (Option_b.Checked)
                    {
                        if (vaa != 0)
                        {
                            sbb = 90 - vaa * 57.2957795d;
                        }
                        else if (vA != 0)
                        {
                            if (vB != 0)
                            {
                                t = vB / vA;
                                t2 = -t * t + 1;
                                if (t2 > 0)
                                {
                                // Arcsin(X) = Atn(X / Sqr(-X * X + 1)) 
                                sbb = 90 - Math.Atan(t / Math.Sqrt(t2)) * (180 / PI);
                                }

                                else
                                {
                                HayError = true;
                            }
                            }
                            else
                            {
                                t = vC / vA;
                                t2 = -t * t + 1;
                                if (t2 > 0)
                                {
                                    // Arccos(X) = Atn(-X / Sqr(-X * X + 1)) + 2 * Atn(1)
                                    sbb = 90 - (Math.Atan(-t / Math.Sqrt(t2)) + 2d * Math.Atan(1d)) * (180 / PI);
                                }
                                
                                else
                                {
                                HayError = true;
                            }
                            }
                        }
                        else
                        {
                            sbb = 90 - Math.Atan(vB / vC) * (180 / PI);
                        }
                        
                        TxtRst.Text = TxtRst.Text + "\r\n" + "\t" + "Angulo b= " +sbb.ToString("#,##0.00#", CultureInfo.InvariantCulture) + "°";
                    }
                if (HayError ) 
                {
                   TxtRst.Text = "";
                    msg = "Los valores ingresados no son correctos," + "\r\n" + "por favor ingrese los valores validos.";
                    MessageBox.Show(msg,"Los datos no son correctos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar datos \r\n" + ex.Message, "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                  //  return;

                }
            }
            
        }

        private void Option_a_CheckedChanged(object sender, EventArgs e)
        {
            if (Option_a.Checked)
            {
                Check_a.Checked = false;

                //CheckA.Checked = false;
                //CheckB.Checked = false;
                //CheckC.Checked = false;
            }
        }
       
        private void OptionB_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionB.Checked)
            {
                CheckB.Checked = false;
            }
        }

        private void OptionA_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionA.Checked)
            {
                CheckA.Checked = false;
            }
        }

        private void OptionC_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionC.Checked)
            {
                CheckC.Checked = false;
            }
        }
    }
}
