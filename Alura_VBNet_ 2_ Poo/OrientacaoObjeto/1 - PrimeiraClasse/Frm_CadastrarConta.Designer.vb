<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastrarConta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Titular = New System.Windows.Forms.Label()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Lbl_Conta = New System.Windows.Forms.Label()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Txt_Ttular = New System.Windows.Forms.TextBox()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Btm_SalvarConta = New System.Windows.Forms.Button()
        Me.Btm_ListarContas = New System.Windows.Forms.Button()
        Me.Grp_Cadastrar = New System.Windows.Forms.GroupBox()
        Me.Grp_Sacar = New System.Windows.Forms.GroupBox()
        Me.Lbl_MensagemSaque = New System.Windows.Forms.Label()
        Me.Txt_SaldoSaque = New System.Windows.Forms.TextBox()
        Me.Lbl_SaldoSaque = New System.Windows.Forms.Label()
        Me.Btm_Sacar = New System.Windows.Forms.Button()
        Me.Lbl_AgenciaSaque = New System.Windows.Forms.Label()
        Me.Txt_ValorSaque = New System.Windows.Forms.TextBox()
        Me.Lbl_ContaSaque = New System.Windows.Forms.Label()
        Me.Txt_ContaSaque = New System.Windows.Forms.TextBox()
        Me.Lbl_ValorSaque = New System.Windows.Forms.Label()
        Me.Txt_AgenciaSaque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grp_Deposito = New System.Windows.Forms.GroupBox()
        Me.Lbl_MensagemDeposito = New System.Windows.Forms.Label()
        Me.Txt_SaldoDeposito = New System.Windows.Forms.TextBox()
        Me.Lbl_SaldoDeposito = New System.Windows.Forms.Label()
        Me.Btm_Depositar = New System.Windows.Forms.Button()
        Me.Lbl_AgenciaDeposito = New System.Windows.Forms.Label()
        Me.Txt_ValorDeposito = New System.Windows.Forms.TextBox()
        Me.Lbl_ContaDeposito = New System.Windows.Forms.Label()
        Me.Txt_ContaDeposito = New System.Windows.Forms.TextBox()
        Me.Lbl_ValorDeposito = New System.Windows.Forms.Label()
        Me.Txt_AgenciaDeposito = New System.Windows.Forms.TextBox()
        Me.Lbl_DepositarValores = New System.Windows.Forms.Label()
        Me.Grp_Extrato = New System.Windows.Forms.GroupBox()
        Me.Txt_Extrato = New System.Windows.Forms.TextBox()
        Me.Btm_Extrato = New System.Windows.Forms.Button()
        Me.Lbl_agenciaExtrato = New System.Windows.Forms.Label()
        Me.Lbl_contaExtrato = New System.Windows.Forms.Label()
        Me.Txt_contaExtrato = New System.Windows.Forms.TextBox()
        Me.Txt_agenciaExtrato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Grp_Transferencia = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_ContaDestino = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_ContaRemetente = New System.Windows.Forms.TextBox()
        Me.Txt_TitularDestino = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_TiRemetente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btm_Transferencia = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_AgDestino = New System.Windows.Forms.TextBox()
        Me.Txt_VlRemetente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_TransferenciaRemetente = New System.Windows.Forms.Label()
        Me.Txt_AgRemetente = New System.Windows.Forms.TextBox()
        Me.Grp_Cadastrar.SuspendLayout()
        Me.Grp_Sacar.SuspendLayout()
        Me.Grp_Deposito.SuspendLayout()
        Me.Grp_Extrato.SuspendLayout()
        Me.Grp_Transferencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Titular
        '
        Me.Lbl_Titular.AutoSize = True
        Me.Lbl_Titular.Location = New System.Drawing.Point(42, 109)
        Me.Lbl_Titular.Name = "Lbl_Titular"
        Me.Lbl_Titular.Size = New System.Drawing.Size(47, 16)
        Me.Lbl_Titular.TabIndex = 0
        Me.Lbl_Titular.Text = "Titular:"
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Location = New System.Drawing.Point(42, 174)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_Agencia.TabIndex = 1
        Me.Lbl_Agencia.Text = "Agência:"
        '
        'Lbl_Conta
        '
        Me.Lbl_Conta.AutoSize = True
        Me.Lbl_Conta.Location = New System.Drawing.Point(39, 241)
        Me.Lbl_Conta.Name = "Lbl_Conta"
        Me.Lbl_Conta.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_Conta.TabIndex = 2
        Me.Lbl_Conta.Text = "Conta:"
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(42, 313)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(43, 16)
        Me.Lbl_Saldo.TabIndex = 3
        Me.Lbl_Saldo.Text = "Saldo"
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(69, 22)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(201, 29)
        Me.Lbl_Titulo.TabIndex = 4
        Me.Lbl_Titulo.Text = "Cadastrar Conta"
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(45, 193)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(248, 22)
        Me.Txt_Agencia.TabIndex = 5
        '
        'Txt_Ttular
        '
        Me.Txt_Ttular.Location = New System.Drawing.Point(45, 131)
        Me.Txt_Ttular.Name = "Txt_Ttular"
        Me.Txt_Ttular.Size = New System.Drawing.Size(248, 22)
        Me.Txt_Ttular.TabIndex = 6
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(42, 260)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(248, 22)
        Me.Txt_Conta.TabIndex = 7
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(42, 332)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(248, 22)
        Me.Txt_Saldo.TabIndex = 8
        '
        'Btm_SalvarConta
        '
        Me.Btm_SalvarConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_SalvarConta.Location = New System.Drawing.Point(74, 380)
        Me.Btm_SalvarConta.Name = "Btm_SalvarConta"
        Me.Btm_SalvarConta.Size = New System.Drawing.Size(149, 50)
        Me.Btm_SalvarConta.TabIndex = 9
        Me.Btm_SalvarConta.Text = "Salvar"
        Me.Btm_SalvarConta.UseVisualStyleBackColor = True
        '
        'Btm_ListarContas
        '
        Me.Btm_ListarContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_ListarContas.Location = New System.Drawing.Point(74, 449)
        Me.Btm_ListarContas.Name = "Btm_ListarContas"
        Me.Btm_ListarContas.Size = New System.Drawing.Size(149, 50)
        Me.Btm_ListarContas.TabIndex = 10
        Me.Btm_ListarContas.Text = "Listar Contas"
        Me.Btm_ListarContas.UseVisualStyleBackColor = True
        '
        'Grp_Cadastrar
        '
        Me.Grp_Cadastrar.Controls.Add(Me.Txt_Ttular)
        Me.Grp_Cadastrar.Controls.Add(Me.Btm_ListarContas)
        Me.Grp_Cadastrar.Controls.Add(Me.Lbl_Titular)
        Me.Grp_Cadastrar.Controls.Add(Me.Btm_SalvarConta)
        Me.Grp_Cadastrar.Controls.Add(Me.Lbl_Agencia)
        Me.Grp_Cadastrar.Controls.Add(Me.Txt_Saldo)
        Me.Grp_Cadastrar.Controls.Add(Me.Lbl_Conta)
        Me.Grp_Cadastrar.Controls.Add(Me.Txt_Conta)
        Me.Grp_Cadastrar.Controls.Add(Me.Lbl_Saldo)
        Me.Grp_Cadastrar.Controls.Add(Me.Lbl_Titulo)
        Me.Grp_Cadastrar.Controls.Add(Me.Txt_Agencia)
        Me.Grp_Cadastrar.Location = New System.Drawing.Point(24, 23)
        Me.Grp_Cadastrar.Name = "Grp_Cadastrar"
        Me.Grp_Cadastrar.Size = New System.Drawing.Size(330, 518)
        Me.Grp_Cadastrar.TabIndex = 12
        Me.Grp_Cadastrar.TabStop = False
        Me.Grp_Cadastrar.Text = "Cadastrar Conta"
        '
        'Grp_Sacar
        '
        Me.Grp_Sacar.Controls.Add(Me.Lbl_MensagemSaque)
        Me.Grp_Sacar.Controls.Add(Me.Txt_SaldoSaque)
        Me.Grp_Sacar.Controls.Add(Me.Lbl_SaldoSaque)
        Me.Grp_Sacar.Controls.Add(Me.Btm_Sacar)
        Me.Grp_Sacar.Controls.Add(Me.Lbl_AgenciaSaque)
        Me.Grp_Sacar.Controls.Add(Me.Txt_ValorSaque)
        Me.Grp_Sacar.Controls.Add(Me.Lbl_ContaSaque)
        Me.Grp_Sacar.Controls.Add(Me.Txt_ContaSaque)
        Me.Grp_Sacar.Controls.Add(Me.Lbl_ValorSaque)
        Me.Grp_Sacar.Controls.Add(Me.Txt_AgenciaSaque)
        Me.Grp_Sacar.Controls.Add(Me.Label1)
        Me.Grp_Sacar.Location = New System.Drawing.Point(385, 23)
        Me.Grp_Sacar.Name = "Grp_Sacar"
        Me.Grp_Sacar.Size = New System.Drawing.Size(343, 518)
        Me.Grp_Sacar.TabIndex = 13
        Me.Grp_Sacar.TabStop = False
        Me.Grp_Sacar.Text = "Sacar Valor"
        '
        'Lbl_MensagemSaque
        '
        Me.Lbl_MensagemSaque.AutoSize = True
        Me.Lbl_MensagemSaque.Location = New System.Drawing.Point(92, 449)
        Me.Lbl_MensagemSaque.Name = "Lbl_MensagemSaque"
        Me.Lbl_MensagemSaque.Size = New System.Drawing.Size(126, 16)
        Me.Lbl_MensagemSaque.TabIndex = 23
        Me.Lbl_MensagemSaque.Text = "Verificando Saldo ..."
        '
        'Txt_SaldoSaque
        '
        Me.Txt_SaldoSaque.Location = New System.Drawing.Point(37, 408)
        Me.Txt_SaldoSaque.Name = "Txt_SaldoSaque"
        Me.Txt_SaldoSaque.ReadOnly = True
        Me.Txt_SaldoSaque.Size = New System.Drawing.Size(248, 22)
        Me.Txt_SaldoSaque.TabIndex = 22
        '
        'Lbl_SaldoSaque
        '
        Me.Lbl_SaldoSaque.AutoSize = True
        Me.Lbl_SaldoSaque.Location = New System.Drawing.Point(36, 380)
        Me.Lbl_SaldoSaque.Name = "Lbl_SaldoSaque"
        Me.Lbl_SaldoSaque.Size = New System.Drawing.Size(43, 16)
        Me.Lbl_SaldoSaque.TabIndex = 21
        Me.Lbl_SaldoSaque.Text = "Saldo"
        '
        'Btm_Sacar
        '
        Me.Btm_Sacar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Sacar.Location = New System.Drawing.Point(69, 313)
        Me.Btm_Sacar.Name = "Btm_Sacar"
        Me.Btm_Sacar.Size = New System.Drawing.Size(149, 50)
        Me.Btm_Sacar.TabIndex = 20
        Me.Btm_Sacar.Text = "Sacar"
        Me.Btm_Sacar.UseVisualStyleBackColor = True
        '
        'Lbl_AgenciaSaque
        '
        Me.Lbl_AgenciaSaque.AutoSize = True
        Me.Lbl_AgenciaSaque.Location = New System.Drawing.Point(37, 98)
        Me.Lbl_AgenciaSaque.Name = "Lbl_AgenciaSaque"
        Me.Lbl_AgenciaSaque.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_AgenciaSaque.TabIndex = 13
        Me.Lbl_AgenciaSaque.Text = "Agência:"
        '
        'Txt_ValorSaque
        '
        Me.Txt_ValorSaque.Location = New System.Drawing.Point(37, 256)
        Me.Txt_ValorSaque.Name = "Txt_ValorSaque"
        Me.Txt_ValorSaque.Size = New System.Drawing.Size(248, 22)
        Me.Txt_ValorSaque.TabIndex = 19
        '
        'Lbl_ContaSaque
        '
        Me.Lbl_ContaSaque.AutoSize = True
        Me.Lbl_ContaSaque.Location = New System.Drawing.Point(34, 165)
        Me.Lbl_ContaSaque.Name = "Lbl_ContaSaque"
        Me.Lbl_ContaSaque.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_ContaSaque.TabIndex = 14
        Me.Lbl_ContaSaque.Text = "Conta:"
        '
        'Txt_ContaSaque
        '
        Me.Txt_ContaSaque.Location = New System.Drawing.Point(37, 184)
        Me.Txt_ContaSaque.Name = "Txt_ContaSaque"
        Me.Txt_ContaSaque.Size = New System.Drawing.Size(248, 22)
        Me.Txt_ContaSaque.TabIndex = 18
        '
        'Lbl_ValorSaque
        '
        Me.Lbl_ValorSaque.AutoSize = True
        Me.Lbl_ValorSaque.Location = New System.Drawing.Point(37, 237)
        Me.Lbl_ValorSaque.Name = "Lbl_ValorSaque"
        Me.Lbl_ValorSaque.Size = New System.Drawing.Size(42, 16)
        Me.Lbl_ValorSaque.TabIndex = 15
        Me.Lbl_ValorSaque.Text = "Valor "
        '
        'Txt_AgenciaSaque
        '
        Me.Txt_AgenciaSaque.Location = New System.Drawing.Point(40, 117)
        Me.Txt_AgenciaSaque.Name = "Txt_AgenciaSaque"
        Me.Txt_AgenciaSaque.Size = New System.Drawing.Size(248, 22)
        Me.Txt_AgenciaSaque.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sacar Valores"
        '
        'Grp_Deposito
        '
        Me.Grp_Deposito.Controls.Add(Me.Lbl_MensagemDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Txt_SaldoDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Lbl_SaldoDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Btm_Depositar)
        Me.Grp_Deposito.Controls.Add(Me.Lbl_AgenciaDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Txt_ValorDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Lbl_ContaDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Txt_ContaDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Lbl_ValorDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Txt_AgenciaDeposito)
        Me.Grp_Deposito.Controls.Add(Me.Lbl_DepositarValores)
        Me.Grp_Deposito.Location = New System.Drawing.Point(755, 23)
        Me.Grp_Deposito.Name = "Grp_Deposito"
        Me.Grp_Deposito.Size = New System.Drawing.Size(343, 518)
        Me.Grp_Deposito.TabIndex = 24
        Me.Grp_Deposito.TabStop = False
        Me.Grp_Deposito.Text = "Depósito Valor"
        '
        'Lbl_MensagemDeposito
        '
        Me.Lbl_MensagemDeposito.AutoSize = True
        Me.Lbl_MensagemDeposito.Location = New System.Drawing.Point(92, 449)
        Me.Lbl_MensagemDeposito.Name = "Lbl_MensagemDeposito"
        Me.Lbl_MensagemDeposito.Size = New System.Drawing.Size(126, 16)
        Me.Lbl_MensagemDeposito.TabIndex = 23
        Me.Lbl_MensagemDeposito.Text = "Verificando Saldo ..."
        '
        'Txt_SaldoDeposito
        '
        Me.Txt_SaldoDeposito.Location = New System.Drawing.Point(37, 408)
        Me.Txt_SaldoDeposito.Name = "Txt_SaldoDeposito"
        Me.Txt_SaldoDeposito.ReadOnly = True
        Me.Txt_SaldoDeposito.Size = New System.Drawing.Size(248, 22)
        Me.Txt_SaldoDeposito.TabIndex = 22
        '
        'Lbl_SaldoDeposito
        '
        Me.Lbl_SaldoDeposito.AutoSize = True
        Me.Lbl_SaldoDeposito.Location = New System.Drawing.Point(36, 380)
        Me.Lbl_SaldoDeposito.Name = "Lbl_SaldoDeposito"
        Me.Lbl_SaldoDeposito.Size = New System.Drawing.Size(43, 16)
        Me.Lbl_SaldoDeposito.TabIndex = 21
        Me.Lbl_SaldoDeposito.Text = "Saldo"
        '
        'Btm_Depositar
        '
        Me.Btm_Depositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Depositar.Location = New System.Drawing.Point(69, 313)
        Me.Btm_Depositar.Name = "Btm_Depositar"
        Me.Btm_Depositar.Size = New System.Drawing.Size(149, 50)
        Me.Btm_Depositar.TabIndex = 20
        Me.Btm_Depositar.Text = "Depositar"
        Me.Btm_Depositar.UseVisualStyleBackColor = True
        '
        'Lbl_AgenciaDeposito
        '
        Me.Lbl_AgenciaDeposito.AutoSize = True
        Me.Lbl_AgenciaDeposito.Location = New System.Drawing.Point(37, 98)
        Me.Lbl_AgenciaDeposito.Name = "Lbl_AgenciaDeposito"
        Me.Lbl_AgenciaDeposito.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_AgenciaDeposito.TabIndex = 13
        Me.Lbl_AgenciaDeposito.Text = "Agência:"
        '
        'Txt_ValorDeposito
        '
        Me.Txt_ValorDeposito.Location = New System.Drawing.Point(37, 256)
        Me.Txt_ValorDeposito.Name = "Txt_ValorDeposito"
        Me.Txt_ValorDeposito.Size = New System.Drawing.Size(248, 22)
        Me.Txt_ValorDeposito.TabIndex = 19
        '
        'Lbl_ContaDeposito
        '
        Me.Lbl_ContaDeposito.AutoSize = True
        Me.Lbl_ContaDeposito.Location = New System.Drawing.Point(34, 165)
        Me.Lbl_ContaDeposito.Name = "Lbl_ContaDeposito"
        Me.Lbl_ContaDeposito.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_ContaDeposito.TabIndex = 14
        Me.Lbl_ContaDeposito.Text = "Conta:"
        '
        'Txt_ContaDeposito
        '
        Me.Txt_ContaDeposito.Location = New System.Drawing.Point(37, 184)
        Me.Txt_ContaDeposito.Name = "Txt_ContaDeposito"
        Me.Txt_ContaDeposito.Size = New System.Drawing.Size(248, 22)
        Me.Txt_ContaDeposito.TabIndex = 18
        '
        'Lbl_ValorDeposito
        '
        Me.Lbl_ValorDeposito.AutoSize = True
        Me.Lbl_ValorDeposito.Location = New System.Drawing.Point(37, 237)
        Me.Lbl_ValorDeposito.Name = "Lbl_ValorDeposito"
        Me.Lbl_ValorDeposito.Size = New System.Drawing.Size(42, 16)
        Me.Lbl_ValorDeposito.TabIndex = 15
        Me.Lbl_ValorDeposito.Text = "Valor "
        '
        'Txt_AgenciaDeposito
        '
        Me.Txt_AgenciaDeposito.Location = New System.Drawing.Point(40, 117)
        Me.Txt_AgenciaDeposito.Name = "Txt_AgenciaDeposito"
        Me.Txt_AgenciaDeposito.Size = New System.Drawing.Size(248, 22)
        Me.Txt_AgenciaDeposito.TabIndex = 16
        '
        'Lbl_DepositarValores
        '
        Me.Lbl_DepositarValores.AutoSize = True
        Me.Lbl_DepositarValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DepositarValores.Location = New System.Drawing.Point(64, 22)
        Me.Lbl_DepositarValores.Name = "Lbl_DepositarValores"
        Me.Lbl_DepositarValores.Size = New System.Drawing.Size(222, 29)
        Me.Lbl_DepositarValores.TabIndex = 11
        Me.Lbl_DepositarValores.Text = "Depositar Valores"
        '
        'Grp_Extrato
        '
        Me.Grp_Extrato.Controls.Add(Me.Txt_Extrato)
        Me.Grp_Extrato.Controls.Add(Me.Btm_Extrato)
        Me.Grp_Extrato.Controls.Add(Me.Lbl_agenciaExtrato)
        Me.Grp_Extrato.Controls.Add(Me.Lbl_contaExtrato)
        Me.Grp_Extrato.Controls.Add(Me.Txt_contaExtrato)
        Me.Grp_Extrato.Controls.Add(Me.Txt_agenciaExtrato)
        Me.Grp_Extrato.Controls.Add(Me.Label7)
        Me.Grp_Extrato.Location = New System.Drawing.Point(1125, 23)
        Me.Grp_Extrato.Name = "Grp_Extrato"
        Me.Grp_Extrato.Size = New System.Drawing.Size(343, 518)
        Me.Grp_Extrato.TabIndex = 25
        Me.Grp_Extrato.TabStop = False
        Me.Grp_Extrato.Text = "Extrato"
        '
        'Txt_Extrato
        '
        Me.Txt_Extrato.Location = New System.Drawing.Point(18, 301)
        Me.Txt_Extrato.Multiline = True
        Me.Txt_Extrato.Name = "Txt_Extrato"
        Me.Txt_Extrato.ReadOnly = True
        Me.Txt_Extrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Extrato.Size = New System.Drawing.Size(302, 198)
        Me.Txt_Extrato.TabIndex = 22
        '
        'Btm_Extrato
        '
        Me.Btm_Extrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Extrato.Location = New System.Drawing.Point(86, 232)
        Me.Btm_Extrato.Name = "Btm_Extrato"
        Me.Btm_Extrato.Size = New System.Drawing.Size(149, 50)
        Me.Btm_Extrato.TabIndex = 20
        Me.Btm_Extrato.Text = "Extrato"
        Me.Btm_Extrato.UseVisualStyleBackColor = True
        '
        'Lbl_agenciaExtrato
        '
        Me.Lbl_agenciaExtrato.AutoSize = True
        Me.Lbl_agenciaExtrato.Location = New System.Drawing.Point(37, 98)
        Me.Lbl_agenciaExtrato.Name = "Lbl_agenciaExtrato"
        Me.Lbl_agenciaExtrato.Size = New System.Drawing.Size(60, 16)
        Me.Lbl_agenciaExtrato.TabIndex = 13
        Me.Lbl_agenciaExtrato.Text = "Agência:"
        '
        'Lbl_contaExtrato
        '
        Me.Lbl_contaExtrato.AutoSize = True
        Me.Lbl_contaExtrato.Location = New System.Drawing.Point(34, 165)
        Me.Lbl_contaExtrato.Name = "Lbl_contaExtrato"
        Me.Lbl_contaExtrato.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_contaExtrato.TabIndex = 14
        Me.Lbl_contaExtrato.Text = "Conta:"
        '
        'Txt_contaExtrato
        '
        Me.Txt_contaExtrato.Location = New System.Drawing.Point(37, 184)
        Me.Txt_contaExtrato.Name = "Txt_contaExtrato"
        Me.Txt_contaExtrato.Size = New System.Drawing.Size(248, 22)
        Me.Txt_contaExtrato.TabIndex = 18
        '
        'Txt_agenciaExtrato
        '
        Me.Txt_agenciaExtrato.Location = New System.Drawing.Point(40, 117)
        Me.Txt_agenciaExtrato.Name = "Txt_agenciaExtrato"
        Me.Txt_agenciaExtrato.Size = New System.Drawing.Size(248, 22)
        Me.Txt_agenciaExtrato.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 29)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Extrato da Conta"
        '
        'Grp_Transferencia
        '
        Me.Grp_Transferencia.Controls.Add(Me.Label10)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_ContaDestino)
        Me.Grp_Transferencia.Controls.Add(Me.Label11)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_ContaRemetente)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_TitularDestino)
        Me.Grp_Transferencia.Controls.Add(Me.Label6)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_TiRemetente)
        Me.Grp_Transferencia.Controls.Add(Me.Label2)
        Me.Grp_Transferencia.Controls.Add(Me.Btm_Transferencia)
        Me.Grp_Transferencia.Controls.Add(Me.Label8)
        Me.Grp_Transferencia.Controls.Add(Me.Label9)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_AgDestino)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_VlRemetente)
        Me.Grp_Transferencia.Controls.Add(Me.Label4)
        Me.Grp_Transferencia.Controls.Add(Me.Label3)
        Me.Grp_Transferencia.Controls.Add(Me.Lbl_TransferenciaRemetente)
        Me.Grp_Transferencia.Controls.Add(Me.Txt_AgRemetente)
        Me.Grp_Transferencia.Location = New System.Drawing.Point(24, 557)
        Me.Grp_Transferencia.Name = "Grp_Transferencia"
        Me.Grp_Transferencia.Size = New System.Drawing.Size(849, 214)
        Me.Grp_Transferencia.TabIndex = 13
        Me.Grp_Transferencia.TabStop = False
        Me.Grp_Transferencia.Text = "Transferência entre contas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(491, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Conta:"
        '
        'Txt_ContaDestino
        '
        Me.Txt_ContaDestino.Location = New System.Drawing.Point(494, 90)
        Me.Txt_ContaDestino.Name = "Txt_ContaDestino"
        Me.Txt_ContaDestino.Size = New System.Drawing.Size(85, 22)
        Me.Txt_ContaDestino.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(158, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Conta:"
        '
        'Txt_ContaRemetente
        '
        Me.Txt_ContaRemetente.Location = New System.Drawing.Point(161, 90)
        Me.Txt_ContaRemetente.Name = "Txt_ContaRemetente"
        Me.Txt_ContaRemetente.Size = New System.Drawing.Size(82, 22)
        Me.Txt_ContaRemetente.TabIndex = 36
        '
        'Txt_TitularDestino
        '
        Me.Txt_TitularDestino.Location = New System.Drawing.Point(376, 182)
        Me.Txt_TitularDestino.Name = "Txt_TitularDestino"
        Me.Txt_TitularDestino.ReadOnly = True
        Me.Txt_TitularDestino.Size = New System.Drawing.Size(248, 22)
        Me.Txt_TitularDestino.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(373, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Titular:"
        '
        'Txt_TiRemetente
        '
        Me.Txt_TiRemetente.Location = New System.Drawing.Point(45, 182)
        Me.Txt_TiRemetente.Name = "Txt_TiRemetente"
        Me.Txt_TiRemetente.ReadOnly = True
        Me.Txt_TiRemetente.Size = New System.Drawing.Size(248, 22)
        Me.Txt_TiRemetente.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titular:"
        '
        'Btm_Transferencia
        '
        Me.Btm_Transferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Transferencia.Location = New System.Drawing.Point(661, 112)
        Me.Btm_Transferencia.Name = "Btm_Transferencia"
        Me.Btm_Transferencia.Size = New System.Drawing.Size(149, 50)
        Me.Btm_Transferencia.TabIndex = 11
        Me.Btm_Transferencia.Text = "Transferir"
        Me.Btm_Transferencia.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(370, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Agência:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(228, 29)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Conta Destinatário"
        '
        'Txt_AgDestino
        '
        Me.Txt_AgDestino.Location = New System.Drawing.Point(373, 90)
        Me.Txt_AgDestino.Name = "Txt_AgDestino"
        Me.Txt_AgDestino.Size = New System.Drawing.Size(85, 22)
        Me.Txt_AgDestino.TabIndex = 29
        '
        'Txt_VlRemetente
        '
        Me.Txt_VlRemetente.Location = New System.Drawing.Point(42, 135)
        Me.Txt_VlRemetente.Name = "Txt_VlRemetente"
        Me.Txt_VlRemetente.Size = New System.Drawing.Size(248, 22)
        Me.Txt_VlRemetente.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Valor "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Agência:"
        '
        'Lbl_TransferenciaRemetente
        '
        Me.Lbl_TransferenciaRemetente.AutoSize = True
        Me.Lbl_TransferenciaRemetente.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TransferenciaRemetente.Location = New System.Drawing.Point(61, 29)
        Me.Lbl_TransferenciaRemetente.Name = "Lbl_TransferenciaRemetente"
        Me.Lbl_TransferenciaRemetente.Size = New System.Drawing.Size(215, 29)
        Me.Lbl_TransferenciaRemetente.TabIndex = 4
        Me.Lbl_TransferenciaRemetente.Text = "Conta Remetente"
        '
        'Txt_AgRemetente
        '
        Me.Txt_AgRemetente.Location = New System.Drawing.Point(42, 90)
        Me.Txt_AgRemetente.Name = "Txt_AgRemetente"
        Me.Txt_AgRemetente.Size = New System.Drawing.Size(82, 22)
        Me.Txt_AgRemetente.TabIndex = 5
        '
        'Frm_CadastrarConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 806)
        Me.Controls.Add(Me.Grp_Transferencia)
        Me.Controls.Add(Me.Grp_Extrato)
        Me.Controls.Add(Me.Grp_Deposito)
        Me.Controls.Add(Me.Grp_Sacar)
        Me.Controls.Add(Me.Grp_Cadastrar)
        Me.Name = "Frm_CadastrarConta"
        Me.Text = "Frm_Principal_02"
        Me.Grp_Cadastrar.ResumeLayout(False)
        Me.Grp_Cadastrar.PerformLayout()
        Me.Grp_Sacar.ResumeLayout(False)
        Me.Grp_Sacar.PerformLayout()
        Me.Grp_Deposito.ResumeLayout(False)
        Me.Grp_Deposito.PerformLayout()
        Me.Grp_Extrato.ResumeLayout(False)
        Me.Grp_Extrato.PerformLayout()
        Me.Grp_Transferencia.ResumeLayout(False)
        Me.Grp_Transferencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Titular As Label
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Lbl_Conta As Label
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Txt_Ttular As TextBox
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Btm_SalvarConta As Button
    Friend WithEvents Btm_ListarContas As Button
    Friend WithEvents Grp_Cadastrar As GroupBox
    Friend WithEvents Grp_Sacar As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_SaldoSaque As TextBox
    Friend WithEvents Lbl_SaldoSaque As Label
    Friend WithEvents Btm_Sacar As Button
    Friend WithEvents Lbl_AgenciaSaque As Label
    Friend WithEvents Txt_ValorSaque As TextBox
    Friend WithEvents Lbl_ContaSaque As Label
    Friend WithEvents Txt_ContaSaque As TextBox
    Friend WithEvents Lbl_ValorSaque As Label
    Friend WithEvents Txt_AgenciaSaque As TextBox
    Friend WithEvents Lbl_MensagemSaque As Label
    Friend WithEvents Grp_Deposito As GroupBox
    Friend WithEvents Lbl_MensagemDeposito As Label
    Friend WithEvents Txt_SaldoDeposito As TextBox
    Friend WithEvents Lbl_SaldoDeposito As Label
    Friend WithEvents Btm_Depositar As Button
    Friend WithEvents Lbl_AgenciaDeposito As Label
    Friend WithEvents Txt_ValorDeposito As TextBox
    Friend WithEvents Lbl_ContaDeposito As Label
    Friend WithEvents Txt_ContaDeposito As TextBox
    Friend WithEvents Lbl_ValorDeposito As Label
    Friend WithEvents Txt_AgenciaDeposito As TextBox
    Friend WithEvents Lbl_DepositarValores As Label
    Friend WithEvents Grp_Extrato As GroupBox
    Friend WithEvents Txt_Extrato As TextBox
    Friend WithEvents Btm_Extrato As Button
    Friend WithEvents Lbl_agenciaExtrato As Label
    Friend WithEvents Lbl_contaExtrato As Label
    Friend WithEvents Txt_contaExtrato As TextBox
    Friend WithEvents Txt_agenciaExtrato As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Grp_Transferencia As GroupBox
    Friend WithEvents Btm_Transferencia As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_AgDestino As TextBox
    Friend WithEvents Txt_VlRemetente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_TransferenciaRemetente As Label
    Friend WithEvents Txt_AgRemetente As TextBox
    Friend WithEvents Txt_TitularDestino As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_TiRemetente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_ContaRemetente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_ContaDestino As TextBox
End Class
