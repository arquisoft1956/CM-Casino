Public Class StatusBusy

  Implements IDisposable

    Private mOldStatus As String
    Private mOldCursor As Cursor
    Private mform As Form

    Public Sub New(ByVal statusText As String, ByVal form As Form)
        form.Cursor = Cursors.WaitCursor
        Dim lab As System.Windows.Forms.StatusStrip = New System.Windows.Forms.StatusStrip
        lab.Name = "StatusStrip"
        lab.BackColor = Color.Gray
        Dim label As ToolStripStatusLabel = New ToolStripStatusLabel
        label.Text = statusText
        lab.Items.Add(label)
        form.Controls.Add(lab)
        mform = form
        System.Windows.Forms.Application.DoEvents()
        '  System.Threading.Thread.Sleep(5000)
    End Sub
    'Public Sub New(ByVal statusText As String)

    '    mOldStatus = MainForm.StatusLabel.Text
    '    MainForm.StatusLabel.Text = statusText
    '    MainForm.StatusStrip1.Refresh()
    '    mOldCursor = MainForm.Cursor
    '    MainForm.Cursor = Cursors.WaitCursor

    'End Sub

    ' IDisposable
  Private disposedValue As Boolean = False ' To detect redundant calls

  Protected Overridable Sub Dispose(ByVal disposing As Boolean)
    If Not Me.disposedValue Then
            If disposing Then
                'MainForm.StatusLabel.Text = mOldStatus
                'MainForm.Cursor = mOldCursor

                Dim cont As Integer = -1
                For Each fo1 As Control In mform.Controls
                    cont = cont + 1
                    If fo1.Name = "StatusStrip" Then
                        mform.Controls(cont).Hide()
                    End If
                Next
                mform.Cursor = Cursors.Default

            End If
    End If
        Me.disposedValue = True
  End Sub

  Public Sub Dispose() Implements IDisposable.Dispose
    ' Do not change this code.  
    ' Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    Dispose(True)
    GC.SuppressFinalize(Me)
  End Sub

End Class
