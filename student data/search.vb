Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class search
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lalit patel\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30")
        TextBox1.Text = student.roll
        TextBox2.Text = student.name1
        TextBox3.Text = student.course
        TextBox4.Text = student.fees

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "delete from student WHERE roll_no=" + TextBox1.Text
        command = New SqlCommand(sql, connection)
        connection.Open()
        command.ExecuteNonQuery()
        MsgBox("deleted successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String = "update student set name='" + TextBox2.Text + "',course='" + TextBox3.Text + "',fees=" + TextBox4.Text + " WHERE roll_no=" + TextBox1.Text
        command = New SqlCommand(sql, connection)
        connection.Open()
        command.ExecuteNonQuery()
        MsgBox("Updated successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        student.Show()

    End Sub
End Class