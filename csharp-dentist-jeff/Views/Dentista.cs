using System;
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
        public class FormDentista : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        Button btnDentista;
        Button btnProcedimento;
        Button btnSala;
        Button btnPaciente;
        Button btnEspecialidade;
        Button btnAgendamento;
        Button btnFechar;

        public FormDentista()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Bem-vindo " + Auth.Dentista.Nome;
            this.lblLogin.Location = new Point(50, 20);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(50, 70);
            this.btnDentista.Size = new Size(100, 30);
            this.btnDentista.Click += new EventHandler(this.handleCancelClick);

            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(50, 120);
            this.btnPaciente.Size = new Size(100, 30);
            this.btnPaciente.Click += new EventHandler(this.handlePacienteClick);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Location = new Point(50, 170);
            this.btnAgendamento.Size = new Size(100, 30);
            this.btnAgendamento.Click += new EventHandler(this.handleCancelClick);


            this.btnEspecialidade = new Button();
            this.btnEspecialidade.Text = "Especialidade";
            this.btnEspecialidade.Location = new Point(160, 70);
            this.btnEspecialidade.Size = new Size(100, 30);
            this.btnEspecialidade.Click += new EventHandler(this.handleCancelClick);

            this.btnProcedimento = new Button();
            this.btnProcedimento.Text = "Procedimento";
            this.btnProcedimento.Location = new Point(160, 120);
            this.btnProcedimento.Size = new Size(100, 30);
            this.btnProcedimento.Click += new EventHandler(this.handleCancelClick);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(160, 170);
            this.btnSala.Size = new Size(100, 30);
            this.btnSala.Click += new EventHandler(this.handleCancelClick);
            

            this.btnFechar = new Button();
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Location = new Point(100, 220);
            this.btnFechar.Size = new Size(120, 40);
            this.btnFechar.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLogin);

            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnFechar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Opções do Dentista";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handlePacienteClick(object sender, EventArgs e)
        {
            FormPaciente menu = new FormPaciente();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}