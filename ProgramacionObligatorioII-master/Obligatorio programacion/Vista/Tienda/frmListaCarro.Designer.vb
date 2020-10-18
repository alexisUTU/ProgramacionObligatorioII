<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaCarro
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
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flPanel
        '
        Me.flPanel.AutoScroll = True
        Me.flPanel.Location = New System.Drawing.Point(22, 61)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.Size = New System.Drawing.Size(1148, 530)
        Me.flPanel.TabIndex = 0
        '
        'frmListaCarro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1170, 593)
        Me.Controls.Add(Me.flPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListaCarro"
        Me.Text = "frmListaCarro"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flPanel As FlowLayoutPanel
End Class
