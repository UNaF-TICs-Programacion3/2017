<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoEstacionamiento
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
        Me.DtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.LblHoraInicio = New System.Windows.Forms.Label()
        Me.LblFechaEgreso = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNombreCliente = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.CmbTipoEstacionamiento = New System.Windows.Forms.ComboBox()
        Me.LblTipoEstacionamiento = New System.Windows.Forms.Label()
        Me.ChkTieneBonificacion = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'DtpHoraInicio
        '
        Me.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraInicio.Location = New System.Drawing.Point(163, 79)
        Me.DtpHoraInicio.Name = "DtpHoraInicio"
        Me.DtpHoraInicio.Size = New System.Drawing.Size(105, 22)
        Me.DtpHoraInicio.TabIndex = 0
        '
        'DtpHoraFin
        '
        Me.DtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraFin.Location = New System.Drawing.Point(163, 109)
        Me.DtpHoraFin.Name = "DtpHoraFin"
        Me.DtpHoraFin.Size = New System.Drawing.Size(107, 22)
        Me.DtpHoraFin.TabIndex = 1
        '
        'LblHoraInicio
        '
        Me.LblHoraInicio.AutoSize = True
        Me.LblHoraInicio.Location = New System.Drawing.Point(81, 81)
        Me.LblHoraInicio.Name = "LblHoraInicio"
        Me.LblHoraInicio.Size = New System.Drawing.Size(75, 17)
        Me.LblHoraInicio.TabIndex = 2
        Me.LblHoraInicio.Text = "Hora Inicio"
        '
        'LblFechaEgreso
        '
        Me.LblFechaEgreso.AutoSize = True
        Me.LblFechaEgreso.Location = New System.Drawing.Point(94, 112)
        Me.LblFechaEgreso.Name = "LblFechaEgreso"
        Me.LblFechaEgreso.Size = New System.Drawing.Size(62, 17)
        Me.LblFechaEgreso.TabIndex = 3
        Me.LblFechaEgreso.Text = "Hora Fin"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(163, 139)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(107, 22)
        Me.TxtNombreCliente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nuevo Estacionamiento"
        '
        'LblNombreCliente
        '
        Me.LblNombreCliente.AutoSize = True
        Me.LblNombreCliente.Location = New System.Drawing.Point(97, 143)
        Me.LblNombreCliente.Name = "LblNombreCliente"
        Me.LblNombreCliente.Size = New System.Drawing.Size(57, 17)
        Me.LblNombreCliente.TabIndex = 7
        Me.LblNombreCliente.Text = "Patente"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(352, 240)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(434, 240)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'CmbTipoEstacionamiento
        '
        Me.CmbTipoEstacionamiento.FormattingEnabled = True
        Me.CmbTipoEstacionamiento.Location = New System.Drawing.Point(163, 169)
        Me.CmbTipoEstacionamiento.Name = "CmbTipoEstacionamiento"
        Me.CmbTipoEstacionamiento.Size = New System.Drawing.Size(250, 24)
        Me.CmbTipoEstacionamiento.TabIndex = 9
        '
        'LblTipoEstacionamiento
        '
        Me.LblTipoEstacionamiento.AutoSize = True
        Me.LblTipoEstacionamiento.Location = New System.Drawing.Point(12, 174)
        Me.LblTipoEstacionamiento.Name = "LblTipoEstacionamiento"
        Me.LblTipoEstacionamiento.Size = New System.Drawing.Size(144, 17)
        Me.LblTipoEstacionamiento.TabIndex = 10
        Me.LblTipoEstacionamiento.Text = "Tipo Estacionamiento"
        '
        'ChkTieneBonificacion
        '
        Me.ChkTieneBonificacion.AutoSize = True
        Me.ChkTieneBonificacion.Location = New System.Drawing.Point(163, 201)
        Me.ChkTieneBonificacion.Name = "ChkTieneBonificacion"
        Me.ChkTieneBonificacion.Size = New System.Drawing.Size(96, 21)
        Me.ChkTieneBonificacion.TabIndex = 11
        Me.ChkTieneBonificacion.Text = "Bonificado"
        Me.ChkTieneBonificacion.UseVisualStyleBackColor = True
        '
        'FrmNuevoEstacionamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 280)
        Me.Controls.Add(Me.ChkTieneBonificacion)
        Me.Controls.Add(Me.LblTipoEstacionamiento)
        Me.Controls.Add(Me.CmbTipoEstacionamiento)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.LblFechaEgreso)
        Me.Controls.Add(Me.LblHoraInicio)
        Me.Controls.Add(Me.DtpHoraFin)
        Me.Controls.Add(Me.DtpHoraInicio)
        Me.Name = "FrmNuevoEstacionamiento"
        Me.Text = "Hotel Madison - Nueva Reserva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpHoraInicio As DateTimePicker
    Friend WithEvents DtpHoraFin As DateTimePicker
    Friend WithEvents LblHoraInicio As Label
    Friend WithEvents LblFechaEgreso As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNombreCliente As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents CmbTipoEstacionamiento As ComboBox
    Friend WithEvents LblTipoEstacionamiento As Label
    Friend WithEvents ChkTieneBonificacion As CheckBox
End Class
