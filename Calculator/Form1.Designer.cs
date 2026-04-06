namespace Calculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        txtDisplay = new TextBox();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btn0 = new Button();
        btnDot = new Button();
        btnDivide = new Button();
        btnMultiply = new Button();
        btnSubtract = new Button();
        btnAdd = new Button();
        btnEquals = new Button();
        btnClear = new Button();
        btnBackspace = new Button();
        SuspendLayout();

        // Display
        txtDisplay.BackColor = System.Drawing.Color.White;
        txtDisplay.ForeColor = System.Drawing.Color.Black;
        txtDisplay.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular);
        txtDisplay.Location = new System.Drawing.Point(12, 12);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.ReadOnly = true;
        txtDisplay.Size = new System.Drawing.Size(306, 48);
        txtDisplay.TabIndex = 0;
        txtDisplay.Text = "0";
        txtDisplay.TextAlign = HorizontalAlignment.Right;
        txtDisplay.BorderStyle = BorderStyle.FixedSingle;

        // Number buttons styling helper — light grey, black text
        // btn7
        btn7.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn7.FlatStyle = FlatStyle.Flat;
        btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn7.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn7.ForeColor = System.Drawing.Color.Black;
        btn7.Location = new System.Drawing.Point(12, 75);
        btn7.Name = "btn7";
        btn7.Size = new System.Drawing.Size(72, 55);
        btn7.TabIndex = 1;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = false;
        btn7.Click += digitButton_Click;

        // btn8
        btn8.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn8.FlatStyle = FlatStyle.Flat;
        btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn8.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn8.ForeColor = System.Drawing.Color.Black;
        btn8.Location = new System.Drawing.Point(88, 75);
        btn8.Name = "btn8";
        btn8.Size = new System.Drawing.Size(72, 55);
        btn8.TabIndex = 2;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = false;
        btn8.Click += digitButton_Click;

        // btn9
        btn9.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn9.FlatStyle = FlatStyle.Flat;
        btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn9.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn9.ForeColor = System.Drawing.Color.Black;
        btn9.Location = new System.Drawing.Point(164, 75);
        btn9.Name = "btn9";
        btn9.Size = new System.Drawing.Size(72, 55);
        btn9.TabIndex = 3;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = false;
        btn9.Click += digitButton_Click;

        // btn4
        btn4.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn4.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn4.ForeColor = System.Drawing.Color.Black;
        btn4.Location = new System.Drawing.Point(12, 134);
        btn4.Name = "btn4";
        btn4.Size = new System.Drawing.Size(72, 55);
        btn4.TabIndex = 4;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = false;
        btn4.Click += digitButton_Click;

        // btn5
        btn5.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn5.FlatStyle = FlatStyle.Flat;
        btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn5.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn5.ForeColor = System.Drawing.Color.Black;
        btn5.Location = new System.Drawing.Point(88, 134);
        btn5.Name = "btn5";
        btn5.Size = new System.Drawing.Size(72, 55);
        btn5.TabIndex = 5;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = false;
        btn5.Click += digitButton_Click;

        // btn6
        btn6.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn6.FlatStyle = FlatStyle.Flat;
        btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn6.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn6.ForeColor = System.Drawing.Color.Black;
        btn6.Location = new System.Drawing.Point(164, 134);
        btn6.Name = "btn6";
        btn6.Size = new System.Drawing.Size(72, 55);
        btn6.TabIndex = 6;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = false;
        btn6.Click += digitButton_Click;

        // btn1
        btn1.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn1.FlatStyle = FlatStyle.Flat;
        btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn1.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn1.ForeColor = System.Drawing.Color.Black;
        btn1.Location = new System.Drawing.Point(12, 193);
        btn1.Name = "btn1";
        btn1.Size = new System.Drawing.Size(72, 55);
        btn1.TabIndex = 7;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = false;
        btn1.Click += digitButton_Click;

        // btn2
        btn2.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn2.FlatStyle = FlatStyle.Flat;
        btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn2.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn2.ForeColor = System.Drawing.Color.Black;
        btn2.Location = new System.Drawing.Point(88, 193);
        btn2.Name = "btn2";
        btn2.Size = new System.Drawing.Size(72, 55);
        btn2.TabIndex = 8;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = false;
        btn2.Click += digitButton_Click;

        // btn3
        btn3.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn3.FlatStyle = FlatStyle.Flat;
        btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn3.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn3.ForeColor = System.Drawing.Color.Black;
        btn3.Location = new System.Drawing.Point(164, 193);
        btn3.Name = "btn3";
        btn3.Size = new System.Drawing.Size(72, 55);
        btn3.TabIndex = 9;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = false;
        btn3.Click += digitButton_Click;

        // btn0 (wide)
        btn0.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btn0.FlatStyle = FlatStyle.Flat;
        btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btn0.Font = new System.Drawing.Font("Segoe UI", 14F);
        btn0.ForeColor = System.Drawing.Color.Black;
        btn0.Location = new System.Drawing.Point(12, 252);
        btn0.Name = "btn0";
        btn0.Size = new System.Drawing.Size(148, 55);
        btn0.TabIndex = 10;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = false;
        btn0.Click += digitButton_Click;

        // btnDot
        btnDot.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
        btnDot.FlatStyle = FlatStyle.Flat;
        btnDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 210, 210);
        btnDot.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnDot.ForeColor = System.Drawing.Color.Black;
        btnDot.Location = new System.Drawing.Point(164, 252);
        btnDot.Name = "btnDot";
        btnDot.Size = new System.Drawing.Size(72, 55);
        btnDot.TabIndex = 11;
        btnDot.Text = ".";
        btnDot.UseVisualStyleBackColor = false;
        btnDot.Click += btnDot_Click;

        // Operator buttons — medium grey, black text
        // btnDivide
        btnDivide.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        btnDivide.FlatStyle = FlatStyle.Flat;
        btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnDivide.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnDivide.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnDivide.Location = new System.Drawing.Point(240, 75);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new System.Drawing.Size(78, 55);
        btnDivide.TabIndex = 12;
        btnDivide.Text = "÷";
        btnDivide.UseVisualStyleBackColor = false;
        btnDivide.Click += btnDivide_Click;

        // btnMultiply
        btnMultiply.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        btnMultiply.FlatStyle = FlatStyle.Flat;
        btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnMultiply.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnMultiply.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnMultiply.Location = new System.Drawing.Point(240, 134);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new System.Drawing.Size(78, 55);
        btnMultiply.TabIndex = 13;
        btnMultiply.Text = "×";
        btnMultiply.UseVisualStyleBackColor = false;
        btnMultiply.Click += btnMultiply_Click;

        // btnSubtract
        btnSubtract.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        btnSubtract.FlatStyle = FlatStyle.Flat;
        btnSubtract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnSubtract.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnSubtract.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnSubtract.Location = new System.Drawing.Point(240, 193);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new System.Drawing.Size(78, 55);
        btnSubtract.TabIndex = 14;
        btnSubtract.Text = "−";
        btnSubtract.UseVisualStyleBackColor = false;
        btnSubtract.Click += btnSubtract_Click;

        // btnAdd
        btnAdd.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnAdd.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnAdd.Location = new System.Drawing.Point(240, 252);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(78, 55);
        btnAdd.TabIndex = 15;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;

        // btnEquals — dark grey, white text (accent)
        btnEquals.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
        btnEquals.FlatStyle = FlatStyle.Flat;
        btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
        btnEquals.Font = new System.Drawing.Font("Segoe UI", 14F);
        btnEquals.ForeColor = System.Drawing.Color.White;
        btnEquals.Location = new System.Drawing.Point(240, 311);
        btnEquals.Name = "btnEquals";
        btnEquals.Size = new System.Drawing.Size(78, 55);
        btnEquals.TabIndex = 16;
        btnEquals.Text = "=";
        btnEquals.UseVisualStyleBackColor = false;
        btnEquals.Click += btnEquals_Click;

        // btnClear — light grey, dark text
        btnClear.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnClear.Font = new System.Drawing.Font("Segoe UI", 13F);
        btnClear.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnClear.Location = new System.Drawing.Point(12, 311);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(148, 55);
        btnClear.TabIndex = 17;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;

        // btnBackspace
        btnBackspace.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
        btnBackspace.FlatStyle = FlatStyle.Flat;
        btnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 190, 190);
        btnBackspace.Font = new System.Drawing.Font("Segoe UI", 13F);
        btnBackspace.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        btnBackspace.Location = new System.Drawing.Point(164, 311);
        btnBackspace.Name = "btnBackspace";
        btnBackspace.Size = new System.Drawing.Size(72, 55);
        btnBackspace.TabIndex = 18;
        btnBackspace.Text = "⌫";
        btnBackspace.UseVisualStyleBackColor = false;
        btnBackspace.Click += btnBackspace_Click;

        // Form
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        ClientSize = new System.Drawing.Size(330, 378);
        Controls.Add(txtDisplay);
        Controls.Add(btn7);
        Controls.Add(btn8);
        Controls.Add(btn9);
        Controls.Add(btn4);
        Controls.Add(btn5);
        Controls.Add(btn6);
        Controls.Add(btn1);
        Controls.Add(btn2);
        Controls.Add(btn3);
        Controls.Add(btn0);
        Controls.Add(btnDot);
        Controls.Add(btnDivide);
        Controls.Add(btnMultiply);
        Controls.Add(btnSubtract);
        Controls.Add(btnAdd);
        Controls.Add(btnEquals);
        Controls.Add(btnClear);
        Controls.Add(btnBackspace);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtDisplay;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btn0;
    private Button btnDot;
    private Button btnDivide;
    private Button btnMultiply;
    private Button btnSubtract;
    private Button btnAdd;
    private Button btnEquals;
    private Button btnClear;
    private Button btnBackspace;
}
