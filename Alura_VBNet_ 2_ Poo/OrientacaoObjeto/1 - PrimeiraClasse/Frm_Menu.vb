Public Class Frm_Menu

    Dim FormContas As New Frm_ListaContas
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Banco Movere - Menu"


    End Sub

    Private Sub Btm_NovaConta_Click(sender As Object, e As EventArgs) Handles Btm_NovaConta.Click

        Dim cadastrarConta As New Frm_CadastrarConta
        cadastrarConta.ShowDialog()

    End Sub

    Private Sub Btm_VerificarContas_Click(sender As Object, e As EventArgs) Handles Btm_VerificarContas.Click
        FormContas.ShowDialog()
    End Sub

End Class
