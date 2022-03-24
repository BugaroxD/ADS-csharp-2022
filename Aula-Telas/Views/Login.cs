using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Views.Lib;

namespace Views
{
    public class Login : BaseForm
    {
        private System.ComponentModel.IContainer components = null;
        
        Field fieldUser;
        Field fieldPass;

        Button btnConfirm;
        Button btnCancel;

        public Login() : base("Login")
        {
            this.fieldUser = new Field(this.Controls, "Usuário", 20, true);
            this.fieldPass = new Field(this.Controls, "Senha", 80, true, true);
            this.fieldPass.textField.ForeColor = System.Drawing.Color.Blue;
            this.btnConfirm = new ButtonForm(this.Controls, "Confirmar", 100, 180, this.handleConfirmClick);
            this.btnCancel = new ButtonForm(this.Controls, "Cancelar", 100, 220, this.handleCancelClick);
            
            this.components = new System.ComponentModel.Container();
        }

        private void handleConfirmClick(object sender, EventArgs e) 
        {
            DialogResult result;
            Auth.Login(this.fieldUser.textField.Text, this.fieldPass.textField.Text);
            if (Auth.Dentista != null || Auth.Paciente)
            {
            result = MessageBox.Show(
                $"Usuário: {this.fieldUser.textField.Text}" +
                $"\nSenha: {this.fieldPass.textField.Text}",
                "Titulo da Mensagem",
                MessageBoxButtons.OK
                );
                if (result == DialogResult.OK)
                {
                InfoPaciente menu = new InfoPaciente();
                menu.ShowDialog();
                this.Close();
                }
                else
                {
                result = MessageBox.Show(
                    $"Email ou Senha inválido.",
                    "Erro de Login.",
                    MessageBoxButtons.OK
                    );
                }
            }
        }
        private void handleCancelClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}