namespace Selecoes;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		lblTitulo = new Label();
		lblCidade = new Label();
		cmbCidades = new ComboBox();
		lblTurno = new Label();
		chkMatutino = new CheckBox();
		chkVespertino = new CheckBox();
		chkNoturno = new CheckBox();
		lblTermosPoliticas = new Label();
		btnCadastrar = new Button();
		chkTermosPoliticas = new CheckBox();
		dgvCadastro = new DataGridView();
		((System.ComponentModel.ISupportInitialize)dgvCadastro).BeginInit();
		SuspendLayout();
		// 
		// lblTitulo
		// 
		lblTitulo.AutoSize = true;
		lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitulo.Location = new Point(12, 9);
		lblTitulo.Name = "lblTitulo";
		lblTitulo.Size = new Size(99, 30);
		lblTitulo.TabIndex = 0;
		lblTitulo.Text = "Cadastro";
		// 
		// lblCidade
		// 
		lblCidade.AutoSize = true;
		lblCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblCidade.Location = new Point(12, 47);
		lblCidade.Name = "lblCidade";
		lblCidade.Size = new Size(91, 21);
		lblCidade.TabIndex = 1;
		lblCidade.Text = "Sua Cidade:";
		// 
		// cmbCidades
		// 
		cmbCidades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cmbCidades.FormattingEnabled = true;
		cmbCidades.Location = new Point(12, 79);
		cmbCidades.Name = "cmbCidades";
		cmbCidades.Size = new Size(160, 29);
		cmbCidades.TabIndex = 2;
		// 
		// lblTurno
		// 
		lblTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblTurno.Location = new Point(12, 119);
		lblTurno.Name = "lblTurno";
		lblTurno.Size = new Size(100, 23);
		lblTurno.TabIndex = 3;
		lblTurno.Text = "Turno:";
		// 
		// chkMatutino
		// 
		chkMatutino.AutoSize = true;
		chkMatutino.Location = new Point(12, 147);
		chkMatutino.Name = "chkMatutino";
		chkMatutino.Size = new Size(75, 19);
		chkMatutino.TabIndex = 4;
		chkMatutino.Text = "Matutino";
		chkMatutino.UseVisualStyleBackColor = true;
		// 
		// chkVespertino
		// 
		chkVespertino.AutoSize = true;
		chkVespertino.Location = new Point(12, 177);
		chkVespertino.Name = "chkVespertino";
		chkVespertino.Size = new Size(81, 19);
		chkVespertino.TabIndex = 5;
		chkVespertino.Text = "Vespertino";
		chkVespertino.UseVisualStyleBackColor = true;
		// 
		// chkNoturno
		// 
		chkNoturno.AutoSize = true;
		chkNoturno.Location = new Point(12, 207);
		chkNoturno.Name = "chkNoturno";
		chkNoturno.Size = new Size(71, 19);
		chkNoturno.TabIndex = 6;
		chkNoturno.Text = "Noturno";
		chkNoturno.UseVisualStyleBackColor = true;
		// 
		// lblTermosPoliticas
		// 
		lblTermosPoliticas.AutoSize = true;
		lblTermosPoliticas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblTermosPoliticas.Location = new Point(12, 242);
		lblTermosPoliticas.Name = "lblTermosPoliticas";
		lblTermosPoliticas.Size = new Size(132, 21);
		lblTermosPoliticas.TabIndex = 7;
		lblTermosPoliticas.Text = "Termos e Políticas";
		// 
		// btnCadastrar
		// 
		btnCadastrar.AutoSize = true;
		btnCadastrar.Enabled = false;
		btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCadastrar.Location = new Point(12, 315);
		btnCadastrar.Name = "btnCadastrar";
		btnCadastrar.Size = new Size(92, 31);
		btnCadastrar.TabIndex = 8;
		btnCadastrar.Text = "Cadastrar";
		btnCadastrar.UseVisualStyleBackColor = true;
		btnCadastrar.Click += btnCadastrar_Click;
		// 
		// chkTermosPoliticas
		// 
		chkTermosPoliticas.AutoSize = true;
		chkTermosPoliticas.Location = new Point(12, 274);
		chkTermosPoliticas.Name = "chkTermosPoliticas";
		chkTermosPoliticas.Size = new Size(278, 19);
		chkTermosPoliticas.TabIndex = 9;
		chkTermosPoliticas.Text = "Aceito todos os Termos e Políticas do programa";
		chkTermosPoliticas.UseVisualStyleBackColor = true;
		chkTermosPoliticas.CheckedChanged += chkTermosPoliticas_CheckedChanged;
		// 
		// dgvCadastro
		// 
		dgvCadastro.AllowUserToAddRows = false;
		dgvCadastro.AllowUserToDeleteRows = false;
		dgvCadastro.AllowUserToOrderColumns = true;
		dgvCadastro.AllowUserToResizeColumns = false;
		dgvCadastro.AllowUserToResizeRows = false;
		dgvCadastro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvCadastro.Enabled = false;
		dgvCadastro.Location = new Point(376, 12);
		dgvCadastro.Name = "dgvCadastro";
		dgvCadastro.Size = new Size(412, 426);
		dgvCadastro.TabIndex = 10;
		dgvCadastro.Text = "dataGridView1";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(dgvCadastro);
		Controls.Add(chkTermosPoliticas);
		Controls.Add(btnCadastrar);
		Controls.Add(lblTermosPoliticas);
		Controls.Add(chkNoturno);
		Controls.Add(chkVespertino);
		Controls.Add(chkMatutino);
		Controls.Add(lblTurno);
		Controls.Add(cmbCidades);
		Controls.Add(lblCidade);
		Controls.Add(lblTitulo);
		Name = "Form1";
		Text = "Form1";
		((System.ComponentModel.ISupportInitialize)dgvCadastro).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	private System.Windows.Forms.DataGridView dgvCadastro;

    private System.Windows.Forms.CheckBox chkTermosPoliticas;

    private System.Windows.Forms.Button btnCadastrar;

    private System.Windows.Forms.CheckBox chkMatutino;
    private System.Windows.Forms.CheckBox chkVespertino;
    private System.Windows.Forms.CheckBox chkNoturno;
    private System.Windows.Forms.Label lblTermosPoliticas;

    private System.Windows.Forms.Label lblTurno;

    private System.Windows.Forms.ComboBox cmbCidades;

    private System.Windows.Forms.Label lblCidade;

    private System.Windows.Forms.Label lblTitulo;

    #endregion
}