namespace our_priject
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label reference_NumberLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label doctor_GP_Appointment_RefLabel;
            System.Windows.Forms.Label doctor_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_GP_Appointment_RefLabel;
            System.Windows.Forms.Label gP_Appointment_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label surenameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label billing_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreivous = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pharmacyDataSet = new our_priject.PharmacyDataSet();
            this.pharmacy_OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_OfficeTableAdapter = new our_priject.PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter();
            this.tableAdapterManager = new our_priject.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.pharmacy_OfficeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacy_OfficeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reference_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.doctor_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.doctor_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.surenameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.billing_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            reference_NumberLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            doctor_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            doctor_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            gP_Appointment_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            invoice_NoLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            surenameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            billing_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).BeginInit();
            this.pharmacy_OfficeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnPreivous);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(243, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 58);
            this.panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(640, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(536, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(439, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnPreivous
            // 
            this.btnPreivous.BackColor = System.Drawing.Color.Silver;
            this.btnPreivous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPreivous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreivous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreivous.Location = new System.Drawing.Point(338, 13);
            this.btnPreivous.Name = "btnPreivous";
            this.btnPreivous.Size = new System.Drawing.Size(87, 29);
            this.btnPreivous.TabIndex = 3;
            this.btnPreivous.Text = "Perivous";
            this.btnPreivous.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(226, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(113, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(10, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_OfficeBindingSource
            // 
            this.pharmacy_OfficeBindingSource.DataMember = "Pharmacy_Office";
            this.pharmacy_OfficeBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacy_OfficeTableAdapter
            // 
            this.pharmacy_OfficeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = our_priject.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacy_OfficeBindingNavigator
            // 
            this.pharmacy_OfficeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacy_OfficeBindingNavigator.BindingSource = this.pharmacy_OfficeBindingSource;
            this.pharmacy_OfficeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacy_OfficeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacy_OfficeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pharmacy_OfficeBindingNavigatorSaveItem});
            this.pharmacy_OfficeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacy_OfficeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacy_OfficeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacy_OfficeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacy_OfficeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacy_OfficeBindingNavigator.Name = "pharmacy_OfficeBindingNavigator";
            this.pharmacy_OfficeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacy_OfficeBindingNavigator.Size = new System.Drawing.Size(992, 25);
            this.pharmacy_OfficeBindingNavigator.TabIndex = 3;
            this.pharmacy_OfficeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pharmacy_OfficeBindingNavigatorSaveItem
            // 
            this.pharmacy_OfficeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Enabled = false;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacy_OfficeBindingNavigatorSaveItem.Image")));
            this.pharmacy_OfficeBindingNavigatorSaveItem.Name = "pharmacy_OfficeBindingNavigatorSaveItem";
            this.pharmacy_OfficeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.pharmacy_OfficeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // reference_NumberLabel
            // 
            reference_NumberLabel.AutoSize = true;
            reference_NumberLabel.Location = new System.Drawing.Point(61, 56);
            reference_NumberLabel.Name = "reference_NumberLabel";
            reference_NumberLabel.Size = new System.Drawing.Size(100, 13);
            reference_NumberLabel.TabIndex = 3;
            reference_NumberLabel.Text = "Reference Number:";
            // 
            // reference_NumberTextBox
            // 
            this.reference_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Reference Number", true));
            this.reference_NumberTextBox.Location = new System.Drawing.Point(256, 53);
            this.reference_NumberTextBox.Name = "reference_NumberTextBox";
            this.reference_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.reference_NumberTextBox.TabIndex = 4;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(61, 82);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(57, 13);
            patient_IDLabel.TabIndex = 5;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(256, 79);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_IDTextBox.TabIndex = 6;
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(61, 108);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(92, 13);
            doctor_s_NHS_NoLabel.TabIndex = 7;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(256, 105);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 8;
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Location = new System.Drawing.Point(61, 134);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(112, 13);
            medical_Centre_NameLabel.TabIndex = 9;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(256, 131);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.medical_Centre_NameTextBox.TabIndex = 10;
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Location = new System.Drawing.Point(61, 160);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(76, 13);
            eMIS_NumberLabel.TabIndex = 11;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(256, 157);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.eMIS_NumberTextBox.TabIndex = 12;
            // 
            // doctor_GP_Appointment_RefLabel
            // 
            doctor_GP_Appointment_RefLabel.AutoSize = true;
            doctor_GP_Appointment_RefLabel.Location = new System.Drawing.Point(61, 186);
            doctor_GP_Appointment_RefLabel.Name = "doctor_GP_Appointment_RefLabel";
            doctor_GP_Appointment_RefLabel.Size = new System.Drawing.Size(142, 13);
            doctor_GP_Appointment_RefLabel.TabIndex = 13;
            doctor_GP_Appointment_RefLabel.Text = "Doctor GP Appointment Ref:";
            // 
            // doctor_GP_Appointment_RefTextBox
            // 
            this.doctor_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_GP Appointment Ref", true));
            this.doctor_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(256, 183);
            this.doctor_GP_Appointment_RefTextBox.Name = "doctor_GP_Appointment_RefTextBox";
            this.doctor_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_GP_Appointment_RefTextBox.TabIndex = 14;
            // 
            // doctor_Patient_NHS_NumberLabel
            // 
            doctor_Patient_NHS_NumberLabel.AutoSize = true;
            doctor_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(61, 212);
            doctor_Patient_NHS_NumberLabel.Name = "doctor_Patient_NHS_NumberLabel";
            doctor_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(144, 13);
            doctor_Patient_NHS_NumberLabel.TabIndex = 15;
            doctor_Patient_NHS_NumberLabel.Text = "Doctor Patient NHS Number:";
            // 
            // doctor_Patient_NHS_NumberTextBox
            // 
            this.doctor_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_Patient NHS Number", true));
            this.doctor_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(256, 209);
            this.doctor_Patient_NHS_NumberTextBox.Name = "doctor_Patient_NHS_NumberTextBox";
            this.doctor_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_Patient_NHS_NumberTextBox.TabIndex = 16;
            // 
            // gP_Appointment_GP_Appointment_RefLabel
            // 
            gP_Appointment_GP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_GP_Appointment_RefLabel.Location = new System.Drawing.Point(61, 238);
            gP_Appointment_GP_Appointment_RefLabel.Name = "gP_Appointment_GP_Appointment_RefLabel";
            gP_Appointment_GP_Appointment_RefLabel.Size = new System.Drawing.Size(187, 13);
            gP_Appointment_GP_Appointment_RefLabel.TabIndex = 17;
            gP_Appointment_GP_Appointment_RefLabel.Text = "GP Appointment GP Appointment Ref:";
            // 
            // gP_Appointment_GP_Appointment_RefTextBox
            // 
            this.gP_Appointment_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_GP Appointment Ref", true));
            this.gP_Appointment_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(256, 235);
            this.gP_Appointment_GP_Appointment_RefTextBox.Name = "gP_Appointment_GP_Appointment_RefTextBox";
            this.gP_Appointment_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_GP_Appointment_RefTextBox.TabIndex = 18;
            // 
            // gP_Appointment_Patient_NHS_NumberLabel
            // 
            gP_Appointment_Patient_NHS_NumberLabel.AutoSize = true;
            gP_Appointment_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(61, 264);
            gP_Appointment_Patient_NHS_NumberLabel.Name = "gP_Appointment_Patient_NHS_NumberLabel";
            gP_Appointment_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(189, 13);
            gP_Appointment_Patient_NHS_NumberLabel.TabIndex = 19;
            gP_Appointment_Patient_NHS_NumberLabel.Text = "GP Appointment Patient NHS Number:";
            // 
            // gP_Appointment_Patient_NHS_NumberTextBox
            // 
            this.gP_Appointment_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_Patient NHS Number", true));
            this.gP_Appointment_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(256, 261);
            this.gP_Appointment_Patient_NHS_NumberTextBox.Name = "gP_Appointment_Patient_NHS_NumberTextBox";
            this.gP_Appointment_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.gP_Appointment_Patient_NHS_NumberTextBox.TabIndex = 20;
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(61, 290);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(62, 13);
            invoice_NoLabel.TabIndex = 21;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(256, 287);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoice_NoTextBox.TabIndex = 22;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(61, 316);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 23;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(256, 313);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 24;
            // 
            // surenameLabel
            // 
            surenameLabel.AutoSize = true;
            surenameLabel.Location = new System.Drawing.Point(61, 342);
            surenameLabel.Name = "surenameLabel";
            surenameLabel.Size = new System.Drawing.Size(58, 13);
            surenameLabel.TabIndex = 25;
            surenameLabel.Text = "Surename:";
            // 
            // surenameTextBox
            // 
            this.surenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Surename", true));
            this.surenameTextBox.Location = new System.Drawing.Point(256, 339);
            this.surenameTextBox.Name = "surenameTextBox";
            this.surenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surenameTextBox.TabIndex = 26;
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(61, 368);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(69, 13);
            date_of_BirthLabel.TabIndex = 27;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Date of Birth", true));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(256, 365);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_of_BirthTextBox.TabIndex = 28;
            // 
            // billing_NameLabel
            // 
            billing_NameLabel.AutoSize = true;
            billing_NameLabel.Location = new System.Drawing.Point(61, 394);
            billing_NameLabel.Name = "billing_NameLabel";
            billing_NameLabel.Size = new System.Drawing.Size(68, 13);
            billing_NameLabel.TabIndex = 29;
            billing_NameLabel.Text = "Billing Name:";
            // 
            // billing_NameTextBox
            // 
            this.billing_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Billing Name", true));
            this.billing_NameTextBox.Location = new System.Drawing.Point(256, 391);
            this.billing_NameTextBox.Name = "billing_NameTextBox";
            this.billing_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.billing_NameTextBox.TabIndex = 30;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(61, 420);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 31;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(256, 417);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 32;
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(61, 446);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            post_CodeLabel.TabIndex = 33;
            post_CodeLabel.Text = "Post Code:";
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(256, 443);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.post_CodeTextBox.TabIndex = 34;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(61, 472);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 35;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(256, 469);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 36;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(61, 498);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 37;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(256, 495);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 38;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 600);
            this.Controls.Add(reference_NumberLabel);
            this.Controls.Add(this.reference_NumberTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(doctor_GP_Appointment_RefLabel);
            this.Controls.Add(this.doctor_GP_Appointment_RefTextBox);
            this.Controls.Add(doctor_Patient_NHS_NumberLabel);
            this.Controls.Add(this.doctor_Patient_NHS_NumberTextBox);
            this.Controls.Add(gP_Appointment_GP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_GP_Appointment_RefTextBox);
            this.Controls.Add(gP_Appointment_Patient_NHS_NumberLabel);
            this.Controls.Add(this.gP_Appointment_Patient_NHS_NumberTextBox);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(surenameLabel);
            this.Controls.Add(this.surenameTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthTextBox);
            this.Controls.Add(billing_NameLabel);
            this.Controls.Add(this.billing_NameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.pharmacy_OfficeBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parmacy Office";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).EndInit();
            this.pharmacy_OfficeBindingNavigator.ResumeLayout(false);
            this.pharmacy_OfficeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreivous;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource pharmacy_OfficeBindingSource;
        private PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter pharmacy_OfficeTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacy_OfficeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pharmacy_OfficeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reference_NumberTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox doctor_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox doctor_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox surenameTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox billing_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
    }
}