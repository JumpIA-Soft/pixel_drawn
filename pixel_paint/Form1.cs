using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixel_paint
{
    public partial class Form1 : Form
    {
        Bitmap pixelVector = new Bitmap(400, 300); // crear un objeto tipo Bitmap=crear pixel o pixel
        public Form1()
        {
            InitializeComponent();
        }

        private void crearPixel_Click(object sender, EventArgs e)
        {
            Color color0; //definimos un atributo de tipo Color
            
            //color0 = Color.BlueViolet; // asignamos el color Rojo

            color0 = Color.FromArgb(0, 0, 0); //asignamos un color segun un forma to RBG https://docs.microsoft.com/en-us/dotnet/api/system.drawing.color.toargb?view=net-5.0#System_Drawing_Color_ToArgb

            int X = 1, Y = 2;
            for (int i = 0; i < 100; i++)
            {
                X = i;
                if (X % 2 != 0)
                {
                    pixelVector.SetPixel(X, Y, color0);//funcion por defecto para asignar una poscion en la pantalla con el color
                }
            }

            marco.Image = pixelVector; //asignamos los valores del pixel al objeto imagen de la GUI
        }
    }
}
