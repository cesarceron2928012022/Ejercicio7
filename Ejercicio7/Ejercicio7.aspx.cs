using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace Ejercicio7
{
    public partial class Ejercicio7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button button;
            for (int i = 1; i <= 100; i++)
            {
                button = new Button();
                button.ID = $"Btn{i}";
                button.Width = 50;
                button.Text = i.ToString();
                button.BackColor = Color.AliceBlue;
                button.Click += new EventHandler(button_Click);
                Panel1.Controls.Add(button);
            }                                
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; ;
            int num = int.Parse(btn.Text);
            this.LblData.Visible = true;
            this.LblData.Text = GenerarTabla(num);
        }

        private string GenerarTabla(int numero)
        {
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{numero} x {i} = {numero * i}</br>";
            }
            return tabla;
        }
    }
}
