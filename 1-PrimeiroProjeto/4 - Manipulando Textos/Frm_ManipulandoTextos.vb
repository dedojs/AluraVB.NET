Public Class Frm_ManipulandoTextos

    Dim ListaCursos As String
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "4 - Manipulando Textos"
        Btm_BotaoPrincipal.Text = "Botão 4"
        Me.Text = "4 Projeto - Mnipulando textos"
        Btm_Char.Text = "Clique para descobrir"
        Lbl_Curso.Text = "Digite o seu curso favorito!"
        Btm_Adicionar.Text = "Adicione a sua lista"

    End Sub

    Private Sub Frm_ManipulandoTextos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btm_BotaoPrincipal_Click(sender As Object, e As EventArgs) Handles Btm_BotaoPrincipal.Click

        Dim PrimeiraLetra As Char = "a"
        MsgBox("O caracter da variável primeira letra é: " + PrimeiraLetra)

        Dim SegundaLetra As Char = Chr(65)
        MsgBox("O caracter da variável segunda letra é: " + SegundaLetra)

    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim ValorChar As Integer = Val(Txt_NumChar.Text)
        Dim QuintaLetra As Char = Chr(ValorChar)
        MsgBox("O caracter referente ao numero acima é: " + QuintaLetra)

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim CursoDigitado As String = Txt_Curso.Text
        ListaCursos = ListaCursos + CursoDigitado + vbCrLf
        Txt_List.Text = ListaCursos
        Txt_Curso.Text = ""

    End Sub
End Class
