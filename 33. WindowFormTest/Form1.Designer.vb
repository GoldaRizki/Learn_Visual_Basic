<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        DataGridView1 = New DataGridView()
        KolomId = New DataGridViewTextBoxColumn()
        KolomNama = New DataGridViewTextBoxColumn()
        KolomAlamat = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {KolomId, KolomNama, KolomAlamat})
        DataGridView1.Location = New Point(42, 261)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(718, 150)
        DataGridView1.TabIndex = 0
        ' 
        ' KolomId
        ' 
        KolomId.HeaderText = "Id"
        KolomId.Name = "KolomId"
        KolomId.ReadOnly = True
        KolomId.Visible = False
        ' 
        ' KolomNama
        ' 
        KolomNama.HeaderText = "Nama"
        KolomNama.Name = "KolomNama"
        KolomNama.ReadOnly = True
        ' 
        ' KolomAlamat
        ' 
        KolomAlamat.HeaderText = "Alamat"
        KolomAlamat.Name = "KolomAlamat"
        KolomAlamat.ReadOnly = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(560, 147)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15F)
        Button2.Location = New Point(42, 175)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 56)
        Button2.TabIndex = 2
        Button2.Text = "KELUAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KolomId As DataGridViewTextBoxColumn
    Friend WithEvents KolomNama As DataGridViewTextBoxColumn
    Friend WithEvents KolomAlamat As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
