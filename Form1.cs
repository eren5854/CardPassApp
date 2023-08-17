using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace CardPassApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string imageUrl = null;
        private string cardId;
        SerialPort serialPort1;
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RPEDS99\SQLEXPRESS;Initial Catalog=CardPassDb;Integrated Security=True");
        SqlCommand sqlCommand;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(630, 300);
            pnlRegister.Visible = false;
            tblPnl.Visible = true;
            try
            {
                serialPort1 = new SerialPort("COM3");
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Port is not read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                Application.Exit();
            }
            timer1.Interval = 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                cardId = serialPort1.ReadExisting().ToString();
                if (cardId != "")
                {
                    txtCardId.Text = cardId;
                }
            }
            catch
            {
                timer1.Stop(); MessageBox.Show("Not Connect RFID Reader!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Try();
            }
        }

        void Try()
        {
            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("Please check COM Port !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Navigation
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTÝON = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void pnlNavi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTÝON, 0);
            }
        }
        #endregion

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            long c = Convert.ToInt64(txtCardId.Text);
            if (txtName.Text != "" && txtLastname.Text != "" && txtStudentNo.Text != "" && txtCardId.Text != "")
            {
                try
                {
                    connection.Open();
                    sqlCommand = new("UPDATE Students SET FirstName = @p1, LastName = @p2, Card = @p3 WHERE StudentNo = @p4", connection);
                    sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", txtLastname.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", Convert.ToString(c));
                    sqlCommand.Parameters.AddWithValue("@p4", txtStudentNo.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Register Update", "Update Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sql Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else MessageBox.Show("Please fill out all fields!");
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblPnl.Visible = false;
            pnlRegister.Visible = true;
            txtName.Clear();
            txtLastname.Clear();
            txtStudentNo.Clear();
            txtCardId.Clear();
            pictureBox2.Visible = false;
        }

        private void cardReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tblPnl.Visible = true;
            pnlRegister.Visible = false;
            txtCardId.Text = "";
        }

        private void txtCardId_TextChanged(object sender, EventArgs e)
        {
            string id;
            string firstName;
            string lastName;
            string studentNo;
            string card = "";
            string photo;
            try
            {
                connection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM Students WHERE Card = " + txtCardId.Text, connection);
                SqlDataReader read = sqlCommand.ExecuteReader();
                if (read.Read())
                {
                    id = read[0].ToString();
                    firstName = read[1].ToString();
                    lastName = read[2].ToString();
                    studentNo = read[3].ToString();
                    card = read[4].ToString();
                    photo = read[5].ToString();

                    dgList.ColumnCount = 4;
                    dgList.Columns[0].Name = "Name";
                    dgList.Columns[1].Name = "Lastname";
                    dgList.Columns[1].Width = 75;
                    dgList.Columns[2].Name = "Student No";
                    dgList.Columns[2].Width = 80;
                    dgList.Columns[3].Name = "Card Id";
                    dgList.Columns[3].Width = 120;
                    dgList.Rows.Add(firstName, lastName, studentNo, card);
                    lbCardStatus.Text = "Access";
                    btnAccessColor.BackColor = Color.DarkGreen;
                    pictureBox1.Visible = true;
                    byte[] imageData = (byte[])read[5];
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                {
                    lbCardStatus.Text = "Access Denied";
                    btnAccessColor.BackColor = Color.DarkRed;
                    pictureBox1.Visible = false;
                }
            }
            catch
            {
                //MessageBox.Show("Sql Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtLastname.Text != "" && txtStudentNo.Text != "" && txtCardId.Text != "")
            {
                long c = Convert.ToInt64(txtCardId.Text);
                connection.Open();
                try
                {
                    sqlCommand = new("Select * From Students WHERE Card = " + txtCardId.Text, connection);
                    SqlDataReader sqlDR = sqlCommand.ExecuteReader();
                    if (sqlDR.Read())
                    {
                        MessageBox.Show("This card ID alredy exist!");
                    }
                    else
                    {
                        sqlDR.Close();
                        sqlCommand = new SqlCommand("INSERT INTO Students(FirstName, LastName, StudentNo, Card, Photo, PhotoUrl) values(@p1, @p2, @p3, @p4, @p5, @p6)", connection);
                        sqlCommand.Parameters.AddWithValue("@p1", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", txtLastname.Text);
                        sqlCommand.Parameters.AddWithValue("@p3", txtStudentNo.Text);
                        sqlCommand.Parameters.AddWithValue("@p4", Convert.ToString(c));
                        sqlCommand.Parameters.AddWithValue("@p6", imageUrl);
                        MemoryStream stream = new MemoryStream();
                        pictureBox2.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] img = stream.ToArray();
                        sqlCommand.Parameters.AddWithValue("@p5", img);

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("New Register Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Sql Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

            }
            else MessageBox.Show("Please fill out all fields!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                sqlCommand = new("DELETE FROM Students WHERE StudentNo = @p1", connection);
                sqlCommand.Parameters.AddWithValue("@p1", txtStudentNo.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete Succes");
            }
            catch
            {
                MessageBox.Show("Sql Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}