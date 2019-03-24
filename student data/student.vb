Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class student
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Public roll, name1, course, fees
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lalit patel\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sql As String = "insert into student (roll_no,name,course,fees) values (" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ")"

        command = New SqlCommand(sql, connection)
        connection.Open()
        command.ExecuteNonQuery()
        MsgBox("OK")
        connection.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String = "Select * from student WHERE roll_no=" + TextBox5.Text
        ' MsgBox(sql)
        command = New SqlCommand(sql, connection)
        connection.Open()
        Dim reader As SqlDataReader
        reader = command.ExecuteReader()
        If reader.Read Then
            roll = reader.Item("roll_no")
            name1 = reader.Item(1)
            course = reader.Item(2)
            fees = reader.Item(3)


        Else
            MsgBox("User Not Found", MsgBoxStyle.Critical)


        End If



        connection.Close()



        Me.Hide()
        search.Show()
    End Sub
End Class