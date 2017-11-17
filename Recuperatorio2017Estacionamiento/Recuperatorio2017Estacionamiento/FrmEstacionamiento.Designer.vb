<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEstacionamiento
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnNuevaReserva = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnVerDetalle = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(740, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnNuevaReserva
        '
        Me.BtnNuevaReserva.Location = New System.Drawing.Point(554, 16)
        Me.BtnNuevaReserva.Name = "BtnNuevaReserva"
        Me.BtnNuevaReserva.Size = New System.Drawing.Size(198, 39)
        Me.BtnNuevaReserva.TabIndex = 1
        Me.BtnNuevaReserva.Text = "Nueva Estacionamiento"
        Me.BtnNuevaReserva.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estacionamientos"
        '
        'BtnVerDetalle
        '
        Me.BtnVerDetalle.Location = New System.Drawing.Point(422, 16)
        Me.BtnVerDetalle.Name = "BtnVerDetalle"
        Me.BtnVerDetalle.Size = New System.Drawing.Size(126, 39)
        Me.BtnVerDetalle.TabIndex = 1
        Me.BtnVerDetalle.Text = "Ver Detalle"
        Me.BtnVerDetalle.UseVisualStyleBackColor = True
        '
        'FrmEstacionamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnVerDetalle)
        Me.Controls.Add(Me.BtnNuevaReserva)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmEstacionamiento"
        Me.Text = "Estacionamiento El Yunke - Estacionamientos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnNuevaReserva As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnVerDetalle As Button
End Class
