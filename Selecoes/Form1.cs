using System.ComponentModel;

namespace Selecoes;

public partial class Form1 : Form
{
    private List<string> listaCidades = 
    ["Vitória", "Vila Velha", "Serra", "Cariacica",
        "Viana", "Guarapari", "Fundão"];

    private BindingList<Cadastro> ListaCadastros = new BindingList<Cadastro>(BD.RecuperarCadastros());
    
    public Form1()
    {
        InitializeComponent();
        cmbCidades.DataSource = listaCidades;
        dgvCadastro.DataSource = ListaCadastros;
    }

    private void chkTermosPoliticas_CheckedChanged(object sender, EventArgs e)
    {
        btnCadastrar.Enabled = chkTermosPoliticas.Checked;
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (!chkMatutino.Checked && !chkVespertino.Checked && !chkNoturno.Checked)
        {
            MessageBox.Show("Você precisa selecionar algum turno!", "Turnos não selecionados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!chkTermosPoliticas.Checked)
        {
            MessageBox.Show("Aceite os Termos e Políticas para continuar!", "Termos e Políticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var novoCadastro = new Cadastro();
        novoCadastro.Cidade = cmbCidades.Text;
        if (chkMatutino.Checked) novoCadastro.Turnos.Add("Matutino");
        if (chkVespertino.Checked) novoCadastro.Turnos.Add("Vespertino");
        if (chkVespertino.Checked) novoCadastro.Turnos.Add("Noturno");
        novoCadastro.DataTermoAceito = DateTime.Now;
        ListaCadastros.Add(novoCadastro);
        BD.InserirCadastro(novoCadastro);
    }
}
