Public Class Frm_LacosRepeticao
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "6 - Laçoes de Repetição"
        Lbl_Principal.Text = "Valor Investido"
        Lbl_Rendimento.Text = "Juros %"
        Btm_Principal.Text = "Calcular Valor While"
        Lbl_Periodo.Text = "Períodos"
        Btm_For.Text = "Calcular Valor For"
        Btm_reset.Text = "Limpar extrato"
        Grp_Grupo1.Text = "Cálculo do investimento"
        Grp_Grupo2.Text = "Cálculo investimento anual"

        Lbl_Principal2.Text = "Valor investido"
        Lbl_Rendimento2.Text = "Juros mensais %"
        Lbl_Anos.Text = "Anos aplicados"
        Lbl_AcrescimoRendimento.Text = "Acrescimo juros %"
        Btm_Calcula2.Text = "Efetua cálculo"
        Lbl_Resgate.Text = "Valor de resgate"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodo As Integer = Val(Txt_Periodo.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodo
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento no mês " + contador.ToString + " é " + investimento.ToString("0.00") + vbCrLf
            contador += 1
        End While

        Txt_Extrato.Text = extrato
        MsgBox("O valor final é " + investimento.ToString("0.00"))

    End Sub

    Private Sub Btm_For_Click(sender As Object, e As EventArgs) Handles Btm_For.Click

        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodo As Integer = Val(Txt_Periodo.Text)
        Dim extrato As String = ""

        For i As Integer = 1 To periodo
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento no mês " + i.ToString + " é " + investimento.ToString("0.00") + vbCrLf
        Next

        Txt_Extrato.Text = extrato
        MsgBox("O valor final é " + investimento.ToString("0.00"))

    End Sub

    Private Sub Btm_reset_Click(sender As Object, e As EventArgs) Handles Btm_reset.Click

        Txt_Extrato.Text = " "
        Txt_Periodo.Text = " "
        Txt_Principal.Text = " "
        Txt_Rendimento.Text = " "

    End Sub

    Private Sub Btm_Calcula2_Click(sender As Object, e As EventArgs) Handles Btm_Calcula2.Click

        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Rendimento2.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimo As Double = Val(Txt_AcrescimoRendimento.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim resgate As Integer = Val(Txt_Resgate.Text)
        Dim limite As Boolean = False

        For i As Integer = 1 To anos

            For j As Integer = 1 To 12

                investimento = (investimento + (investimento * (rendimento / 100)))
                extrato += "O saldo do investimento no mês " + contador.ToString + " é " + investimento.ToString("0.00") + " com taxa de: " _
                    + rendimento.ToString + " % ao mês " + vbCrLf
                contador += 1

                If investimento >= resgate Then
                    extrato += "O investimento chegou no limite" + vbCrLf
                    limite = True
                    Exit For
                End If

            Next

            If limite Then
                Exit For
            End If

            rendimento = (rendimento + (rendimento * (acrescimo / 100)))

        Next

        Txt_extrato2.Text = extrato

    End Sub


End Class
