using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;
using System.Text;
using System.ComponentModel;
using System.Windows;


namespace ArduinoConection
{
    public partial class _Default : Page
    {
        SerialPort ardo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ardo = new SerialPort();
            ardo.PortName = "COM11";
            ardo.BaudRate = 9600;

        }

        protected void Button60_Click(object sender, EventArgs e)
        {
            string color3 = "3";
            ardo.Open();
            ardo.Write(color3);
            ardo.Close();
            Label1.Text = "DarkOrange";
        }

        protected void Button54_Click(object sender, EventArgs e)
        {
         
            string color1 = "1";
            ardo.Open();
            ardo.Write(color1);
            ardo.Close();
            Label1.Text = "ROJO";
        
    }

        protected void Button55_Click(object sender, EventArgs e)
        {
            string color5 = "5";
            ardo.Open();
            ardo.Write(color5);
            ardo.Close();
            Label1.Text = "VERDE";
        }

        protected void Button57_Click(object sender, EventArgs e)
        {
            string color2 = "2";
            ardo.Open();
            ardo.Write(color2);
            ardo.Close();
            Label1.Text = "Verde Primavera";
        }

        protected void Button63_Click(object sender, EventArgs e)
        {
            string color4 = "4";
            ardo.Open();
            ardo.Write(color4);
            ardo.Close();
            Label1.Text = "Oro";
        }

        protected void Button58_Click(object sender, EventArgs e)
        {
            string color6 = "6";
            ardo.Open();
            ardo.Write(color6);
            ardo.Close();
            Label1.Text = "Chartreuse";
        }

        protected void Button61_Click(object sender, EventArgs e)
        {
            string color7 = "7";
            ardo.Open();
            ardo.Write(color7);
            ardo.Close();
            Label1.Text = "Khaki";
        }

        protected void Button64_Click(object sender, EventArgs e)
        {
            string color8 = "8";
            ardo.Open();
            ardo.Write(color8);
            ardo.Close();
            Label1.Text = "Rosa";
        }

        protected void Button56_Click(object sender, EventArgs e)
        {
            string color9 = "9";
            ardo.Open();
            ardo.Write(color9);
            ardo.Close();
            Label1.Text = "AZUL";
        }

        protected void Button59_Click(object sender, EventArgs e)
        {
            string color10 = "0";
            ardo.Open();
            ardo.Write(color10);
            ardo.Close();
            Label1.Text = "Turquesa";
        }

        protected void Button62_Click(object sender, EventArgs e)
        {
            string color11 = "a";
            ardo.Open();
            ardo.Write(color11);
            ardo.Close();
            Label1.Text = "Marron";
        }

        protected void Button65_Click(object sender, EventArgs e)
        {
            string color12 = "b";
            ardo.Open();
            ardo.Write(color12);
            ardo.Close();
            Label1.Text = "Coral Claro";
        }
    }
}
