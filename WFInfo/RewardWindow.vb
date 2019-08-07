Public Class RewardWindow
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Shared rwrdPanels(4) As Panel
    Private Shared rwrdNames(4) As Label
    Private Shared rwrdVault(4) As Label
    Private Shared rwrdPlats(4) As Label
    Private Shared rwrdPlatIcon(4) As PictureBox
    Private Shared rwrdDucats(4) As Label
    Private Shared rwrdDucatIcon(4) As PictureBox
    Private Shared rwrdRates(4) As Label

    Private Sub RewardWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim spacing As Integer = 125

        For i As Integer = 0 To 3
            rwrdPanels(i) = New Panel With {
                .Visible = False,
                .Size = New Size(128, 126),
                .Location = New Point(127 * i - 1, 0),
                .BorderStyle = BorderStyle.FixedSingle
            }

            rwrdNames(i) = New Label() With {
                .Font = tahoma10,
                .ForeColor = textColor,
                .TextAlign = ContentAlignment.TopCenter,
                .Size = New Size(spacing - 5, 35),
                .Location = New Point(3, 30)
            }
            rwrdRates(i) = New Label() With {
                .Font = tahoma8,
                .ForeColor = textColor,
                .TextAlign = ContentAlignment.TopCenter,
                .Size = New Size(128, 20),
                .Location = New Point(0, 103)
            }
            rwrdVault(i) = New Label() With {
                .Visible = False,
                .Font = tahoma8,
                .ForeColor = textColor,
                .TextAlign = ContentAlignment.TopCenter,
                .Size = New Size(spacing - 5, 15)
            }
            rwrdPlats(i) = New Label() With {
                .Font = tahoma8_bold,
                .ForeColor = textColor,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Size = New Size(52, 15),
                .Location = New Point(3, 83)
            }
            rwrdPlatIcon(i) = New PictureBox() With {
                .Image = My.Resources.plat,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Size = New Size(13, 13)
            }
            rwrdDucats(i) = New Label() With {
                .Font = tahoma8_bold,
                .ForeColor = textColor,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Size = New Size(52, 15),
                .Location = New Point(63, 83)
            }
            rwrdDucatIcon(i) = New PictureBox() With {
                .Image = My.Resources.ducat_w,
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .Size = New Size(13, 13)
            }
            rwrdPanels(i).Controls.Add(rwrdVault(i))
            rwrdPanels(i).Controls.Add(rwrdNames(i))
            rwrdPanels(i).Controls.Add(rwrdPlatIcon(i))
            rwrdPanels(i).Controls.Add(rwrdPlats(i))
            rwrdPanels(i).Controls.Add(rwrdDucatIcon(i))
            rwrdPanels(i).Controls.Add(rwrdDucats(i))
            rwrdPanels(i).Controls.Add(rwrdRates(i))
            MainPanel.Controls.Add(rwrdPanels(i))
        Next

    End Sub

    Private Sub RewardWindow_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible And Not IsWindowMoveable(Me) Then
            Dim scr As Screen = GetMainScreen()
            Me.Location = New Point(scr.WorkingArea.X + 200, scr.WorkingArea.Y + 200)
        End If
    End Sub

    Private Sub startDRAGnDROP(sender As Object, e As MouseEventArgs) Handles pTitle.MouseDown, lbTitle.MouseDown, pbIcon.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub DRAGnDROP(sender As Object, e As MouseEventArgs) Handles pTitle.MouseMove, lbTitle.MouseMove, pbIcon.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub stopDRAGnDROP(sender As Object, e As MouseEventArgs) Handles pTitle.MouseUp, lbTitle.MouseUp, pbIcon.MouseUp
        drag = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '-------------------------------------------------------------
    ' BEGIN REWARD FUNCTIONS
    '-------------------------------------------------------------


    Private Sub RewardWindow_Reset()
        For i As Integer = 0 To 3
            rwrdPanels(i).Visible = False
            rwrdVault(i).Visible = False
        Next

    End Sub

    Friend Sub Display(foundText As String(), plyrs As Integer)
        Dim visible As Boolean = Me.Visible
        Me.Show()
        Me.TopMost = True


        RewardWindow_Reset()

        Me.Size = New Size(foundText.Count * 127 + 1, 126)
        If Not visible Then
            Me.Location = New Point(Main.Location.X + (Main.Width - Me.Size.Width) / 2, Main.Location.Y + Main.Height + 25)
        End If

        Using g As Graphics = CreateGraphics()
            For i = 0 To plyrs - 1
                If foundText(i) IsNot Nothing Then
                    Dim job As Newtonsoft.Json.Linq.JObject = db.market_data(foundText(i))
                    rwrdPanels(i).Visible = True
                    rwrdNames(i).Text = foundText(i)
                    rwrdPlats(i).Text = db.market_data(foundText(i))("plat")
                    rwrdDucats(i).Text = db.market_data(foundText(i))("ducats").ToString()
                    rwrdRates(i).Text = job("volume").ToString() & " sold last 48hrs"

                    Dim size As SizeF = g.MeasureString(rwrdPlats(i).Text, rwrdPlats(i).Font)
                    rwrdPlatIcon(i).Location = New Point(CInt(28.5 + size.Width / 2), 84)

                    size = g.MeasureString(rwrdDucats(i).Text, rwrdDucats(i).Font)
                    rwrdDucatIcon(i).Location = New Point(CInt(88.5 + size.Width / 2), 84)

                    If foundText(i).Equals("Forma Blueprint") OrElse db.IsPartVaulted(foundText(i)) Then
                        size = g.MeasureString(foundText(i), rwrdNames(i).Font, 120)
                        rwrdVault(i).Location = New Size(3, 32 + size.Height)
                        rwrdVault(i).Visible = True
                        rwrdVault(i).Text = "Vaulted"
                    End If
                End If
            Next
        End Using
        Dim lastUsedLocation = Me.Location
        'Me.Refresh()
        Me.TopMost = False
    End Sub

    Private Sub cbtopToggle_Click(sender As Object, e As EventArgs) Handles topToggle.Click
        If topToggle.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class