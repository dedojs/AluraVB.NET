<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btm_1 = New System.Windows.Forms.Button()
        Me.Btm_2 = New System.Windows.Forms.Button()
        Me.Btm_3 = New System.Windows.Forms.Button()
        Me.Btm_4 = New System.Windows.Forms.Button()
        Me.Btm_5 = New System.Windows.Forms.Button()
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btm_1
        '
        Me.Btm_1.Location = New System.Drawing.Point(12, 85)
        Me.Btm_1.Name = "Btm_1"
        Me.Btm_1.Size = New System.Drawing.Size(268, 23)
        Me.Btm_1.TabIndex = 0
        Me.Btm_1.Text = "Button1"
        Me.Btm_1.UseVisualStyleBackColor = True
        '
        'Btm_2
        '
        Me.Btm_2.Location = New System.Drawing.Point(12, 114)
        Me.Btm_2.Name = "Btm_2"
        Me.Btm_2.Size = New System.Drawing.Size(268, 23)
        Me.Btm_2.TabIndex = 1
        Me.Btm_2.Text = "Button2"
        Me.Btm_2.UseVisualStyleBackColor = True
        '
        'Btm_3
        '
        Me.Btm_3.Location = New System.Drawing.Point(12, 143)
        Me.Btm_3.Name = "Btm_3"
        Me.Btm_3.Size = New System.Drawing.Size(268, 23)
        Me.Btm_3.TabIndex = 2
        Me.Btm_3.Text = "Button3"
        Me.Btm_3.UseVisualStyleBackColor = True
        '
        'Btm_4
        '
        Me.Btm_4.Location = New System.Drawing.Point(12, 172)
        Me.Btm_4.Name = "Btm_4"
        Me.Btm_4.Size = New System.Drawing.Size(268, 23)
        Me.Btm_4.TabIndex = 3
        Me.Btm_4.Text = "Button4"
        Me.Btm_4.UseVisualStyleBackColor = True
        '
        'Btm_5
        '
        Me.Btm_5.Location = New System.Drawing.Point(12, 201)
        Me.Btm_5.Name = "Btm_5"
        Me.Btm_5.Size = New System.Drawing.Size(268, 23)
        Me.Btm_5.TabIndex = 4
        Me.Btm_5.Text = "Button5"
        Me.Btm_5.UseVisualStyleBackColor = True
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 32)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(48, 16)
        Me.Lbl_Principal.TabIndex = 5
        Me.Lbl_Principal.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Menu"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Btm_5)
        Me.Controls.Add(Me.Btm_4)
        Me.Controls.Add(Me.Btm_3)
        Me.Controls.Add(Me.Btm_2)
        Me.Controls.Add(Me.Btm_1)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_1 As Button
    Friend WithEvents Btm_2 As Button
    Friend WithEvents Btm_3 As Button
    Friend WithEvents Btm_4 As Button
    Friend WithEvents Btm_5 As Button
    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Label1 As Label
End Class
