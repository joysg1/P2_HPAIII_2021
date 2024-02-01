Imports System.ComponentModel

Public Class Form1
    Dim password As String
    Dim intentos As Integer
    Dim saldo As Decimal
    Dim retiro As Decimal
    Dim aprobar1 As Boolean
    Dim aprobar2 As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbOpciones.Enabled = False
        gbHistorial.Enabled = False
        intentos = 0
        saldo = 2500
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Acceso()

    End Sub

    Sub Acceso()

        password = tbPassword.Text




        If (password <> "12345") Then

            MsgBox("Password invalido")
            intentos = intentos + 1
            Veces()
        End If

        If (password = "12345") Then
            gbOpciones.Enabled = True
            gbHistorial.Enabled = True
            gbAcceso.Enabled = False
            Retirar()

        End If

    End Sub


    Sub Veces()
        If (intentos >= 3) Then
            Me.Close()
        End If
    End Sub


    Sub Retirar()


        If (rbMontoPer.Checked = True) Then
            retiro = Val(tbCantidad.Text)
            aprobar1 = True

            If (retiro > 500) Then
                MsgBox("Retiro mayor a 500")

                If (retiro Mod 5 <> 0) Then
                    MsgBox("Denominacion equivocada")
                End If
                aprobar1 = False
            End If

            If (retiro Mod 5 <> 0) Then
                MsgBox("Denominacion equivocada")
                aprobar1 = False
            End If


            VerificarSaldo()
            Imprimir()


        End If



        If (rbMontoFijo.Checked = True) Then

            If (cbMonto.Text = "Seleccione Monto") Then
                aprobar1 = False
                MsgBox("Favor verifique el monto")

            Else
                aprobar1 = True
                retiro = Val(cbMonto.SelectedItem)
                VerificarSaldo()
                MsgBox("Ha retirado: " + Str(retiro))
                Imprimir()
            End If



        End If


    End Sub

    Private Sub rbMontoFijo_CheckedChanged(sender As Object, e As EventArgs) Handles rbMontoFijo.CheckedChanged
        If (rbMontoFijo.Checked = False) Then
            cbMonto.Enabled = False
        End If
        If (rbMontoFijo.Checked = True) Then
            cbMonto.Enabled = True
        End If
    End Sub

    Private Sub rbMontoPer_CheckedChanged(sender As Object, e As EventArgs) Handles rbMontoPer.CheckedChanged
        If (rbMontoPer.Checked = False) Then
            tbCantidad.Enabled = True
        End If

        If (rbMontoPer.Checked = True) Then
            tbCantidad.Enabled = True
        End If
    End Sub

    Private Sub btnAcep_Click(sender As Object, e As EventArgs) Handles btnAcep.Click
        Retirar()
    End Sub




    Sub VerificarSaldo()
        If (saldo >= 5) Then
            aprobar2 = True
        End If

        If (saldo < 5) Then

            aprobar2 = False
        End If



        If (aprobar1 = True And aprobar2 = True) Then
            saldo = saldo - retiro
            MsgBox("Nuevo saldo: " + Str(saldo))
        End If

        If (aprobar1 = True And aprobar2 = False) Then
            MsgBox("Imposible realizar transaccion")
        End If

        If (aprobar1 = False And aprobar2 = True) Then
            MsgBox("Imposible realizar transaccion")
        End If

        If (aprobar1 = False And aprobar2 = False) Then
            MsgBox("Imposible realizar transaccion")
        End If


    End Sub


    Sub Imprimir()



        While (aprobar1 = False Or aprobar2 = False)
            gbHistorial.Enabled = False

            For index = 1 To 2
                MsgBox("TRANSACCION FALLIDA, reestableciendo sistema, favor espere...")

            Next
            gbHistorial.Enabled = True
            MsgBox("Sistema en linea")
            Exit While
        End While

        lbHistory.Items.Add("Retiro: " + Str(retiro))
        lbHistory.Items.Add("Status1: " + Str(aprobar1))
        lbHistory.Items.Add("Status2: " + Str(aprobar2))
        lbHistory.Items.Add("Nuevo Saldo: " + Str(saldo))
    End Sub
End Class
