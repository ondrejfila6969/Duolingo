using System.ComponentModel;

namespace Duolingo.Forms;

partial class Registrations
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        registrations_title = new System.Windows.Forms.Label();
        listView1 = new System.Windows.Forms.ListView();
        idColumn = new System.Windows.Forms.ColumnHeader();
        nameColumn = new System.Windows.Forms.ColumnHeader();
        dateCreatedColumn = new System.Windows.Forms.ColumnHeader();
        dateModifiedColumn = new System.Windows.Forms.ColumnHeader();
        listView2 = new System.Windows.Forms.ListView();
        idColumnLanguages = new System.Windows.Forms.ColumnHeader();
        nameColumnLanguages = new System.Windows.Forms.ColumnHeader();
        dateCreatedLanguages = new System.Windows.Forms.ColumnHeader();
        dateModifiedLanguages = new System.Windows.Forms.ColumnHeader();
        listView3 = new System.Windows.Forms.ListView();
        idColumnRegistrations = new System.Windows.Forms.ColumnHeader();
        idUserRegistrations = new System.Windows.Forms.ColumnHeader();
        idLanguageRegistrations = new System.Windows.Forms.ColumnHeader();
        register_button = new System.Windows.Forms.Button();
        delete_button = new System.Windows.Forms.Button();
        deleteRegistration_textbox = new System.Windows.Forms.TextBox();
        users_label = new System.Windows.Forms.Label();
        languages_label = new System.Windows.Forms.Label();
        registrations_label = new System.Windows.Forms.Label();
        back_button = new System.Windows.Forms.Button();
        error_label = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // registrations_title
        // 
        registrations_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        registrations_title.Location = new System.Drawing.Point(30, 15);
        registrations_title.Name = "registrations_title";
        registrations_title.Size = new System.Drawing.Size(378, 71);
        registrations_title.TabIndex = 0;
        registrations_title.Text = "REGISTRATIONS";
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idColumn, nameColumn, dateCreatedColumn, dateModifiedColumn });
        listView1.Location = new System.Drawing.Point(13, 140);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(310, 372);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.MouseClick += listView1_MouseClick;
        // 
        // idColumn
        // 
        idColumn.Name = "idColumn";
        idColumn.Text = "id";
        idColumn.Width = 30;
        // 
        // nameColumn
        // 
        nameColumn.Name = "nameColumn";
        nameColumn.Text = "name";
        nameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nameColumn.Width = 93;
        // 
        // dateCreatedColumn
        // 
        dateCreatedColumn.Name = "dateCreatedColumn";
        dateCreatedColumn.Text = "date created";
        dateCreatedColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateCreatedColumn.Width = 93;
        // 
        // dateModifiedColumn
        // 
        dateModifiedColumn.Name = "dateModifiedColumn";
        dateModifiedColumn.Text = "date modified";
        dateModifiedColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateModifiedColumn.Width = 90;
        // 
        // listView2
        // 
        listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idColumnLanguages, nameColumnLanguages, dateCreatedLanguages, dateModifiedLanguages });
        listView2.Location = new System.Drawing.Point(339, 140);
        listView2.Name = "listView2";
        listView2.Size = new System.Drawing.Size(310, 372);
        listView2.TabIndex = 2;
        listView2.UseCompatibleStateImageBehavior = false;
        listView2.View = System.Windows.Forms.View.Details;
        listView2.MouseClick += listView2_MouseClick;
        // 
        // idColumnLanguages
        // 
        idColumnLanguages.Name = "idColumnLanguages";
        idColumnLanguages.Text = "id";
        idColumnLanguages.Width = 30;
        // 
        // nameColumnLanguages
        // 
        nameColumnLanguages.Name = "nameColumnLanguages";
        nameColumnLanguages.Text = "name";
        nameColumnLanguages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nameColumnLanguages.Width = 93;
        // 
        // dateCreatedLanguages
        // 
        dateCreatedLanguages.Name = "dateCreatedLanguages";
        dateCreatedLanguages.Text = "date created";
        dateCreatedLanguages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateCreatedLanguages.Width = 93;
        // 
        // dateModifiedLanguages
        // 
        dateModifiedLanguages.Name = "dateModifiedLanguages";
        dateModifiedLanguages.Text = "date modified";
        dateModifiedLanguages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateModifiedLanguages.Width = 90;
        // 
        // listView3
        // 
        listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idColumnRegistrations, idUserRegistrations, idLanguageRegistrations });
        listView3.Location = new System.Drawing.Point(664, 140);
        listView3.Name = "listView3";
        listView3.Size = new System.Drawing.Size(310, 170);
        listView3.TabIndex = 3;
        listView3.UseCompatibleStateImageBehavior = false;
        listView3.View = System.Windows.Forms.View.Details;
        listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
        // 
        // idColumnRegistrations
        // 
        idColumnRegistrations.Name = "idColumnRegistrations";
        idColumnRegistrations.Text = "id";
        idColumnRegistrations.Width = 30;
        // 
        // idUserRegistrations
        // 
        idUserRegistrations.Name = "idUserRegistrations";
        idUserRegistrations.Text = "user_id";
        idUserRegistrations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        idUserRegistrations.Width = 140;
        // 
        // idLanguageRegistrations
        // 
        idLanguageRegistrations.Name = "idLanguageRegistrations";
        idLanguageRegistrations.Text = "language_id";
        idLanguageRegistrations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        idLanguageRegistrations.Width = 135;
        // 
        // register_button
        // 
        register_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
        register_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        register_button.Location = new System.Drawing.Point(67, 535);
        register_button.Name = "register_button";
        register_button.Size = new System.Drawing.Size(202, 52);
        register_button.TabIndex = 4;
        register_button.Text = "Register";
        register_button.UseVisualStyleBackColor = false;
        register_button.Click += register_button_Click;
        // 
        // delete_button
        // 
        delete_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
        delete_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        delete_button.Location = new System.Drawing.Point(776, 398);
        delete_button.Name = "delete_button";
        delete_button.Size = new System.Drawing.Size(134, 47);
        delete_button.TabIndex = 5;
        delete_button.Text = "Delete";
        delete_button.UseVisualStyleBackColor = false;
        delete_button.Click += delete_button_Click;
        // 
        // deleteRegistration_textbox
        // 
        deleteRegistration_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        deleteRegistration_textbox.Location = new System.Drawing.Point(730, 334);
        deleteRegistration_textbox.Name = "deleteRegistration_textbox";
        deleteRegistration_textbox.PlaceholderText = "Enter id:";
        deleteRegistration_textbox.Size = new System.Drawing.Size(218, 39);
        deleteRegistration_textbox.TabIndex = 6;
        deleteRegistration_textbox.KeyDown += deleteRegistration_textbox_KeyDown;
        // 
        // users_label
        // 
        users_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        users_label.Location = new System.Drawing.Point(123, 88);
        users_label.Name = "users_label";
        users_label.Size = new System.Drawing.Size(72, 49);
        users_label.TabIndex = 7;
        users_label.Text = "Users";
        users_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // languages_label
        // 
        languages_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        languages_label.Location = new System.Drawing.Point(430, 88);
        languages_label.Name = "languages_label";
        languages_label.Size = new System.Drawing.Size(138, 49);
        languages_label.TabIndex = 8;
        languages_label.Text = "Languages";
        languages_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // registrations_label
        // 
        registrations_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        registrations_label.Location = new System.Drawing.Point(753, 93);
        registrations_label.Name = "registrations_label";
        registrations_label.Size = new System.Drawing.Size(157, 44);
        registrations_label.TabIndex = 9;
        registrations_label.Text = "Registrations";
        registrations_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // back_button
        // 
        back_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)128)));
        back_button.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        back_button.Location = new System.Drawing.Point(381, 638);
        back_button.Name = "back_button";
        back_button.Size = new System.Drawing.Size(212, 61);
        back_button.TabIndex = 10;
        back_button.Text = "Back";
        back_button.UseVisualStyleBackColor = false;
        back_button.Click += back_button_Click;
        // 
        // error_label
        // 
        error_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        error_label.Location = new System.Drawing.Point(357, 535);
        error_label.Name = "error_label";
        error_label.Size = new System.Drawing.Size(501, 52);
        error_label.TabIndex = 12;
        // 
        // Registrations
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.WindowFrame;
        Controls.Add(error_label);
        Controls.Add(back_button);
        Controls.Add(registrations_label);
        Controls.Add(languages_label);
        Controls.Add(users_label);
        Controls.Add(deleteRegistration_textbox);
        Controls.Add(delete_button);
        Controls.Add(register_button);
        Controls.Add(listView3);
        Controls.Add(listView2);
        Controls.Add(listView1);
        Controls.Add(registrations_title);
        Size = new System.Drawing.Size(1000, 750);
        Load += Registrations_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label error_label;

    private System.Windows.Forms.ColumnHeader idColumnRegistrations;
    private System.Windows.Forms.ColumnHeader idUserRegistrations;
    private System.Windows.Forms.ColumnHeader idLanguageRegistrations;

    private System.Windows.Forms.ColumnHeader idColumnLanguages;
    private System.Windows.Forms.ColumnHeader nameColumnLanguages;
    private System.Windows.Forms.ColumnHeader dateCreatedLanguages;
    private System.Windows.Forms.ColumnHeader dateModifiedLanguages;

    private System.Windows.Forms.ColumnHeader idColumn;
    private System.Windows.Forms.ColumnHeader nameColumn;
    private System.Windows.Forms.ColumnHeader dateCreatedColumn;
    private System.Windows.Forms.ColumnHeader dateModifiedColumn;

    private System.Windows.Forms.Button back_button;

    private System.Windows.Forms.Label users_label;
    private System.Windows.Forms.Label languages_label;
    private System.Windows.Forms.Label registrations_label;

    private System.Windows.Forms.Button register_button;
    private System.Windows.Forms.Button delete_button;
    private System.Windows.Forms.TextBox deleteRegistration_textbox;

    private System.Windows.Forms.ListView listView3;

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ListView listView2;

    private System.Windows.Forms.Label registrations_title;

    #endregion
}