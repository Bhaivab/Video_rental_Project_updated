namespace Video_rental_Project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.delete_video_btn = new System.Windows.Forms.Button();
            this.video_update_btn = new System.Windows.Forms.Button();
            this.Video_add_btn = new System.Windows.Forms.Button();
            this.Video_copies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Video_cost = new System.Windows.Forms.TextBox();
            this.Video_year = new System.Windows.Forms.TextBox();
            this.Video_ratting = new System.Windows.Forms.TextBox();
            this.Video_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_customer = new System.Windows.Forms.Button();
            this.add_cutomer = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.customer_mobile = new System.Windows.Forms.TextBox();
            this.customer_email = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.best_customer = new System.Windows.Forms.Button();
            this.delete_movie = new System.Windows.Forms.Button();
            this.best_movie = new System.Windows.Forms.Button();
            this.return_movie = new System.Windows.Forms.Button();
            this.movie_issue = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.issueDate = new System.Windows.Forms.DateTimePicker();
            this.customer_ID = new System.Windows.Forms.TextBox();
            this.MovieId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.video_data = new System.Windows.Forms.Button();
            this.custmer_data = new System.Windows.Forms.Button();
            this.rental_data = new System.Windows.Forms.Button();
            this.video_Genre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_video_btn
            // 
            this.delete_video_btn.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_video_btn.Location = new System.Drawing.Point(124, 375);
            this.delete_video_btn.Name = "delete_video_btn";
            this.delete_video_btn.Size = new System.Drawing.Size(114, 27);
            this.delete_video_btn.TabIndex = 28;
            this.delete_video_btn.Text = "Delete Video";
            this.delete_video_btn.UseVisualStyleBackColor = true;
            this.delete_video_btn.Click += new System.EventHandler(this.delete_video_btn_Click);
            // 
            // video_update_btn
            // 
            this.video_update_btn.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_update_btn.Location = new System.Drawing.Point(245, 375);
            this.video_update_btn.Name = "video_update_btn";
            this.video_update_btn.Size = new System.Drawing.Size(114, 27);
            this.video_update_btn.TabIndex = 27;
            this.video_update_btn.Text = "Update Video";
            this.video_update_btn.UseVisualStyleBackColor = true;
            this.video_update_btn.Click += new System.EventHandler(this.video_update_btn_Click);
            // 
            // Video_add_btn
            // 
            this.Video_add_btn.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_add_btn.Location = new System.Drawing.Point(2, 375);
            this.Video_add_btn.Name = "Video_add_btn";
            this.Video_add_btn.Size = new System.Drawing.Size(114, 27);
            this.Video_add_btn.TabIndex = 26;
            this.Video_add_btn.Text = "Add Video";
            this.Video_add_btn.UseVisualStyleBackColor = true;
            this.Video_add_btn.Click += new System.EventHandler(this.Video_add_btn_Click);
            // 
            // Video_copies
            // 
            this.Video_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_copies.Location = new System.Drawing.Point(170, 280);
            this.Video_copies.Name = "Video_copies";
            this.Video_copies.Size = new System.Drawing.Size(172, 29);
            this.Video_copies.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Copies";
            // 
            // Video_cost
            // 
            this.Video_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_cost.Location = new System.Drawing.Point(170, 218);
            this.Video_cost.Name = "Video_cost";
            this.Video_cost.ReadOnly = true;
            this.Video_cost.Size = new System.Drawing.Size(172, 29);
            this.Video_cost.TabIndex = 23;
            // 
            // Video_year
            // 
            this.Video_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_year.Location = new System.Drawing.Point(170, 160);
            this.Video_year.Name = "Video_year";
            this.Video_year.Size = new System.Drawing.Size(172, 29);
            this.Video_year.TabIndex = 22;
            // 
            // Video_ratting
            // 
            this.Video_ratting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_ratting.Location = new System.Drawing.Point(170, 111);
            this.Video_ratting.Name = "Video_ratting";
            this.Video_ratting.Size = new System.Drawing.Size(172, 29);
            this.Video_ratting.TabIndex = 21;
            // 
            // Video_name
            // 
            this.Video_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_name.Location = new System.Drawing.Point(170, 61);
            this.Video_name.Name = "Video_name";
            this.Video_name.Size = new System.Drawing.Size(172, 29);
            this.Video_name.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rattings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "year_realsed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cost ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // delete_customer
            // 
            this.delete_customer.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_customer.Location = new System.Drawing.Point(489, 318);
            this.delete_customer.Name = "delete_customer";
            this.delete_customer.Size = new System.Drawing.Size(114, 27);
            this.delete_customer.TabIndex = 33;
            this.delete_customer.Text = "Delete Customer";
            this.delete_customer.UseVisualStyleBackColor = true;
            this.delete_customer.Click += new System.EventHandler(this.delete_customer_Click);
            // 
            // add_cutomer
            // 
            this.add_cutomer.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cutomer.Location = new System.Drawing.Point(422, 280);
            this.add_cutomer.Name = "add_cutomer";
            this.add_cutomer.Size = new System.Drawing.Size(114, 27);
            this.add_cutomer.TabIndex = 34;
            this.add_cutomer.Text = "Add Customer";
            this.add_cutomer.UseVisualStyleBackColor = true;
            this.add_cutomer.Click += new System.EventHandler(this.add_cutomer_Click);
            // 
            // update_customer
            // 
            this.update_customer.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_customer.Location = new System.Drawing.Point(558, 282);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(114, 27);
            this.update_customer.TabIndex = 35;
            this.update_customer.Text = "Update Customer";
            this.update_customer.UseVisualStyleBackColor = true;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // customer_address
            // 
            this.customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address.Location = new System.Drawing.Point(521, 227);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(172, 29);
            this.customer_address.TabIndex = 39;
            // 
            // customer_mobile
            // 
            this.customer_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_mobile.Location = new System.Drawing.Point(521, 169);
            this.customer_mobile.Name = "customer_mobile";
            this.customer_mobile.Size = new System.Drawing.Size(172, 29);
            this.customer_mobile.TabIndex = 38;
            // 
            // customer_email
            // 
            this.customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_email.Location = new System.Drawing.Point(521, 120);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(172, 29);
            this.customer_email.TabIndex = 37;
            // 
            // customer_name
            // 
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(521, 61);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(172, 29);
            this.customer_name.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mobile";
            // 
            // best_customer
            // 
            this.best_customer.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_customer.Location = new System.Drawing.Point(1024, 370);
            this.best_customer.Name = "best_customer";
            this.best_customer.Size = new System.Drawing.Size(153, 27);
            this.best_customer.TabIndex = 52;
            this.best_customer.Text = "Best Customer";
            this.best_customer.UseVisualStyleBackColor = true;
            this.best_customer.Click += new System.EventHandler(this.best_customer_Click);
            // 
            // delete_movie
            // 
            this.delete_movie.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_movie.Location = new System.Drawing.Point(1080, 253);
            this.delete_movie.Name = "delete_movie";
            this.delete_movie.Size = new System.Drawing.Size(114, 27);
            this.delete_movie.TabIndex = 44;
            this.delete_movie.Text = "Delete Movie";
            this.delete_movie.UseVisualStyleBackColor = true;
            this.delete_movie.Click += new System.EventHandler(this.delete_movie_Click);
            // 
            // best_movie
            // 
            this.best_movie.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_movie.Location = new System.Drawing.Point(1024, 328);
            this.best_movie.Name = "best_movie";
            this.best_movie.Size = new System.Drawing.Size(153, 27);
            this.best_movie.TabIndex = 51;
            this.best_movie.Text = "Best Movie";
            this.best_movie.UseVisualStyleBackColor = true;
            this.best_movie.Click += new System.EventHandler(this.best_movie_Click);
            // 
            // return_movie
            // 
            this.return_movie.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_movie.Location = new System.Drawing.Point(943, 253);
            this.return_movie.Name = "return_movie";
            this.return_movie.Size = new System.Drawing.Size(114, 27);
            this.return_movie.TabIndex = 45;
            this.return_movie.Text = "Return Movie";
            this.return_movie.UseVisualStyleBackColor = true;
            this.return_movie.Click += new System.EventHandler(this.return_movie_Click);
            // 
            // movie_issue
            // 
            this.movie_issue.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_issue.Location = new System.Drawing.Point(792, 253);
            this.movie_issue.Name = "movie_issue";
            this.movie_issue.Size = new System.Drawing.Size(114, 27);
            this.movie_issue.TabIndex = 46;
            this.movie_issue.Text = "Issue Movie";
            this.movie_issue.UseVisualStyleBackColor = true;
            this.movie_issue.Click += new System.EventHandler(this.movie_issue_Click);
            // 
            // returnDate
            // 
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDate.Location = new System.Drawing.Point(958, 198);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(159, 21);
            this.returnDate.TabIndex = 50;
            // 
            // issueDate
            // 
            this.issueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issueDate.Location = new System.Drawing.Point(958, 152);
            this.issueDate.Name = "issueDate";
            this.issueDate.Size = new System.Drawing.Size(159, 21);
            this.issueDate.TabIndex = 49;
            // 
            // customer_ID
            // 
            this.customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_ID.Location = new System.Drawing.Point(958, 102);
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.Size = new System.Drawing.Size(159, 29);
            this.customer_ID.TabIndex = 48;
            // 
            // MovieId
            // 
            this.MovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieId.Location = new System.Drawing.Point(958, 52);
            this.MovieId.Name = "MovieId";
            this.MovieId.Size = new System.Drawing.Size(159, 29);
            this.MovieId.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(789, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "Return Issued Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(789, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Issue on Rent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(789, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Customer ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(789, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Movie ID:";
            // 
            // Database
            // 
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.Location = new System.Drawing.Point(14, 415);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(988, 225);
            this.Database.TabIndex = 54;
            this.Database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Database_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(63, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "Add Video Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(463, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 25);
            this.label15.TabIndex = 56;
            this.label15.Text = "Add Customer Details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(786, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 25);
            this.label16.TabIndex = 57;
            this.label16.Text = "Add Rental Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(365, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 384);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(763, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 384);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // video_data
            // 
            this.video_data.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_data.Location = new System.Drawing.Point(1024, 422);
            this.video_data.Name = "video_data";
            this.video_data.Size = new System.Drawing.Size(153, 27);
            this.video_data.TabIndex = 60;
            this.video_data.Text = "Video Details";
            this.video_data.UseVisualStyleBackColor = true;
            this.video_data.Click += new System.EventHandler(this.video_data_Click);
            // 
            // custmer_data
            // 
            this.custmer_data.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custmer_data.Location = new System.Drawing.Point(1024, 464);
            this.custmer_data.Name = "custmer_data";
            this.custmer_data.Size = new System.Drawing.Size(153, 27);
            this.custmer_data.TabIndex = 61;
            this.custmer_data.Text = "Customer Details";
            this.custmer_data.UseVisualStyleBackColor = true;
            this.custmer_data.Click += new System.EventHandler(this.custmer_data_Click);
            // 
            // rental_data
            // 
            this.rental_data.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_data.Location = new System.Drawing.Point(1024, 516);
            this.rental_data.Name = "rental_data";
            this.rental_data.Size = new System.Drawing.Size(153, 27);
            this.rental_data.TabIndex = 62;
            this.rental_data.Text = "Rental Details";
            this.rental_data.UseVisualStyleBackColor = true;
            this.rental_data.Click += new System.EventHandler(this.rental_data_Click);
            // 
            // video_Genre
            // 
            this.video_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_Genre.Location = new System.Drawing.Point(170, 329);
            this.video_Genre.Name = "video_Genre";
            this.video_Genre.Size = new System.Drawing.Size(172, 29);
            this.video_Genre.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 16);
            this.label17.TabIndex = 63;
            this.label17.Text = "Genre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 652);
            this.Controls.Add(this.video_Genre);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.video_data);
            this.Controls.Add(this.custmer_data);
            this.Controls.Add(this.rental_data);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.best_customer);
            this.Controls.Add(this.delete_movie);
            this.Controls.Add(this.best_movie);
            this.Controls.Add(this.return_movie);
            this.Controls.Add(this.movie_issue);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.issueDate);
            this.Controls.Add(this.customer_ID);
            this.Controls.Add(this.MovieId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.delete_customer);
            this.Controls.Add(this.add_cutomer);
            this.Controls.Add(this.update_customer);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.customer_mobile);
            this.Controls.Add(this.customer_email);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete_video_btn);
            this.Controls.Add(this.video_update_btn);
            this.Controls.Add(this.Video_add_btn);
            this.Controls.Add(this.Video_copies);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Video_cost);
            this.Controls.Add(this.Video_year);
            this.Controls.Add(this.Video_ratting);
            this.Controls.Add(this.Video_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_video_btn;
        private System.Windows.Forms.Button video_update_btn;
        private System.Windows.Forms.Button Video_add_btn;
        private System.Windows.Forms.TextBox Video_copies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Video_cost;
        private System.Windows.Forms.TextBox Video_year;
        private System.Windows.Forms.TextBox Video_ratting;
        private System.Windows.Forms.TextBox Video_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_customer;
        private System.Windows.Forms.Button add_cutomer;
        private System.Windows.Forms.Button update_customer;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.TextBox customer_mobile;
        private System.Windows.Forms.TextBox customer_email;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button best_customer;
        private System.Windows.Forms.Button delete_movie;
        private System.Windows.Forms.Button best_movie;
        private System.Windows.Forms.Button return_movie;
        private System.Windows.Forms.Button movie_issue;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DateTimePicker issueDate;
        private System.Windows.Forms.TextBox customer_ID;
        private System.Windows.Forms.TextBox MovieId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button video_data;
        private System.Windows.Forms.Button custmer_data;
        private System.Windows.Forms.Button rental_data;
        private System.Windows.Forms.TextBox video_Genre;
        private System.Windows.Forms.Label label17;
    }
}

