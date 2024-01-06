using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;


namespace School_Management_System
{
    public partial class Fee_Management : MaterialForm
    {
        string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";



        public Fee_Management()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey700, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE
                );

                        this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Fee_Management_Load(object sender, EventArgs e)
        {
            LoadPaymentIDsIntoComboBox();
        }

        private void LoadPaymentIDsIntoComboBox()
        {
            cmb_mg_fepayid.Items.Clear();


            List<string> paymentIDs = GetPaymentIDsFromDatabase();

            cmb_mg_fepayid.Items.AddRange(paymentIDs.ToArray());



            cmb_stdid.Items.Clear();


            List<string> studentIDs = GetStudentIDsFromDatabase();

            cmb_stdid.Items.AddRange(studentIDs.ToArray());




        }


        private List<string> GetStudentIDsFromDatabase()
        {
            List<string> studentIDs = new List<string>();

            // Replace the following connection string with your actual database connection string
            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT student_id FROM students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Assuming the student_id column is of type string
                            string studentID = reader["student_id"].ToString();
                            studentIDs.Add(studentID);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return studentIDs;
        }



        private List<string> GetPaymentIDsFromDatabase()
        {
            List<string> paymentIDs = new List<string>();

            // Replace the following connection string with your actual database connection string
            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT payment_id FROM payments";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Assuming the payment_id column is of type string
                            string paymentID = reader["payment_id"].ToString();
                            paymentIDs.Add(paymentID);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return paymentIDs;
        }



