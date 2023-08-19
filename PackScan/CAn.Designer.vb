<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CAn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAn))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stopbtn = New System.Windows.Forms.Button()
        Me.Snapbtn = New System.Windows.Forms.Button()
        Me.Aboubtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.namlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(35, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(530, 33)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "network interface card"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.BackgroundColor = System.Drawing.Color.White
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Data})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Location = New System.Drawing.Point(35, 254)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV.Size = New System.Drawing.Size(530, 270)
        Me.DGV.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 2177.023!
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 2099.527!
        Me.Column2.HeaderText = "Source"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 1949.759!
        Me.Column3.HeaderText = "Destination"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.FillWeight = 1065.99!
        Me.Column4.HeaderText = "Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Data
        '
        Me.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Data.FillWeight = 3207.701!
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Stopbtn
        '
        Me.Stopbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Stopbtn.BackColor = System.Drawing.Color.Transparent
        Me.Stopbtn.BackgroundImage = CType(resources.GetObject("Stopbtn.BackgroundImage"), System.Drawing.Image)
        Me.Stopbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stopbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Stopbtn.FlatAppearance.BorderSize = 0
        Me.Stopbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Stopbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Stopbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Stopbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stopbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stopbtn.ForeColor = System.Drawing.Color.White
        Me.Stopbtn.Location = New System.Drawing.Point(625, 40)
        Me.Stopbtn.Name = "Stopbtn"
        Me.Stopbtn.Size = New System.Drawing.Size(150, 50)
        Me.Stopbtn.TabIndex = 1
        Me.Stopbtn.Text = "stop"
        Me.Stopbtn.UseVisualStyleBackColor = False
        '
        'Snapbtn
        '
        Me.Snapbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Snapbtn.BackColor = System.Drawing.Color.Transparent
        Me.Snapbtn.BackgroundImage = CType(resources.GetObject("Snapbtn.BackgroundImage"), System.Drawing.Image)
        Me.Snapbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Snapbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Snapbtn.FlatAppearance.BorderSize = 0
        Me.Snapbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Snapbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Snapbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Snapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Snapbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Snapbtn.ForeColor = System.Drawing.Color.White
        Me.Snapbtn.Location = New System.Drawing.Point(625, 96)
        Me.Snapbtn.Name = "Snapbtn"
        Me.Snapbtn.Size = New System.Drawing.Size(150, 50)
        Me.Snapbtn.TabIndex = 2
        Me.Snapbtn.Text = "snapshot"
        Me.Snapbtn.UseVisualStyleBackColor = False
        '
        'Aboubtn
        '
        Me.Aboubtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Aboubtn.BackColor = System.Drawing.Color.Transparent
        Me.Aboubtn.BackgroundImage = CType(resources.GetObject("Aboubtn.BackgroundImage"), System.Drawing.Image)
        Me.Aboubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Aboubtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Aboubtn.FlatAppearance.BorderSize = 0
        Me.Aboubtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Aboubtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Aboubtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Aboubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aboubtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aboubtn.ForeColor = System.Drawing.Color.White
        Me.Aboubtn.Location = New System.Drawing.Point(625, 434)
        Me.Aboubtn.Name = "Aboubtn"
        Me.Aboubtn.Size = New System.Drawing.Size(150, 50)
        Me.Aboubtn.TabIndex = 4
        Me.Aboubtn.Text = "about"
        Me.Aboubtn.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.BackgroundImage = CType(resources.GetObject("Exitbtn.BackgroundImage"), System.Drawing.Image)
        Me.Exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Exitbtn.FlatAppearance.BorderSize = 0
        Me.Exitbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbtn.ForeColor = System.Drawing.Color.White
        Me.Exitbtn.Location = New System.Drawing.Point(625, 490)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(150, 50)
        Me.Exitbtn.TabIndex = 5
        Me.Exitbtn.Text = "exit"
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'namlbl
        '
        Me.namlbl.AutoSize = True
        Me.namlbl.BackColor = System.Drawing.Color.Transparent
        Me.namlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namlbl.ForeColor = System.Drawing.Color.White
        Me.namlbl.Location = New System.Drawing.Point(30, 547)
        Me.namlbl.Name = "namlbl"
        Me.namlbl.Size = New System.Drawing.Size(107, 25)
        Me.namlbl.TabIndex = 6
        Me.namlbl.Text = "CAn 2.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "by emg future technologies inc."
        '
        'CAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.namlbl)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Aboubtn)
        Me.Controls.Add(Me.Snapbtn)
        Me.Controls.Add(Me.Stopbtn)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.ComboBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CAn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PackAn"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stopbtn As System.Windows.Forms.Button
    Friend WithEvents Snapbtn As System.Windows.Forms.Button
    Friend WithEvents Aboubtn As System.Windows.Forms.Button
    Friend WithEvents Exitbtn As System.Windows.Forms.Button
    Friend WithEvents namlbl As Label
    Friend WithEvents Label1 As Label
End Class
