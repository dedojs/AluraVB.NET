<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_NovaConta = New System.Windows.Forms.Button()
        Me.Btm_VerificarContas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Principal.Location = New System.Drawing.Point(356, 106)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(77, 29)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Menu"
        '
        'Btm_NovaConta
        '
        Me.Btm_NovaConta.Location = New System.Drawing.Point(223, 153)
        Me.Btm_NovaConta.Name = "Btm_NovaConta"
        Me.Btm_NovaConta.Size = New System.Drawing.Size(319, 32)
        Me.Btm_NovaConta.TabIndex = 1
        Me.Btm_NovaConta.Text = "Cadastrar conta"
        Me.Btm_NovaConta.UseVisualStyleBackColor = True
        '
        'Btm_VerificarContas
        '
        Me.Btm_VerificarContas.Location = New System.Drawing.Point(223, 203)
        Me.Btm_VerificarContas.Name = "Btm_VerificarContas"
        Me.Btm_VerificarContas.Size = New System.Drawing.Size(319, 32)
        Me.Btm_VerificarContas.TabIndex = 2
        Me.Btm_VerificarContas.Text = "Listar Contas"
        Me.Btm_VerificarContas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bem vindo ao Banco Movere"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Efetuar Saque"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btm_VerificarContas)
        Me.Controls.Add(Me.Btm_NovaConta)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_NovaConta As Button
    Friend WithEvents Btm_VerificarContas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
