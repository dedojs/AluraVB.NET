Public Class Frm_CadastrarConta

    Dim contasCorrentes As New List(Of ContaCorrente)
    Dim FormContas As New Frm_ListaContas
    Dim listContas As String
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cadastrar Conta"

    End Sub

    Private Sub Btm_SalvarConta_Click(sender As Object, e As EventArgs) Handles Btm_SalvarConta.Click

        Dim novaConta As New ContaCorrente
        novaConta.Titular = Txt_Ttular.Text
        novaConta.Agencia = Val(Txt_Agencia.Text)
        novaConta.Conta = Val(Txt_Conta.Text)
        novaConta.Saldo = Val(Txt_Saldo.Text)

        contasCorrentes.Add(novaConta)

        MsgBox("Nova Conta de: " + novaConta.Titular + " criada com sucesso!")

        Txt_Agencia.Text = ""
        Txt_Ttular.Text = ""
        Txt_Conta.Text = ""
        Txt_Saldo.Text = ""


    End Sub

    Private Sub Btm_ListarContas_Click(sender As Object, e As EventArgs) Handles Btm_ListarContas.Click

        FormContas.Txt_ListContas.Text = ""
        listContas = ""

        For Each conta As ContaCorrente In contasCorrentes
            listContas = listContas + $"Titular: {conta.Titular} agência: {conta.Agencia}, conta: {conta.Conta} saldo: {conta.Saldo}" + vbCrLf
        Next

        FormContas.Txt_ListContas.Text = listContas
        FormContas.ShowDialog()

    End Sub

    Private Sub Btm_Sacar_Click(sender As Object, e As EventArgs) Handles Btm_Sacar.Click
        Dim agencia As String = Txt_AgenciaSaque.Text
        Dim conta As Integer = Val(Txt_ContaSaque.Text)
        Dim valor As Double = Val(Txt_ValorSaque.Text)
        Dim mensagem As String

        Dim contaSaque As ContaCorrente = contasCorrentes.FirstOrDefault(Function(x) x.Agencia = agencia And x.Conta = conta)

        If String.IsNullOrWhiteSpace(agencia) Or String.IsNullOrWhiteSpace(conta) Then
            MsgBox("Informe Agência e conta", MsgBoxStyle.Critical)
        Else
            If contaSaque Is Nothing Then
                MsgBox("Conta não localizada", MsgBoxStyle.Critical)
            Else
                contaSaque.Sacar(valor)
                mensagem = "Saque efetuado com Sucesso!"
                Txt_SaldoSaque.Text = contaSaque.Saldo
                Lbl_MensagemSaque.Text = mensagem
                Lbl_MensagemSaque.ForeColor = Color.Red
            End If
        End If

        Txt_AgenciaSaque.Text = ""
        Txt_ContaSaque.Text = ""
        Txt_ValorSaque.Text = ""

    End Sub

    Private Sub Btm_Depositar_Click(sender As Object, e As EventArgs) Handles Btm_Depositar.Click
        Dim agencia As String = Txt_AgenciaDeposito.Text
        Dim conta As Integer = Val(Txt_ContaDeposito.Text)
        Dim valor As Double = Val(Txt_ValorDeposito.Text)
        Dim mensagem As String

        Dim contaDeposito As ContaCorrente = contasCorrentes.FirstOrDefault(Function(x) x.Agencia = agencia And x.Conta = conta)

        If String.IsNullOrWhiteSpace(agencia) Or String.IsNullOrWhiteSpace(conta) Then
            MsgBox("Informe Agência e conta", MsgBoxStyle.Critical)
        Else
            If contaDeposito Is Nothing Then
                MsgBox("Conta não localizada", MsgBoxStyle.Critical)
            Else
                contaDeposito.Depositar(valor)
                mensagem = "Deposito efetuado com Sucesso!"
                Txt_SaldoDeposito.Text = contaDeposito.Saldo
                Lbl_MensagemDeposito.Text = mensagem
                Lbl_MensagemDeposito.ForeColor = Color.Green
            End If
        End If

        Txt_AgenciaDeposito.Text = ""
        Txt_ContaDeposito.Text = ""
        Txt_ValorDeposito.Text = ""
    End Sub

    Private Sub Btm_Extrato_Click(sender As Object, e As EventArgs) Handles Btm_Extrato.Click
        Dim agencia As String = Txt_agenciaExtrato.Text
        Dim conta As Integer = Val(Txt_contaExtrato.Text)
        Dim extrato As String = ""
        Dim contaExtrato As ContaCorrente = contasCorrentes.FirstOrDefault(Function(x) x.Agencia = agencia And x.Conta = conta)

        If String.IsNullOrWhiteSpace(agencia) Or String.IsNullOrWhiteSpace(conta) Then
            MsgBox("Informe Agência e conta", MsgBoxStyle.Critical)
        Else
            If contaExtrato Is Nothing Then
                MsgBox("Conta não localizada", MsgBoxStyle.Critical)
            Else
                extrato = contaExtrato.Extrato
            End If
        End If

        Txt_agenciaExtrato.Text = ""
        Txt_contaExtrato.Text = ""
        Txt_Extrato.Text = extrato

    End Sub

    Private Sub Btm_Transferencia_Click(sender As Object, e As EventArgs) Handles Btm_Transferencia.Click
        Dim agRemetente As Integer = Val(Txt_AgRemetente.Text)
        Dim contaRemetente As Integer = Val(Txt_ContaRemetente.Text)
        Dim valorRemetente As Double = Val(Txt_VlRemetente.Text)
        Dim titularRemetente As String = Txt_TiRemetente.Text

        Dim agDestino As Integer = Val(Txt_AgDestino.Text)
        Dim contaDestino As Integer = Val(Txt_ContaDestino.Text)
        Dim titularDestino As String = Txt_TitularDestino.Text

        Dim contaCorrenteDestino As ContaCorrente = contasCorrentes.FirstOrDefault(Function(x) x.Agencia = agDestino And x.Conta = contaDestino)
        Dim remetente As ContaCorrente = contasCorrentes.FirstOrDefault(Function(x) x.Agencia = agRemetente And x.Conta = contaRemetente)


        If contaCorrenteDestino Is Nothing Or remetente Is Nothing Then
            MsgBox("Conta de destino não localizada", MsgBoxStyle.Critical)
        Else
            remetente.Transferir(valorRemetente, contaCorrenteDestino)
            MsgBox("Trãnsferência feita com sucesso!")
        End If

    End Sub

End Class