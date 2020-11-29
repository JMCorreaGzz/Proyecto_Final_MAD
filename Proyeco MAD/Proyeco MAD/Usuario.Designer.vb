<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButEmpl = New System.Windows.Forms.Button()
        Me.ButDep = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButInc = New System.Windows.Forms.Button()
        Me.ButPer = New System.Windows.Forms.Button()
        Me.ButRep = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NomUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEmpresas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButEmpl
        '
        Me.ButEmpl.Location = New System.Drawing.Point(18, 83)
        Me.ButEmpl.Name = "ButEmpl"
        Me.ButEmpl.Size = New System.Drawing.Size(116, 31)
        Me.ButEmpl.TabIndex = 0
        Me.ButEmpl.Text = "EMPLEADOS"
        Me.ButEmpl.UseVisualStyleBackColor = True
        '
        'ButDep
        '
        Me.ButDep.Location = New System.Drawing.Point(265, 83)
        Me.ButDep.Name = "ButDep"
        Me.ButDep.Size = New System.Drawing.Size(116, 31)
        Me.ButDep.TabIndex = 2
        Me.ButDep.Text = "DEPARTAMENTOS"
        Me.ButDep.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(387, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "PUESTOS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButInc
        '
        Me.ButInc.Location = New System.Drawing.Point(387, 130)
        Me.ButInc.Name = "ButInc"
        Me.ButInc.Size = New System.Drawing.Size(116, 31)
        Me.ButInc.TabIndex = 7
        Me.ButInc.Text = "INCIDENCIAS"
        Me.ButInc.UseVisualStyleBackColor = True
        '
        'ButPer
        '
        Me.ButPer.Location = New System.Drawing.Point(170, 130)
        Me.ButPer.Name = "ButPer"
        Me.ButPer.Size = New System.Drawing.Size(195, 31)
        Me.ButPer.TabIndex = 5
        Me.ButPer.Text = "PERCEPCIONES Y DEDUCCIONES"
        Me.ButPer.UseVisualStyleBackColor = True
        '
        'ButRep
        '
        Me.ButRep.Location = New System.Drawing.Point(18, 130)
        Me.ButRep.Name = "ButRep"
        Me.ButRep.Size = New System.Drawing.Size(116, 31)
        Me.ButRep.TabIndex = 4
        Me.ButRep.Text = "REPORTES"
        Me.ButRep.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bienvenido"
        '
        'NomUsuario
        '
        Me.NomUsuario.BackColor = System.Drawing.SystemColors.MenuBar
        Me.NomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomUsuario.Location = New System.Drawing.Point(206, 25)
        Me.NomUsuario.Name = "NomUsuario"
        Me.NomUsuario.Size = New System.Drawing.Size(132, 13)
        Me.NomUsuario.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Seleccione el menú a donde desea ingresar"
        '
        'btnEmpresas
        '
        Me.btnEmpresas.Location = New System.Drawing.Point(143, 83)
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Size = New System.Drawing.Size(112, 30)
        Me.btnEmpresas.TabIndex = 11
        Me.btnEmpresas.Text = "EMPRESAS"
        Me.btnEmpresas.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 195)
        Me.Controls.Add(Me.btnEmpresas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NomUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButInc)
        Me.Controls.Add(Me.ButPer)
        Me.Controls.Add(Me.ButRep)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButDep)
        Me.Controls.Add(Me.ButEmpl)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButEmpl As Button
    Friend WithEvents ButDep As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ButInc As Button
    Friend WithEvents ButPer As Button
    Friend WithEvents ButRep As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NomUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEmpresas As Button
End Class
