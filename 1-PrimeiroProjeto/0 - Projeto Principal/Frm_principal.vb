Imports _1_PrimeiroProjeto
Imports _2___Criando_Variáveis
Imports _4___Manipulando_Textos
Imports _5___Controle_de_fluxo
Imports _6___Laços_de_Repetição

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Projeto Principal"
        Lbl_Principal.Text = "VB.NET com Windows Forms parte 1"
        Btm_1.Text = "1 - Primeiro projeto"
        Btm_2.Text = "2 - Criando Variáveis"
        Btm_3.Text = "3 - Manipulando Textos"
        Btm_4.Text = "4 - Controles de fluxo"
        Btm_5.Text = "5 - Laços de repetição"

    End Sub

    Private Sub Btm_1_Click(sender As Object, e As EventArgs) Handles Btm_1.Click

        Dim f As New Frm_TelaPrincipal
        f.ShowDialog()

    End Sub

    Private Sub Btm_2_Click(sender As Object, e As EventArgs) Handles Btm_2.Click
        Dim f As New Frm_CriandoVariaveis
        f.ShowDialog()
    End Sub

    Private Sub Btm_3_Click(sender As Object, e As EventArgs) Handles Btm_3.Click
        Dim f As New Frm_ManipulandoTextos
        f.ShowDialog()
    End Sub

    Private Sub Btm_4_Click(sender As Object, e As EventArgs) Handles Btm_4.Click
        Dim f As New Frm_ControleFluxo
        f.ShowDialog()
    End Sub

    Private Sub Btm_5_Click(sender As Object, e As EventArgs) Handles Btm_5.Click
        Dim f As New Frm_LacosRepeticao
        f.ShowDialog()
    End Sub
End Class
