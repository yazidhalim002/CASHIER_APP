<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.list = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.orders = New System.Windows.Forms.ListBox()
        Me.ONCE = New System.Windows.Forms.Button()
        Me.TWICE = New System.Windows.Forms.Button()
        Me.THIRD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.list.FormattingEnabled = True
        Me.list.ItemHeight = 21
        Me.list.Items.AddRange(New Object() {"jus d'orange", "jus de peche", "jus de panachi", "cafée cream", "caféé au lait", "lait au chocolat", "cafée italy", "lavazza", "cafée glassée", "chocolat chaude", "boisson gazeux", "crépe", "macaron", "croissant", "schneck"})
        Me.list.Location = New System.Drawing.Point(42, 51)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(199, 340)
        Me.list.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Extra Bold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "************ ESPACE GI ************"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(634, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 78)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CHECKOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'orders
        '
        Me.orders.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.orders.FormattingEnabled = True
        Me.orders.ItemHeight = 23
        Me.orders.Location = New System.Drawing.Point(616, 51)
        Me.orders.Name = "orders"
        Me.orders.Size = New System.Drawing.Size(220, 349)
        Me.orders.TabIndex = 3
        '
        'ONCE
        '
        Me.ONCE.Font = New System.Drawing.Font("Rockwell Extra Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ONCE.Location = New System.Drawing.Point(342, 64)
        Me.ONCE.Name = "ONCE"
        Me.ONCE.Size = New System.Drawing.Size(202, 78)
        Me.ONCE.TabIndex = 4
        Me.ONCE.Text = "x 1"
        Me.ONCE.UseVisualStyleBackColor = True
        '
        'TWICE
        '
        Me.TWICE.Font = New System.Drawing.Font("Rockwell Extra Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TWICE.Location = New System.Drawing.Point(342, 181)
        Me.TWICE.Name = "TWICE"
        Me.TWICE.Size = New System.Drawing.Size(202, 78)
        Me.TWICE.TabIndex = 5
        Me.TWICE.Text = "x 2"
        Me.TWICE.UseVisualStyleBackColor = True
        '
        'THIRD
        '
        Me.THIRD.Font = New System.Drawing.Font("Rockwell Extra Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.THIRD.Location = New System.Drawing.Point(342, 299)
        Me.THIRD.Name = "THIRD"
        Me.THIRD.Size = New System.Drawing.Size(202, 78)
        Me.THIRD.TabIndex = 6
        Me.THIRD.Text = "x 3"
        Me.THIRD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PRICE :"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.price.Location = New System.Drawing.Point(196, 424)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(0, 29)
        Me.price.TabIndex = 8
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Rockwell Extra Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DELETE.Location = New System.Drawing.Point(342, 406)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(202, 78)
        Me.DELETE.TabIndex = 9
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 492)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.THIRD)
        Me.Controls.Add(Me.TWICE)
        Me.Controls.Add(Me.ONCE)
        Me.Controls.Add(Me.orders)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list)
        Me.Name = "Form1"
        Me.Text = "ESPACE GI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents list As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents orders As ListBox
    Friend WithEvents ONCE As Button
    Friend WithEvents TWICE As Button
    Friend WithEvents THIRD As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents price As Label
    Friend WithEvents DELETE As Button
End Class
