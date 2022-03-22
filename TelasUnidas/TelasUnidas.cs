using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace TelaT
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
            if (this.txtUser.Text == "teste" && this.txtPass.Text == "teste")
            {
                FormDentista form = new FormDentista();
                form.Size = new Size(330, 350);
                form.Show();
                this.BackColor = Color.Red;
            }
            else
            {
                FormOpcaoInvalida form = new FormOpcaoInvalida();
                form.Show();
                this.BackColor = Color.Yellow;

            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FormOpcaoInvalida : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblInvalid;
        Button btnCancel;

        public FormOpcaoInvalida()
        {
            this.lblInvalid = new Label();
            this.lblInvalid.Text = "Opção Inválida";
            this.lblInvalid.Location = new Point(50, 30);
            this.Controls.Add(this.lblInvalid);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 230);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnCancel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Opção Inválida";
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }


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
            this.lblLogin.Text = "Oi Usuário";
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

    public class FormPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;
        Button btnInsert;
        Button btnDelete;
        Button btnUpdate;

        ListView listView;
        public FormPaciente()
        {
            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Location = new Point(220, 30);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 120);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmInserirPaciente);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(160, 220);
            this.btnUpdate.Size = new Size(80, 30);

            this.btnDelete = new Button();
            this.btnDelete.Text = "Excluir";
            this.btnDelete.Location = new Point(260, 220);
            this.btnDelete.Size = new Size(80, 30);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Fechar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);


            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Text = "Informações do Paciente";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmInserirPaciente(object sender, EventArgs e)
        {
            FormInserirPaciente menu = new FormInserirPaciente();
            menu.Size = new Size(325, 520);
            menu.ShowDialog();
            this.BackColor = Color.Cyan;

        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class FormInserirPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblDataNasc;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;

        TextBox txtNome;
        TextBox txtCpf;
        DateTimePicker dtpDataNasc;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;

        Button btnConfirm;
        Button btnCancel;

        public FormInserirPaciente()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(30, 20);


            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(30, 80);
            this.lblCpf.Size = new Size(300, 30);

            this.lblDataNasc = new Label();
            this.lblDataNasc.Text = "Data de Nascimento";
            this.lblDataNasc.Location = new Point(30, 140);
            this.lblDataNasc.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(30, 220);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(30, 280);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(30, 340);
            this.lblSenha.Size = new Size(300, 30);


            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(30, 50);
            this.txtNome.Size = new Size(250, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(30, 110);
            this.txtCpf.Size = new Size(250, 30);

            this.dtpDataNasc = new DateTimePicker();
            this.dtpDataNasc.Location = new Point(30, 170);
            this.dtpDataNasc.Size = new Size(250, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(30, 250);
            this.txtTelefone.Size = new Size(250, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(30, 310);
            this.txtEmail.Size = new Size(250, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(30, 370);
            this.txtSenha.Size = new Size(250, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(60, 420);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(170, 420);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}