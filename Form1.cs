// Decompiled with JetBrains decompiler
// Type: Elit_hesap_makinesi.Form1
// Assembly: Elit hesap makinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4D6C8C5-93B8-4BF1-B625-A1B6B24F84F4
// Assembly location: C:\Users\Administrator\Downloads\Kucuk_hesap_makinesi.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Elit_hesap_makinesi
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Label label1;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button11;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private GroupBox groupBox1;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label7;
    private Button button12;

    public Form1() => this.InitializeComponent();

    private void button3_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Convert.ToDouble(this.textBox2.Text) * Convert.ToDouble(this.textBox1.Text));

    private void groupBox1_Enter(object sender, EventArgs e) => this.groupBox1.Text = "selam";

    private void button1_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Convert.ToDouble(this.textBox2.Text) + Convert.ToDouble(this.textBox1.Text));

    private void button2_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Convert.ToDouble(this.textBox2.Text) - Convert.ToDouble(this.textBox1.Text));

    private void button4_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Convert.ToDouble(this.textBox2.Text) / Convert.ToDouble(this.textBox1.Text));

    private void button5_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Pow(Convert.ToDouble(this.textBox2.Text), Convert.ToDouble(this.textBox1.Text)));

    private void button6_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(this.textBox2.Text)));

    private void button9_Click(object sender, EventArgs e)
    {
      double num1 = Convert.ToDouble(this.textBox2.Text);
      double num2 = 1.0;
      for (double num3 = 1.0; num3 < num1; ++num3)
        num2 *= num3;
      this.label6.Text = Convert.ToString(num1 * num2);
    }

    private void button10_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Log(Convert.ToDouble(this.textBox2.Text)));

    private void button11_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Sin(Math.PI * Convert.ToDouble(this.textBox2.Text) / 180.0));

    private void button7_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Cos(Math.PI * Convert.ToDouble(this.textBox2.Text) / 180.0));

    private void button8_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Tan(Math.PI * Convert.ToDouble(this.textBox2.Text) / 180.0));

    private void button12_Click(object sender, EventArgs e) => this.label6.Text = Convert.ToString(Math.Log10(Convert.ToDouble(this.textBox2.Text)));

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.label1 = new Label();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.button9 = new Button();
      this.button10 = new Button();
      this.button11 = new Button();
      this.label2 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.groupBox1 = new GroupBox();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.button12 = new Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.button1.Location = new Point(293, 21);
      this.button1.Name = "button1";
      this.button1.Size = new Size(33, 28);
      this.button1.TabIndex = 0;
      this.button1.Text = "+";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(293, 55);
      this.button2.Name = "button2";
      this.button2.Size = new Size(33, 28);
      this.button2.TabIndex = 1;
      this.button2.Text = "-";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(293, 89);
      this.button3.Name = "button3";
      this.button3.Size = new Size(33, 28);
      this.button3.TabIndex = 2;
      this.button3.Text = "x";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(292, 123);
      this.button4.Name = "button4";
      this.button4.Size = new Size(34, 28);
      this.button4.TabIndex = 3;
      this.button4.Text = "÷";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Location = new Point(212, 157);
      this.button5.Name = "button5";
      this.button5.Size = new Size(34, 28);
      this.button5.TabIndex = 4;
      this.button5.Text = "^";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 16);
      this.label1.MaximumSize = new Size(500, 500);
      this.label1.Name = "label1";
      this.label1.Size = new Size(34, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "1.sayı";
      this.button6.Location = new Point(172, 157);
      this.button6.Name = "button6";
      this.button6.Size = new Size(34, 28);
      this.button6.TabIndex = 7;
      this.button6.Text = "√";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.Location = new Point(54, 157);
      this.button7.Name = "button7";
      this.button7.Size = new Size(33, 29);
      this.button7.TabIndex = 8;
      this.button7.Text = "Cos";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.Location = new Point(93, 157);
      this.button8.Name = "button8";
      this.button8.Size = new Size(34, 28);
      this.button8.TabIndex = 9;
      this.button8.Text = "Tan";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button9.Location = new Point(133, 157);
      this.button9.Name = "button9";
      this.button9.Size = new Size(33, 28);
      this.button9.TabIndex = 0;
      this.button9.Text = "!";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button10.Location = new Point(252, 157);
      this.button10.Name = "button10";
      this.button10.Size = new Size(34, 28);
      this.button10.TabIndex = 10;
      this.button10.Text = "In";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.button11.Location = new Point(16, 157);
      this.button11.Name = "button11";
      this.button11.Size = new Size(32, 29);
      this.button11.TabIndex = 11;
      this.button11.Text = "Sin";
      this.button11.UseVisualStyleBackColor = true;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(6, 45);
      this.label2.Name = "label2";
      this.label2.Size = new Size(34, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "2.sayı";
      this.textBox1.Location = new Point(51, 42);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(179, 20);
      this.textBox1.TabIndex = 14;
      this.textBox2.Location = new Point(51, 16);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(179, 20);
      this.textBox2.TabIndex = 15;
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.textBox2);
      this.groupBox1.Controls.Add((Control) this.textBox1);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Location = new Point(16, 21);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(270, 130);
      this.groupBox1.TabIndex = 17;
      this.groupBox1.TabStop = false;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(6, 76);
      this.label4.Name = "label4";
      this.label4.Size = new Size(38, 13);
      this.label4.TabIndex = 18;
      this.label4.Text = "Sonuç";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(35, 92);
      this.label5.Name = "label5";
      this.label5.Size = new Size(13, 13);
      this.label5.TabIndex = 19;
      this.label5.Text = "=";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(74, 102);
      this.label6.Name = "label6";
      this.label6.Size = new Size(0, 13);
      this.label6.TabIndex = 20;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(22, 9);
      this.label7.Name = "label7";
      this.label7.Size = new Size(282, 13);
      this.label7.TabIndex = 18;
      this.label7.Text = "Tek sayı gerektiren işlemlerde esas alınacak sayı 1. sayıdır.";
      this.button12.Location = new Point(292, 157);
      this.button12.Name = "button12";
      this.button12.Size = new Size(34, 28);
      this.button12.TabIndex = 19;
      this.button12.Text = "Log";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(192, (int) byte.MaxValue, (int) byte.MaxValue);
      this.ClientSize = new Size(350, 201);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button11);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = "Hesap Makinesi";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
