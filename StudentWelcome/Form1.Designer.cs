namespace StudentWelcome;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblName = new Label();
        txtName = new TextBox();
        btnWelcome = new Button();
        lblMessage = new Label();
        SuspendLayout();
        //
        // lblName
        //
        lblName.AutoSize = true;
        lblName.Location = new Point(30, 35);
        lblName.Name = "lblName";
        lblName.Size = new Size(110, 20);
        lblName.TabIndex = 0;
        lblName.Text = "Student Name:";
        //
        // txtName
        //
        txtName.Location = new Point(150, 32);
        txtName.Name = "txtName";
        txtName.Size = new Size(200, 27);
        txtName.TabIndex = 1;
        //
        // btnWelcome
        //
        btnWelcome.Location = new Point(150, 75);
        btnWelcome.Name = "btnWelcome";
        btnWelcome.Size = new Size(120, 32);
        btnWelcome.TabIndex = 2;
        btnWelcome.Text = "Welcome";
        btnWelcome.UseVisualStyleBackColor = true;
        btnWelcome.Click += btnWelcome_Click;
        //
        // lblMessage
        //
        lblMessage.AutoSize = true;
        lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblMessage.Location = new Point(30, 130);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(0, 28);
        lblMessage.TabIndex = 3;
        //
        // Form1
        //
        AcceptButton = btnWelcome;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 190);
        Controls.Add(lblMessage);
        Controls.Add(btnWelcome);
        Controls.Add(txtName);
        Controls.Add(lblName);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Welcome";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblName;
    private TextBox txtName;
    private Button btnWelcome;
    private Label lblMessage;
}
