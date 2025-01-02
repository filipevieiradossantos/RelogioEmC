using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeuRelogio
{
    public class Relogio : Form
    {
        private System.Windows.Forms.Timer timer;
        private Label labelHora;
        private Button btnTelaCheia;
        private bool emTelaCheia;

        public Relogio()
        {
            // Configurações da janela
            this.Text = "Relógio";
            this.BackColor = Color.Black;
            this.Size = new Size(300, 200);

            // Label para mostrar a hora
            labelHora = new Label();
            labelHora.Font = new Font("Arial", 24);
            labelHora.ForeColor = Color.White;
            labelHora.Dock = DockStyle.Fill;
            labelHora.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(labelHora);

            // Botão para alternar tela cheia
            btnTelaCheia = new Button();
            btnTelaCheia.Text = "Tela Cheia";
            btnTelaCheia.ForeColor = Color.White; // Alterar a cor do texto do botão para branco
            btnTelaCheia.Dock = DockStyle.Bottom;
            btnTelaCheia.Click += BtnTelaCheia_Click;
            this.Controls.Add(btnTelaCheia);

            // Timer para atualizar a hora
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnTelaCheia_Click(object sender, EventArgs e)
        {
            if (emTelaCheia)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                btnTelaCheia.Text = "Tela Cheia";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Sair Tela Cheia";
            }
            emTelaCheia = !emTelaCheia;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Relogio());
        }
    }
}