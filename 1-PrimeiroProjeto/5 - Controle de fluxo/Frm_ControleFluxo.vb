Public Class Frm_ControleFluxo
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "5 - Controle de Fluxo"
        Lbl_Title.Text = "5 - Controle de fluxo"
        Btm_Checagem.Text = "Verificar"
        Lbl_Resultado.Text = ""
        Chk_Acompanhada.Text = "Esta acompanhada dos pais?"

    End Sub

    Private Sub Frm_ControleFluxo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btm_Checagem.Click

        Dim idade As Integer = Txt_Idade.Text
        Lbl_Resultado.Text = ""
        Dim acompanhado As Boolean = Chk_Acompanhada.Checked

        If (idade >= 18) Or (acompanhado And idade >= 16) Then
            Lbl_Resultado.Text = "Pode entrar"

        Else

            Lbl_Resultado.Text = "Não pode entrar"

        End If

    End Sub
End Class
