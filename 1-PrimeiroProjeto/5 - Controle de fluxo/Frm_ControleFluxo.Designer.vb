<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ControleFluxo
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
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Btm_Checagem = New System.Windows.Forms.Button()
        Me.Chk_Acompanhada = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Location = New System.Drawing.Point(26, 23)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(48, 16)
        Me.Lbl_Title.TabIndex = 0
        Me.Lbl_Title.Text = "Label1"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(29, 64)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(143, 22)
        Me.Txt_Idade.TabIndex = 1
        '
        'Btm_Checagem
        '
        Me.Btm_Checagem.Location = New System.Drawing.Point(29, 141)
        Me.Btm_Checagem.Name = "Btm_Checagem"
        Me.Btm_Checagem.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Checagem.TabIndex = 2
        Me.Btm_Checagem.Text = "Button1"
        Me.Btm_Checagem.UseVisualStyleBackColor = True
        '
        'Chk_Acompanhada
        '
        Me.Chk_Acompanhada.AutoSize = True
        Me.Chk_Acompanhada.Location = New System.Drawing.Point(29, 104)
        Me.Chk_Acompanhada.Name = "Chk_Acompanhada"
        Me.Chk_Acompanhada.Size = New System.Drawing.Size(97, 20)
        Me.Chk_Acompanhada.TabIndex = 3
        Me.Chk_Acompanhada.Text = "CheckBox1"
        Me.Chk_Acompanhada.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(632, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Resultado.Location = New System.Drawing.Point(26, 192)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(126, 40)
        Me.Lbl_Resultado.TabIndex = 5
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Frm_ControleFluxo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Chk_Acompanhada)
        Me.Controls.Add(Me.Btm_Checagem)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Name = "Frm_ControleFluxo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Title As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Btm_Checagem As Button
    Friend WithEvents Chk_Acompanhada As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_Resultado As Label
End Class
