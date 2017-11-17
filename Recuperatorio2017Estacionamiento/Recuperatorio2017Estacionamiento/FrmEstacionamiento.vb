Public Class FrmEstacionamiento
    Private Sub BtnNuevaReserva_Click(sender As Object, e As EventArgs) Handles BtnNuevaReserva.Click
        FrmNuevoEstacionamiento.ShowDialog()
    End Sub

    Private Sub BtnVerDetalle_Click(sender As Object, e As EventArgs) Handles BtnVerDetalle.Click
        'DateDiff()
        MsgBox("Aquí debe ir el detalle del estacionamiento (Duracion en Horas, Duracion en Minutos e Importe a Pagar) seleccionado.", vbInformation, "Hotel Madison -Detalle de la Reserva")
    End Sub
End Class
