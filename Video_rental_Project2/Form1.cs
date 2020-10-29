using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_Project2
{
    public partial class Form1 : Form
    {
        //instance object of the data base class 
        SqlDataConnection obj = new SqlDataConnection();
        int Rental_ID = 0;
        int getData = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //method to get the cost of the video 
        public int getCost() {
            try {
                //get the year 
                int year = Convert.ToInt32(Video_year.Text.ToString());
                
                //dislay the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(year);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;

                }
                Video_cost.Text = "" + cost;
                return cost;
            }
            catch (Exception) {
                return 0;
            }
            
        }

        //check how much sample we have 
        public int chkSampleVideo(int M_Id) {
            //get the copies of the video 
            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Video where id=" + M_Id + "");
            int copies =Convert.ToInt32(dataTable.Rows[0]["Copies"].ToString());

            //get how much video is booked 

            dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Rental where M_Id="+M_Id+" and ReturnDate='booked'");
            if (dataTable.Rows.Count < copies)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

        //this method is used to count the booking of the cusotmer 
        public int chkMemberBooking(int C_Id) {
            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Rental where C_Id="+C_Id+" and ReturnDate='booked'");

            if (dataTable.Rows.Count < 2)
            {
                return 1;
            }
            else {
                return 0;
            }

        }
           
        private void add_cutomer_Click(object sender, EventArgs e)
        {
            //add_cutomer the record to the customer table 
            if (!customer_name.Text.ToString().Equals("") && !customer_email.Text.ToString().Equals("") && !customer_mobile.Text.ToString().Equals("") && !customer_address.Text.ToString().Equals(""))
            {
                String Query = "insert into tbl_Customer(Name,Email,Mobile,Address) values ('"+customer_name.Text +"','"+customer_email.Text+"','"+customer_mobile.Text+"','"+customer_address.Text+"')";
                obj.QueryOperation(Query);
                MessageBox.Show("Welcome you become the Member of our store");
            }
            else {
                MessageBox.Show("You must have to fill all details ");
            }
            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";
        }

        private void delete_customer_Click(object sender, EventArgs e)
        {
            if (!customer_ID.Text.ToString().Equals("")) {
                //delete the record of the member
                string deloperation = "delete from tbl_Customer where id="+Convert.ToInt32(customer_ID.Text.ToString())+"";
                obj.QueryOperation(deloperation);
                MessageBox.Show("Selected member is removed form the record ");


            }
            else {
                MessageBox.Show("Must have to seleect the Member to delete ");
            }

            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";

        }

        private void update_customer_Click(object sender, EventArgs e)
        {
            //update the record of the customer to manage his details 
            //add_cutomer the record to the customer table 
            if (!customer_ID.Text.ToString().Equals("") &&  !customer_name.Text.ToString().Equals("") && !customer_email.Text.ToString().Equals("") && !customer_mobile.Text.ToString().Equals("") && !customer_address.Text.ToString().Equals(""))
            {
                String Query = "Update tbl_Customer set Name='"+customer_name.Text+"',Email='"+customer_email.Text+"',Mobile='"+customer_mobile.Text+"',Address='" + customer_address.Text + "' where id=" + Convert.ToInt32(customer_ID.Text.ToString()) + "";
                obj.QueryOperation(Query);
                MessageBox.Show("Member record is updated ");
            }
            else
            {
                MessageBox.Show("You must have to fill all details ");
            }
            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";

        }

        private void Video_add_btn_Click(object sender, EventArgs e)
        {
            getCost();
            if (!Video_name.Text.ToString().Equals("") && !Video_ratting.Text.ToString().Equals("") && !Video_year.Text.ToString().Equals("") && !Video_cost.Text.ToString().Equals("") && !Video_copies.Text.ToString().Equals("") && !video_Genre.Text.ToString().Equals(""))
            {
                String addOperation = "insert into tbl_Video(Title,Ratting,Year,Cost,Copies,Genre) values ('"+Video_name.Text+"','"+Video_ratting.Text+"','"+Video_year.Text+"','"+Video_cost.Text+"','"+Video_copies.Text+"','"+video_Genre.Text+"')";
                obj.QueryOperation(addOperation);
                MessageBox.Show("Video is stored in the store ");

                Video_name.Text = "";
                Video_ratting.Text = "";
                Video_year.Text = "";
                Video_cost.Text = "";
                Video_copies.Text = "";
                video_Genre.Text = "";
                MovieId.Text = "";
            }

            else {
                MessageBox.Show("Must have to fill the detail of the video ");
            }
        }

        private void delete_video_btn_Click(object sender, EventArgs e)
        {
            //delete the video
            if (!MovieId.Text.ToString().Equals(""))
            {
                //first we have to chkc is the movie booked or not 
                DataTable dataTable = new DataTable();
                String srchOperation = "select * from tbl_Rental where M_Id=" + Convert.ToInt32(MovieId.Text.ToString()) + " and ReturnDate='booked'";
                dataTable = obj.FetchRecord(srchOperation);
                if (dataTable.Rows.Count==0) {
                    string delOperation = "delete from tbl_Video where id=" + Convert.ToInt32(MovieId.Text.ToString()) + "";
                    obj.QueryOperation(delOperation);
                    MessageBox.Show("video is deleted form the store");
                }
                else {
                    MessageBox.Show("video is issued on rent ");
                }



            }
            else {
                MessageBox.Show("must have to select the movie to delete");
            }

            Video_name.Text = "";
            Video_ratting.Text = "";
            Video_year.Text = "";
            Video_cost.Text = "";
            Video_copies.Text = "";
            video_Genre.Text = "";
            MovieId.Text = "";

        }

        private void video_update_btn_Click(object sender, EventArgs e)
        {
            getCost();
            if (!MovieId.Text.ToString().Equals("") && !Video_name.Text.ToString().Equals("") && !Video_ratting.Text.ToString().Equals("") && !Video_year.Text.ToString().Equals("") && !Video_cost.Text.ToString().Equals("") && !Video_copies.Text.ToString().Equals("") && !video_Genre.Text.ToString().Equals(""))
            {
                String addOperation = "update tbl_Video set Title='"+Video_name.Text+"',Ratting='"+Video_ratting.Text+"',Year='"+Video_year.Text+"',Cost='"+Video_cost.Text+ "',Copies='"+Video_copies.Text+"',Genre='"+video_Genre.Text+ "' where id=" + Convert.ToInt32(MovieId.Text.ToString()) + "";
                obj.QueryOperation(addOperation);
                MessageBox.Show("Video is updated in the store ");

                Video_name.Text = "";
                Video_ratting.Text = "";
                Video_year.Text = "";
                Video_cost.Text = "";
                Video_copies.Text = "";
                video_Genre.Text = "";
                MovieId.Text = "";
            }

            else
            {
                MessageBox.Show("Must have to fill the detail of the video ");
            }


        }

        private void movie_issue_Click(object sender, EventArgs e)
        {
            //issue the video on rent
            if (!customer_ID.Text.ToString().Equals("") && !MovieId.Text.ToString().Equals(""))
            {
                if (chkMemberBooking(Convert.ToInt32(customer_ID.Text.ToString())) == 1)
                {
                    if (chkSampleVideo(Convert.ToInt32(MovieId.Text.ToString())) == 1)
                    {      //then you can book a video 
                        string bookingoperation = "insert into tbl_Rental(C_Id,M_Id,IssueDate,ReturnDate) values(" + Convert.ToInt32(customer_ID.Text) + "," + Convert.ToInt32(MovieId.Text) + ",'" + issueDate.Text + "','booked')";
                        obj.QueryOperation(bookingoperation);
                        MessageBox.Show("Video is issued to the Member ");


                    }
                    else {
                        MessageBox.Show("Sorry for the delay all sample are booked ");
                    }

                }
                else {
                    MessageBox.Show("you can't issue more video ");
                }
          

            }
            else {
                MessageBox.Show("select the video and customer to book video");
            }

            Video_name.Text = "";
            Video_ratting.Text = "";
            Video_year.Text = "";
            Video_cost.Text = "";
            Video_copies.Text = "";
            video_Genre.Text = "";
            MovieId.Text = "";
            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";
        }

        private void video_data_Click(object sender, EventArgs e)
        {
            //get the record from the video table 
            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Video");
            Database.DataSource = dataTable;
            getData = 1;
        }

        private void custmer_data_Click(object sender, EventArgs e)
        {
            //get the record from the customer table 
            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Customer");
            Database.DataSource = dataTable;
            getData = 2;
        }

        private void rental_data_Click(object sender, EventArgs e)
        {
            //get the record from the video table 
            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Rental");
            Database.DataSource = dataTable;
            getData = 3;
        }

        private void delete_movie_Click(object sender, EventArgs e)
        {
            //delete the rental movie 
            if (Rental_ID > 0)
            {
                String delOperation = "delete from tbl_Rental where id=" + Rental_ID + "";
                obj.QueryOperation(delOperation);
                MessageBox.Show("Record is deleted "); 
            }
            else {
                MessageBox.Show("Delete the rental video ");
            }


            Rental_ID = 0;
            Video_name.Text = "";
            Video_ratting.Text = "";
            Video_year.Text = "";
            Video_cost.Text = "";
            Video_copies.Text = "";
            video_Genre.Text = "";
            MovieId.Text = "";
            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";

        }
        //method to generate the bill 
        public void GenerateBill(int M_Id) {
            DateTime new_date = DateTime.Now;


            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(issueDate.Text);


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            DataTable dataTable = new DataTable();
            dataTable = obj.FetchRecord("select * from tbl_Video where id=" + M_Id + "");

            int cost = Convert.ToInt32(dataTable.Rows[0]["Cost"]);


            int Charges = Convert.ToInt32(DaysInterval) * cost;

            MessageBox.Show("Your bill is  $" + Charges);


        }

        private void return_movie_Click(object sender, EventArgs e)
        {
            // return the video to store
            if ( Rental_ID>0 && !customer_ID.Text.ToString().Equals("") && !MovieId.Text.ToString().Equals(""))
            {
                string bookingoperation = "update tbl_Rental set C_Id=" + Convert.ToInt32(customer_ID.Text) + ",M_Id=" + Convert.ToInt32(MovieId.Text) + ",IssueDate='" + issueDate.Text + "',ReturnDate='"+returnDate.Text+"' where id="+Rental_ID+"";
                obj.QueryOperation(bookingoperation);
                MessageBox.Show("Video is returned  to the Member ");
                GenerateBill(Convert.ToInt32(MovieId.Text));
            }
            else {
                MessageBox.Show("Select the Video to return ");
            }


            Rental_ID = 0;
            Video_name.Text = "";
            Video_ratting.Text = "";
            Video_year.Text = "";
            Video_cost.Text = "";
            Video_copies.Text = "";
            video_Genre.Text = "";
            MovieId.Text = "";
            customer_address.Text = "";
            customer_email.Text = "";
            customer_mobile.Text = "";
            customer_name.Text = "";
            customer_ID.Text = "";

        }

        private void Database_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //flag 1 describe the record of the video 
            if (getData == 1) {
                //get the data of the video 
                MovieId.Text = Database.CurrentRow.Cells[0].Value.ToString();
                Video_name.Text = Database.CurrentRow.Cells[1].Value.ToString();
                Video_ratting.Text = Database.CurrentRow.Cells[2].Value.ToString();
                Video_year.Text = Database.CurrentRow.Cells[3].Value.ToString();
                Video_cost.Text = Database.CurrentRow.Cells[4].Value.ToString();
                Video_copies.Text = Database.CurrentRow.Cells[5].Value.ToString();
                video_Genre.Text = Database.CurrentRow.Cells[6].Value.ToString();

            }
            else if (getData == 2) {
                //get the data of the member 
                customer_ID.Text = Database.CurrentRow.Cells[0].Value.ToString();
                customer_name.Text = Database.CurrentRow.Cells[1].Value.ToString();
                customer_email.Text = Database.CurrentRow.Cells[2].Value.ToString();
                customer_mobile.Text = Database.CurrentRow.Cells[3].Value.ToString();
                customer_address.Text = Database.CurrentRow.Cells[4].Value.ToString();
            }
            else if (getData==3) {
                Rental_ID = Convert.ToInt32(Database.CurrentRow.Cells[0].Value.ToString());
                customer_ID.Text = Database.CurrentRow.Cells[1].Value.ToString();
                MovieId.Text = Database.CurrentRow.Cells[2].Value.ToString();
                issueDate.Text = Database.CurrentRow.Cells[3].Value.ToString();
            }

            getData = 0;
        }

        private void best_movie_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData =obj.FetchRecord("select * from tbl_Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =obj.FetchRecord("select * from tbl_Rental where M_Id=" + Convert.ToInt32(tblData.Rows[x]["id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Title"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Most Booked Movie Name is :" + Title);

        }

        private void best_customer_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData = obj.FetchRecord("select * from tbl_Customer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = obj.FetchRecord("select * from tbl_Rental where C_Id=" + Convert.ToInt32(tblData.Rows[x]["id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Best Cusotmer of the Store is :" + Title);

        }
    }
}
