<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaContas
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
        Me.Txt_ListContas = New System.Windows.Forms.TextBox()
        Me.Lbl_ListContas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_ListContas
        '
        Me.Txt_ListContas.Location = New System.Drawing.Point(37, 101)
        Me.Txt_ListContas.Multiline = True
        Me.Txt_ListContas.Name = "Txt_ListContas"
        Me.Txt_ListContas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ListContas.Size = New System.Drawing.Size(488, 390)
        Me.Txt_ListContas.TabIndex = 0
        '
        'Lbl_ListContas
        '
        Me.Lbl_ListContas.AutoSize = True
        Me.Lbl_ListContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ListContas.Location = New System.Drawing.Point(160, 37)
        Me.Lbl_ListContas.Name = "Lbl_ListContas"
        Me.Lbl_ListContas.Size = New System.Drawing.Size(242, 29)
        Me.Lbl_ListContas.TabIndex = 1
        Me.Lbl_ListContas.Text = "Contas cadastradas"
        '
        'Frm_ListaContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 543)
        Me.Controls.Add(Me.Lbl_ListContas)
        Me.Controls.Add(Me.Txt_ListContas)
        Me.Name = "Frm_ListaContas"
        Me.Text = "Relatório de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_ListContas As TextBox
    Friend WithEvents Lbl_ListContas As Label
End Class
