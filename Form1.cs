using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  public class Form1 : Form
  {
    private const int _offset = 902594;
    private IContainer components;
    private Button button1;
    private TextBox textBox1;
    private Button button2;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.FileName = "gs";
      if (openFileDialog.ShowDialog() == DialogResult.OK && File.Exists(openFileDialog.FileName) && new FileInfo(openFileDialog.FileName).Length > 11244224L)
      {
        this.textBox1.Text = openFileDialog.FileName;
        using (BinaryReader binaryReader = new BinaryReader((Stream) File.Open(this.textBox1.Text, FileMode.Open)))
        {
          binaryReader.BaseStream.Seek(11244276L, SeekOrigin.Begin);
          this.textBox2.Text = binaryReader.ReadSingle().ToString();
          this.textBox3.Text = binaryReader.ReadSingle().ToString();
          this.textBox4.Text = binaryReader.ReadSingle().ToString();
          this.textBox5.Text = binaryReader.ReadSingle().ToString();
          this.textBox6.Text = binaryReader.ReadSingle().ToString();
          this.textBox7.Text = binaryReader.ReadSingle().ToString();
          this.textBox8.Text = binaryReader.ReadSingle().ToString();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Ошибка операции, возможно вы выбрали неверный файл");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBox1.Text))
        return;
      float result;
      if (float.TryParse(this.textBox2.Text, out result) && float.TryParse(this.textBox3.Text, out result) && (float.TryParse(this.textBox4.Text, out result) && float.TryParse(this.textBox5.Text, out result)) && (float.TryParse(this.textBox6.Text, out result) && float.TryParse(this.textBox7.Text, out result) && float.TryParse(this.textBox8.Text, out result)))
      {
        using (FileStream fileStream = File.Open(this.textBox1.Text, FileMode.Open))
        {
          fileStream.Seek(902594L, SeekOrigin.Begin);
          fileStream.ReadByte();
          fileStream.Seek(-1L, SeekOrigin.Current);
          fileStream.WriteByte((byte) 235);
          fileStream.Seek(11244276L, SeekOrigin.Begin);
          BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream);
          binaryWriter.Write(float.Parse(this.textBox2.Text));
          binaryWriter.Write(float.Parse(this.textBox3.Text));
          binaryWriter.Write(float.Parse(this.textBox4.Text));
          binaryWriter.Write(float.Parse(this.textBox5.Text));
          binaryWriter.Write(float.Parse(this.textBox6.Text));
          binaryWriter.Write(float.Parse(this.textBox7.Text));
          binaryWriter.Write(float.Parse(this.textBox8.Text));
          int num = (int) MessageBox.Show("Файл успешно пропатчен");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Ошибка чтения рейтов, исправьте ошибку и повторите");
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.textBox1 = new TextBox();
      this.button2 = new Button();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.textBox8 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.SuspendLayout();
      this.button1.Location = new Point(174, 38);
      this.button1.Name = "button1";
      this.button1.Size = new Size(135, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Open";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox1.Enabled = false;
      this.textBox1.Location = new Point(12, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(297, 20);
      this.textBox1.TabIndex = 1;
      this.button2.Location = new Point(12, 38);
      this.button2.Name = "button2";
      this.button2.Size = new Size(156, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Patch";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox2.Location = new Point(12, 67);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 4;
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.textBox2.KeyDown += new KeyEventHandler(this.textBox2_KeyDown);
      this.textBox3.Location = new Point(12, 93);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(100, 20);
      this.textBox3.TabIndex = 5;
      this.textBox4.Location = new Point(12, 119);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(100, 20);
      this.textBox4.TabIndex = 6;
      this.textBox5.Location = new Point(12, 145);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(100, 20);
      this.textBox5.TabIndex = 7;
      this.textBox6.Location = new Point(12, 171);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(100, 20);
      this.textBox6.TabIndex = 8;
      this.textBox7.Location = new Point(12, 197);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(100, 20);
      this.textBox7.TabIndex = 9;
      this.textBox8.Location = new Point(12, 223);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(100, 20);
      this.textBox8.TabIndex = 10;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(118, 70);
      this.label1.Name = "label1";
      this.label1.Size = new Size(25, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Exp";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(118, 96);
      this.label2.Name = "label2";
      this.label2.Size = new Size(20, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Sp";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(118, 122);
      this.label3.Name = "label3";
      this.label3.Size = new Size(32, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Items";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(118, 148);
      this.label4.Name = "label4";
      this.label4.Size = new Size(39, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "Money";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(118, 174);
      this.label5.Name = "label5";
      this.label5.Size = new Size(49, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "TaskExp";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(119, 200);
      this.label6.Name = "label6";
      this.label6.Size = new Size(44, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "TaskSp";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(118, 226);
      this.label7.Name = "label7";
      this.label7.Size = new Size(63, 13);
      this.label7.TabIndex = 17;
      this.label7.Text = "TaskMoney";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(216, 230);
      this.label8.Name = "label8";
      this.label8.Size = new Size(92, 13);
      this.label8.TabIndex = 18;
      this.label8.Text = "by Сase and jkpro";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(326, 260);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.textBox7);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button1);
      this.MaximumSize = new Size(342, 299);
      this.MinimumSize = new Size(342, 299);
      this.Name = nameof (Form1);
      this.Text = "Rate and generator fix (1.5.1)";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
