<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbAcceso = New System.Windows.Forms.GroupBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnAcep = New System.Windows.Forms.Button()
        Me.cbMonto = New System.Windows.Forms.ComboBox()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbMontoPer = New System.Windows.Forms.RadioButton()
        Me.rbMontoFijo = New System.Windows.Forms.RadioButton()
        Me.gbHistorial = New System.Windows.Forms.GroupBox()
        Me.lbHistory = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbAcceso.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.gbHistorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAcceso
        '
        Me.gbAcceso.Controls.Add(Me.btnEntrar)
        Me.gbAcceso.Controls.Add(Me.tbPassword)
        Me.gbAcceso.Controls.Add(Me.Label2)
        Me.gbAcceso.Location = New System.Drawing.Point(23, 34)
        Me.gbAcceso.Name = "gbAcceso"
        Me.gbAcceso.Size = New System.Drawing.Size(224, 246)
        Me.gbAcceso.TabIndex = 0
        Me.gbAcceso.TabStop = False
        Me.gbAcceso.Text = "ACCESO"
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(67, 168)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 40)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(89, 58)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(100, 22)
        Me.tbPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnAcep)
        Me.gbOpciones.Controls.Add(Me.cbMonto)
        Me.gbOpciones.Controls.Add(Me.tbCantidad)
        Me.gbOpciones.Controls.Add(Me.Label1)
        Me.gbOpciones.Controls.Add(Me.rbMontoPer)
        Me.gbOpciones.Controls.Add(Me.rbMontoFijo)
        Me.gbOpciones.Location = New System.Drawing.Point(281, 34)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(200, 246)
        Me.gbOpciones.TabIndex = 1
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES DE RETIRO"
        '
        'btnAcep
        '
        Me.btnAcep.Location = New System.Drawing.Point(49, 205)
        Me.btnAcep.Name = "btnAcep"
        Me.btnAcep.Size = New System.Drawing.Size(91, 35)
        Me.btnAcep.TabIndex = 5
        Me.btnAcep.Text = "ACEPTAR"
        Me.btnAcep.UseVisualStyleBackColor = True
        '
        'cbMonto
        '
        Me.cbMonto.FormattingEnabled = True
        Me.cbMonto.Items.AddRange(New Object() {"5", "10", "20", "50"})
        Me.cbMonto.Location = New System.Drawing.Point(24, 168)
        Me.cbMonto.Name = "cbMonto"
        Me.cbMonto.Size = New System.Drawing.Size(148, 24)
        Me.cbMonto.TabIndex = 4
        Me.cbMonto.Text = "Seleccione Monto"
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(91, 82)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(81, 22)
        Me.tbCantidad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad"
        '
        'rbMontoPer
        '
        Me.rbMontoPer.AutoSize = True
        Me.rbMontoPer.Location = New System.Drawing.Point(21, 43)
        Me.rbMontoPer.Name = "rbMontoPer"
        Me.rbMontoPer.Size = New System.Drawing.Size(165, 21)
        Me.rbMontoPer.TabIndex = 1
        Me.rbMontoPer.TabStop = True
        Me.rbMontoPer.Text = "Monto personalizado:"
        Me.rbMontoPer.UseVisualStyleBackColor = True
        '
        'rbMontoFijo
        '
        Me.rbMontoFijo.AutoSize = True
        Me.rbMontoFijo.Location = New System.Drawing.Point(21, 134)
        Me.rbMontoFijo.Name = "rbMontoFijo"
        Me.rbMontoFijo.Size = New System.Drawing.Size(94, 21)
        Me.rbMontoFijo.TabIndex = 0
        Me.rbMontoFijo.TabStop = True
        Me.rbMontoFijo.Text = "Monto Fijo"
        Me.rbMontoFijo.UseVisualStyleBackColor = True
        '
        'gbHistorial
        '
        Me.gbHistorial.Controls.Add(Me.lbHistory)
        Me.gbHistorial.Location = New System.Drawing.Point(501, 34)
        Me.gbHistorial.Name = "gbHistorial"
        Me.gbHistorial.Size = New System.Drawing.Size(200, 246)
        Me.gbHistorial.TabIndex = 2
        Me.gbHistorial.TabStop = False
        Me.gbHistorial.Text = "HISTORIAL"
        '
        'lbHistory
        '
        Me.lbHistory.FormattingEnabled = True
        Me.lbHistory.ItemHeight = 16
        Me.lbHistory.Location = New System.Drawing.Point(7, 22)
        Me.lbHistory.Name = "lbHistory"
        Me.lbHistory.Size = New System.Drawing.Size(187, 212)
        Me.lbHistory.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(626, 286)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 38)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 336)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbHistorial)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.gbAcceso)
        Me.Name = "Form1"
        Me.Text = "BANCO SU VECINO"
        Me.gbAcceso.ResumeLayout(False)
        Me.gbAcceso.PerformLayout()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        Me.gbHistorial.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAcceso As GroupBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbOpciones As GroupBox
    Friend WithEvents gbHistorial As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEntrar As Button
    Friend WithEvents lbHistory As ListBox
    Friend WithEvents cbMonto As ComboBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbMontoPer As RadioButton
    Friend WithEvents rbMontoFijo As RadioButton
    Friend WithEvents btnAcep As Button
End Class
