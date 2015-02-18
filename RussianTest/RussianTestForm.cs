using System;
using System.Drawing;
using System.Windows.Forms;

namespace RussianTest
{
    public partial class RussianTestForm : Form
    {
        private int currentQuestion = 0;
        private CheckBox[] checkBoxArray;
        private Test test;
        private string fileName = "Questions.qsn";
        private int counter;
        private string greeting = "Здравствуйте! \n Предлагаем Вам пройти тест по русскому языку. \n Здесь вы найдете вопросы, посвященные произношению и употреблению слов.";
        private string end = "Вопросы закончились! \n Посмотрите на Ваши результаты: \n ";

        public RussianTestForm()
        {
            InitializeComponent();

            checkBoxArray = new CheckBox[10];
            for (int i = 0; i < 10; i++)
            {
                checkBoxArray[i] = new CheckBox();
                checkBoxArray[i].CheckedChanged += new EventHandler(CheckBoxChecked);
            }
            this.SetSettings();
        }

        private void SetSettings()
        {
            this.labelGreeting.Text = greeting;
            //int size = 170;
            //this.panelQuestion.Height = this.Height - size;
            //this.panelQuestion.Width = this.Width - size;
        }

        private void Redraw()
        {
            this.panelQuestion.Invalidate();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?",
                "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.test = new Test(fileName);
            currentQuestion = 0;
            Start();
            CreateResponces();
            this.Redraw();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
            CreateResponces();
            Redraw();
        }

        private void Start()
        {
            buttonStart.Visible = false;
            this.labelGreeting.Visible = false;
            this.panelQuestion.Visible = true;
            this.test = new Test(fileName);
            this.labelQuestion.Text = test[1].ToString();
            buttonNextQuestion.Enabled = false;
            counter = 0;
            this.NewToolStripMenuItem.Enabled = true;
        }

        private void CheckBoxChecked(object sender, EventArgs e)
        {
            this.buttonNextQuestion.Enabled = ((CheckBox)sender).Checked;
        }

        private void panelQuestion_Paint(object sender, PaintEventArgs e)
        {
            this.labelQuestion.Text = test[currentQuestion].ToString();
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.test[currentQuestion].CountOfResponces; i++)
                if (this.checkBoxArray[i].Checked && this.test[currentQuestion].IsRight(i + 1)) 
                    counter++;

            if (++currentQuestion < test.Length)
                CreateResponces();
            else
            {
                this.labelGreeting.Visible = true;
                this.panelQuestion.Visible = false;
                double result = ((double)((double)counter / (double)test.CountOfRightResponces)) * 100;
                this.labelGreeting.Text = end + result + "% правильных ответов. \n ";
                if (result > 90)
                    this.labelGreeting.Text += "Вы прекрасно справились с тестовыми заданиями! Поздравляем!";
                if (result <= 90 && result > 65)
                    this.labelGreeting.Text += "Вы довольно неплохо справились с тестовыми заданиями! Поздравляем! \n Возможно в следующий раз Вы сможете ответить на большее количество вопросов.";
                if (result <= 65 && result > 35)
                    this.labelGreeting.Text += "Вы справились не очень хорошо. \n Возможно стоит заняться изучением произношения и употребления слов в разных ситуациях.";
                if (result <= 35)
                    this.labelGreeting.Text += "К сожалению, на большинство вопросов вы ответили неправильно. \n Вам стоит подумать о занятиях русским языком.";
            }

            this.Redraw();
        }

        private void DeleteResponces()
        {
            for (int i = 0; i < this.panelAnswers.Controls.Count; )
                if (this.panelAnswers.Controls[i] is CheckBox)
                    this.panelAnswers.Controls.RemoveAt(i);
                else
                    i++;
        }

        private void CreateResponces()
        {
            this.DeleteResponces();
            int i;
            for (i = 0; i < test[currentQuestion].CountOfResponces; i++)
            {
                checkBoxArray[i].AutoSize = false;
                checkBoxArray[i].Location = new Point(12, 51);
                checkBoxArray[i].Text = test[currentQuestion][i];
                checkBoxArray[i].Top = i * 25;
                checkBoxArray[i].Visible = true;
                checkBoxArray[i].Size = new System.Drawing.Size(500, 25);
                checkBoxArray[i].Checked = false;
                this.panelAnswers.Controls.Add(checkBoxArray[i]);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Кучина Ольга и Афанасов Иван гр 8405", "Авторы",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}