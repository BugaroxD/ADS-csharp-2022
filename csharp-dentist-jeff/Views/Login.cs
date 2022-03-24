/*using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Models;

namespace Views
{
    static class ProgramT
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
    public class FormLogin : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLine;
        Label lblUser;
        Label lblPass;
        TextBox txtUser;
        TextBox txtPass;
        Button btnConfirm;
        Button btnCancel;
        

        public FormLogin()
        {

            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(50, 30);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(50, 120);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(50, 60);
            this.txtUser.Size = new Size(200, 30);

            this.lblLine = new Label();
            this.lblLine.Text = "__________________________";
            this.lblLine.Location = new Point(50, 90);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(50, 150);
            this.txtPass.Size = new Size(200, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 190);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 230);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void handleConfirmClick(object sender, EventArgs e)
        {
            try
            {
                Auth.Login(txtUser.Text, txtPass.Text);
                if (Auth.Dentista != null)
                {
                    FormDentista menu = new FormDentista();
                    menu.Size = new Size(330, 350);
                    menu.Show();
                }
                if (Auth.Paciente != null)
                {
                    FormPaciente menu = new FormPaciente();
                    menu.Show();
                }

                Auth.Logout();

            }
            catch (Exception err)
            {
                MessageBox.Show(
                        err.Message,
                        "Opção Inválida!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}*/