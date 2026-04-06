namespace Calculator;

public partial class Form1 : Form
{
    double num1 = 0;
    double num2 = 0;
    string operation = "";
    bool newInput = false;

    public Form1()
    {
        InitializeComponent();
    }

    private void digitButton_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        if (newInput)
        {
            txtDisplay.Text = btn.Text;
            newInput = false;
        }
        else
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Text = btn.Text;
            else
                txtDisplay.Text += btn.Text;
        }
    }

    private void btnDot_Click(object sender, EventArgs e)
    {
        if (!txtDisplay.Text.Contains("."))
        {
            txtDisplay.Text += ".";
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        num1 = double.Parse(txtDisplay.Text);
        operation = "+";
        newInput = true;
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
        num1 = double.Parse(txtDisplay.Text);
        operation = "-";
        newInput = true;
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
        num1 = double.Parse(txtDisplay.Text);
        operation = "*";
        newInput = true;
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        num1 = double.Parse(txtDisplay.Text);
        operation = "/";
        newInput = true;
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        num2 = double.Parse(txtDisplay.Text);
        double result = 0;

        if (operation == "+")
            result = num1 + num2;
        else if (operation == "-")
            result = num1 - num2;
        else if (operation == "*")
            result = num1 * num2;
        else if (operation == "/" && num2 != 0)
            result = num1 / num2;
        else
        {
            txtDisplay.Text = "Error";
            return;
        }

        txtDisplay.Text = result.ToString();
        newInput = true;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDisplay.Text = "0";
        num1 = 0;
        num2 = 0;
        operation = "";
        newInput = false;
    }

    private void btnBackspace_Click(object sender, EventArgs e)
    {
        if (txtDisplay.Text.Length > 1)
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        else
            txtDisplay.Text = "0";
    }
}