        private void btn_mg_fesubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {

                Payment newPayment = new Payment
                {



                    StudentID = int.Parse(cmb_stdid.Text),
                    PayDate = dt_mg_fepaydate.Value,
                    PaymentMethod = cmb_mg_fepaymethod.Text,
                    StudentName = txt_mg_fedname.Text,
                    Grade = txt_mg_fegrade.Text,
                    ClassName = txt_mg_feeclass.Text,
                    FeeType = cmb_mg_fetype.Text,
                    Amount = int.Parse(txt_mg_feamount.Text),
                    DueDate = dt_mg_feduedate.Value,
                    Paid = ch_paid.Checked ? "Paid" : "Not Paid"

                };

                InsertPaymentData(newPayment);

                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPaymentIDsIntoComboBox();
                // Optionally, clear the form after adding the student
                ClearForm();

            }


        }

        private void ClearForm()
        {
            // Clear the textboxes, datetimepicker, and radio buttons
            dt_mg_fepaydate.Value = DateTime.Today;
            cmb_mg_fepaymethod.Text = "";
            txt_mg_fedname.Text = "";
            txt_mg_fegrade.Text = "";
            txt_mg_feeclass.Text = "";
            cmb_mg_fetype.Text = "";
            txt_mg_feamount.Text = "";
            dt_mg_feduedate.Value = DateTime.Today;
            ch_paid.Checked = false;
            
        }

        private void InsertPaymentData(Payment payment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Example query (assuming you have a SqlConnection named 'connection'):
                string query = "INSERT INTO payments (payment_date, payment_method, student_id, student_name, grade, class_name, fee_type, amount, payment_status,due_date) " +
                "VALUES (@PayDate, @PaymentMethod, @StudentID, @StudentName, @Grade, @ClassName, @FeeType, @Amount, @Paid, @DueDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PayDate", payment.PayDate);
                    command.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod);
                    command.Parameters.AddWithValue("@StudentID", payment.StudentID);
                    command.Parameters.AddWithValue("@StudentName", payment.StudentName);
                    command.Parameters.AddWithValue("@Grade", payment.Grade);
                    command.Parameters.AddWithValue("@ClassName", payment.ClassName);
                    command.Parameters.AddWithValue("@FeeType", payment.FeeType);
                    command.Parameters.AddWithValue("@Amount", payment.Amount);
                    command.Parameters.AddWithValue("@Paid", payment.Paid);
                    command.Parameters.AddWithValue("@DueDate", payment.DueDate);

                    command.ExecuteNonQuery();
                }
            }

        }


        private void btn_mg_fesearch_Click(object sender, EventArgs e)
        {
           

            if (cmb_mg_fepayid.SelectedItem != null)
            {
                // Assuming PaymentID is of type int
                if (int.TryParse(cmb_mg_fepayid.SelectedItem.ToString(), out int selectedPaymentID))
                {
                    // Fetch data for the selected payment ID
                    Payment selectedPayment = GetPaymentData(selectedPaymentID);

                    // Display the data in the text fields
                    DisplayPaymentData(selectedPayment);
                }
                else
                {
                    MessageBox.Show("Invalid Payment ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Payment ID before searching.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Payment GetPaymentData(int paymentID)
        {
            Payment payment = new Payment();

            string connectionString = "Data Source=DESKTOP-MGE1LM5;Initial Catalog=SMS;Integrated Security=True";
            string query = "SELECT * FROM payments WHERE payment_id = @PaymentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter param = new SqlParameter("@PaymentID", SqlDbType.Int);
                    param.Value = paymentID;
                    command.Parameters.Add(param);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            payment.PaymentID = (int)reader["payment_id"];
                            payment.PaymentMethod = GetValueOrDefault<string>(reader, "payment_method");
                            payment.StudentName = GetValueOrDefault<string>(reader, "student_name");
                            payment.Grade = GetValueOrDefault<string>(reader, "grade");
                            payment.ClassName = GetValueOrDefault<string>(reader, "class_name");
                            payment.StudentID = GetValueOrDefault<int>(reader, "student_id");

                            payment.FeeType = GetValueOrDefault<string>(reader, "fee_type");
                            payment.Amount = (int)reader["amount"];
                            payment.Paid = GetValueOrDefault<string>(reader, "payment_status");

                            // Handle DBNull for DateTime fields
                            object payDate = reader["payment_date"];
                            payment.PayDate = DBNull.Value.Equals(payDate) ? DateTime.MinValue : (DateTime)payDate;

                            object dueDate = reader["due_date"];
                            payment.DueDate = DBNull.Value.Equals(dueDate) ? DateTime.MinValue : (DateTime)dueDate;

                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}\nQuery: {query}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return payment;
        }
        private T GetValueOrDefault<T>(SqlDataReader reader, string columnName)
        {
            return reader[columnName] is T value ? value : default(T);
        }



        private void DisplayPaymentData(Payment payment)

        {

            // Display the student data in the text fields

            cmb_mg_fepaymethod.Text = payment.PaymentMethod;
            txt_mg_fedname.Text = payment.StudentName;
            txt_mg_fegrade.Text = payment.Grade;
            txt_mg_feeclass.Text = payment.ClassName;
            cmb_mg_fetype.Text = payment.FeeType;
            if (payment.PayDate != DateTime.MinValue)
            {
                dt_mg_fepaydate.Value = payment.PayDate;
            }
            if (payment.DueDate != DateTime.MinValue)
            {
                dt_mg_feduedate.Value = payment.DueDate;
            }

            txt_mg_feamount.Text = payment.Amount.ToString();

            ch_paid.Text = payment.Paid;


            if (string.Equals(payment.Paid, "Paid", StringComparison.OrdinalIgnoreCase))
            {
                ch_paid.Checked = true;
                
            }
            else if (string.Equals(payment.Paid, "Not Paid", StringComparison.OrdinalIgnoreCase))
            {
                ch_paid.Checked = false;
            }
            else
            {
                // Handle other cases if needed
                ch_paid.Checked = false;
                ch_paid.Checked = false;
            }




        }

        private void btnviewpaidstd_Click(object sender, EventArgs e)
        {
            View_Paid_Students viewpdstd = new View_Paid_Students();
            viewpdstd.Show();
        }
        /*--------------------------------------VALIDATION---------------------------------------------------*/
        private bool ValidateInputs()
        {
            if (cmb_stdid.SelectedItem == null || string.IsNullOrWhiteSpace(cmb_mg_fepaymethod.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_fedname.Text) || string.IsNullOrWhiteSpace(txt_mg_fegrade.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_feeclass.Text) || string.IsNullOrWhiteSpace(cmb_mg_fetype.Text) ||
                string.IsNullOrWhiteSpace(txt_mg_feamount.Text))
            {
                MessageBox.Show("Please input/select all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /*---------------------------------------------------------------------------------------------------*/

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
