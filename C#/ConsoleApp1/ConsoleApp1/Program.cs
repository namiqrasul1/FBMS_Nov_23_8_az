using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            Button button = new Button()
            {
                AutoSize = true,
                Text = "Click me"
            };

            form.Controls.Add(button);
            form.ShowDialog();

        }
    }
}
