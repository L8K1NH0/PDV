using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPdv.View
{
    public partial class Erro : Form
    {
        public Erro()
        {
            InitializeComponent();
        }

        private Label messageLabel;

        public Erro(string message)
        {
            messageLabel = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Controls.Add(messageLabel);
        }
    }
}
