<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManipulandoTextos
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
        Me.Btm_BotaoPrincipal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_Char = New System.Windows.Forms.Button()
        Me.Txt_NumChar = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_List = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_BotaoPrincipal
        '
        Me.Btm_BotaoPrincipal.Location = New System.Drawing.Point(24, 55)
        Me.Btm_BotaoPrincipal.Name = "Btm_BotaoPrincipal"
        Me.Btm_BotaoPrincipal.Size = New System.Drawing.Size(204, 101)
        Me.Btm_BotaoPrincipal.TabIndex = 0
        Me.Btm_BotaoPrincipal.Text = "Clique aqui"
        Me.Btm_BotaoPrincipal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(21, 23)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(120, 16)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto"
        '
        'Btm_Char
        '
        Me.Btm_Char.Location = New System.Drawing.Point(316, 86)
        Me.Btm_Char.Name = "Btm_Char"
        Me.Btm_Char.Size = New System.Drawing.Size(120, 70)
        Me.Btm_Char.TabIndex = 3
        Me.Btm_Char.Text = "Button1"
        Me.Btm_Char.UseVisualStyleBackColor = True
        '
        'Txt_NumChar
        '
        Me.Txt_NumChar.Location = New System.Drawing.Point(316, 58)
        Me.Txt_NumChar.Name = "Txt_NumChar"
        Me.Txt_NumChar.Size = New System.Drawing.Size(120, 22)
        Me.Txt_NumChar.TabIndex = 4
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(21, 190)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(48, 16)
        Me.Lbl_Curso.TabIndex = 5
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Curso.Location = New System.Drawing.Point(24, 222)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(331, 43)
        Me.Txt_Curso.TabIndex = 6
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(361, 222)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(208, 43)
        Me.Btm_Adicionar.TabIndex = 7
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_List
        '
        Me.Txt_List.Location = New System.Drawing.Point(24, 274)
        Me.Txt_List.Multiline = True
        Me.Txt_List.Name = "Txt_List"
        Me.Txt_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_List.Size = New System.Drawing.Size(565, 164)
        Me.Txt_List.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 70)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_ManipulandoTextos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt_List)
        Me.Controls.Add(Me.Btm_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_NumChar)
        Me.Controls.Add(Me.Btm_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_BotaoPrincipal)
        Me.Name = "Frm_ManipulandoTextos"
        Me.Text = "Aplicação Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_BotaoPrincipal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Txt_NumChar As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_List As TextBox
    Friend WithEvents Button1 As Button
End Class
