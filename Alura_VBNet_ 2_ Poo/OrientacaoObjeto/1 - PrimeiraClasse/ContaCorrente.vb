Public Class ContaCorrente

    Public Titular As String
    Public Agencia As Integer
    Public Conta As Integer
    Public Saldo As Double
    Public Extrato As String = ""

    Public Function Sacar(valorSacar As Double) As Boolean
        Dim Retorno As Boolean

        If valorSacar <= Saldo Then
            Retorno = True
            Saldo -= valorSacar
            Extrato += $"{Now.ToString} - Saque de R$ {valorSacar} - Saldo: {Saldo}" + vbCrLf
        Else
            Retorno = False
        End If

        Return Retorno

    End Function

    Public Sub Depositar(valorSacar As Double)
        Saldo += valorSacar
        Extrato += $"{Now.ToString} - Depósito de R$ {valorSacar} - Saldo: {Saldo}" + vbCrLf
    End Sub

    Public Function Transferir(valor As Double, contaDestino As ContaCorrente) As Boolean
        If valor <= Saldo Then
            Sacar(valor)
            contaDestino.Depositar(valor)
            Return True
        Else
            Return False
        End If
    End Function

End Class
