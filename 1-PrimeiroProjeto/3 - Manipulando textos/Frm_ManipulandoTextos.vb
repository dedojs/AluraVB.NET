Public Class Frm_ManipulandoTextos
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "3 - Frm_ManipulandoTextos"
        Btm_BotaoPrincipal.Text = "Clique aqui"
        Me.Text = "3 - Manipulando textos"


    End Sub

    Private Sub Frm_ManipulandoTextos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Red
    End Sub

    Private Sub Btm_BotaoPrincipal_Click(sender As Object, e As EventArgs) Handles Btm_BotaoPrincipal.Click
        Me.Text = "Clicou aqui"
    End Sub


End Class
