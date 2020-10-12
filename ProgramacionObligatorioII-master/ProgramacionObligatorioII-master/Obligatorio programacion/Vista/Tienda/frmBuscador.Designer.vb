<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblIngreseTxt = New System.Windows.Forms.Label()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCarro = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIngreseTxt
        '
        Me.lblIngreseTxt.AutoSize = True
        Me.lblIngreseTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseTxt.ForeColor = System.Drawing.Color.White
        Me.lblIngreseTxt.Location = New System.Drawing.Point(55, 76)
        Me.lblIngreseTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngreseTxt.Name = "lblIngreseTxt"
        Me.lblIngreseTxt.Size = New System.Drawing.Size(438, 46)
        Me.lblIngreseTxt.TabIndex = 0
        Me.lblIngreseTxt.Text = "Ingrese nombre articulo"
        '
        'txtBuscador
        '
        Me.txtBuscador.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.txtBuscador.Location = New System.Drawing.Point(4, 4)
        Me.txtBuscador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(876, 51)
        Me.txtBuscador.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnBuscar.Location = New System.Drawing.Point(888, 4)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(166, 51)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListado.EnableHeadersVisualStyles = False
        Me.dgvListado.Location = New System.Drawing.Point(63, 185)
        Me.dgvListado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListado.MultiSelect = False
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListado.RowHeadersVisible = False
        Me.dgvListado.RowHeadersWidth = 51
        Me.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(1085, 426)
        Me.dgvListado.TabIndex = 147
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.64839!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35161!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBuscar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBuscador, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(63, 125)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1058, 60)
        Me.TableLayoutPanel1.TabIndex = 148
        '
        'btnCarro
        '
        Me.btnCarro.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCarro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCarro.FlatAppearance.BorderSize = 0
        Me.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnCarro.Location = New System.Drawing.Point(951, 67)
        Me.btnCarro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarro.Name = "btnCarro"
        Me.btnCarro.Size = New System.Drawing.Size(166, 51)
        Me.btnCarro.TabIndex = 149
        Me.btnCarro.Text = "Carro"
        Me.btnCarro.UseVisualStyleBackColor = False
        '
        'frmBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 640)
        Me.Controls.Add(Me.btnCarro)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.lblIngreseTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBuscador"
        Me.Text = "frmBuscador"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIngreseTxt As Label
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCarro As Button
End Class
