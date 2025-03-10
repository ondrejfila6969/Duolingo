using System.ComponentModel;

namespace Duolingo.Forms;

partial class Users
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
        create_user_button = new System.Windows.Forms.Button();
        delete_user_button = new System.Windows.Forms.Button();
        create_user_textbox = new System.Windows.Forms.TextBox();
        delete_user_textbox = new System.Windows.Forms.TextBox();
        listView1 = new System.Windows.Forms.ListView();
        idColumn = new System.Windows.Forms.ColumnHeader();
        nameColumn = new System.Windows.Forms.ColumnHeader();
        dateCreatedColumn = new System.Windows.Forms.ColumnHeader();
        dateModifiedColumn = new System.Windows.Forms.ColumnHeader();
        navigate_back_button = new System.Windows.Forms.Button();
        users_text = new System.Windows.Forms.Label();
        error_label = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // create_user_button
        // 
        create_user_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
        create_user_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        create_user_button.Location = new System.Drawing.Point(139, 248);
        create_user_button.Name = "create_user_button";
        create_user_button.Size = new System.Drawing.Size(136, 43);
        create_user_button.TabIndex = 0;
        create_user_button.Text = "Create";
        create_user_button.UseVisualStyleBackColor = false;
        create_user_button.Click += create_user_button_Click;
        // 
        // delete_user_button
        // 
        delete_user_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
        delete_user_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        delete_user_button.Location = new System.Drawing.Point(139, 370);
        delete_user_button.Name = "delete_user_button";
        delete_user_button.Size = new System.Drawing.Size(136, 43);
        delete_user_button.TabIndex = 1;
        delete_user_button.Text = "Delete";
        delete_user_button.UseVisualStyleBackColor = false;
        delete_user_button.Click += delete_user_button_Click;
        // 
        // create_user_textbox
        // 
        create_user_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        create_user_textbox.Location = new System.Drawing.Point(67, 191);
        create_user_textbox.Name = "create_user_textbox";
        create_user_textbox.PlaceholderText = "Enter name:";
        create_user_textbox.Size = new System.Drawing.Size(275, 39);
        create_user_textbox.TabIndex = 2;
        create_user_textbox.TextChanged += create_user_textbox_TextChanged;
        create_user_textbox.KeyDown += create_user_textbox_KeyDown;
        // 
        // delete_user_textbox
        // 
        delete_user_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        delete_user_textbox.Location = new System.Drawing.Point(67, 317);
        delete_user_textbox.Name = "delete_user_textbox";
        delete_user_textbox.PlaceholderText = "Enter id:";
        delete_user_textbox.Size = new System.Drawing.Size(275, 39);
        delete_user_textbox.TabIndex = 3;
        delete_user_textbox.TextChanged += delete_user_textbox_TextChanged;
        delete_user_textbox.KeyDown += delete_user_textbox_KeyDown;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idColumn, nameColumn, dateCreatedColumn, dateModifiedColumn });
        listView1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        listView1.Location = new System.Drawing.Point(411, 73);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(550, 480);
        listView1.TabIndex = 4;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.ItemSelectionChanged += listView1_UserListView_ItemSelectionChanged;
        // 
        // idColumn
        // 
        idColumn.Name = "idColumn";
        idColumn.Text = "id";
        // 
        // nameColumn
        // 
        nameColumn.Name = "nameColumn";
        nameColumn.Text = "name";
        nameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nameColumn.Width = 163;
        // 
        // dateCreatedColumn
        // 
        dateCreatedColumn.Name = "dateCreatedColumn";
        dateCreatedColumn.Text = "date created";
        dateCreatedColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateCreatedColumn.Width = 163;
        // 
        // dateModifiedColumn
        // 
        dateModifiedColumn.Name = "dateModifiedColumn";
        dateModifiedColumn.Text = "date modified";
        dateModifiedColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        dateModifiedColumn.Width = 160;
        // 
        // navigate_back_button
        // 
        navigate_back_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)128)));
        navigate_back_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        navigate_back_button.Location = new System.Drawing.Point(127, 562);
        navigate_back_button.Name = "navigate_back_button";
        navigate_back_button.Size = new System.Drawing.Size(167, 57);
        navigate_back_button.TabIndex = 5;
        navigate_back_button.Text = "Back";
        navigate_back_button.UseVisualStyleBackColor = false;
        navigate_back_button.Click += navigate_back_button_Click;
        // 
        // users_text
        // 
        users_text.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        users_text.Location = new System.Drawing.Point(126, 73);
        users_text.Name = "users_text";
        users_text.Size = new System.Drawing.Size(168, 64);
        users_text.TabIndex = 6;
        users_text.Text = "USERS";
        // 
        // error_label
        // 
        error_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        error_label.Location = new System.Drawing.Point(525, 571);
        error_label.Name = "error_label";
        error_label.Size = new System.Drawing.Size(343, 36);
        error_label.TabIndex = 8;
        error_label.Click += error_label_Click;
        // 
        // Users
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.WindowFrame;
        Controls.Add(error_label);
        Controls.Add(users_text);
        Controls.Add(navigate_back_button);
        Controls.Add(listView1);
        Controls.Add(delete_user_textbox);
        Controls.Add(create_user_textbox);
        Controls.Add(delete_user_button);
        Controls.Add(create_user_button);
        Size = new System.Drawing.Size(1000, 750);
        Load += Users_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label error_label;

    private System.Windows.Forms.Button navigate_back_button;
    private System.Windows.Forms.Label users_text;

    private System.Windows.Forms.ColumnHeader idColumn;
    private System.Windows.Forms.ColumnHeader nameColumn;
    private System.Windows.Forms.ColumnHeader dateCreatedColumn;
    private System.Windows.Forms.ColumnHeader dateModifiedColumn;

    private System.Windows.Forms.Button create_user_button;
    private System.Windows.Forms.Button delete_user_button;
    private System.Windows.Forms.TextBox create_user_textbox;
    private System.Windows.Forms.TextBox delete_user_textbox;
    private System.Windows.Forms.ListView listView1;

    #endregion
}