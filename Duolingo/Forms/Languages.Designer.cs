using System.ComponentModel;

namespace Duolingo.Forms;

partial class Languages
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
        create_button = new System.Windows.Forms.Button();
        delete_button = new System.Windows.Forms.Button();
        create_language_textbox = new System.Windows.Forms.TextBox();
        delete_language_textbox = new System.Windows.Forms.TextBox();
        languages_title = new System.Windows.Forms.Label();
        listView1 = new System.Windows.Forms.ListView();
        idColumn = new System.Windows.Forms.ColumnHeader();
        nameColumn = new System.Windows.Forms.ColumnHeader();
        createdAtColumn = new System.Windows.Forms.ColumnHeader();
        modifiedAtColumn = new System.Windows.Forms.ColumnHeader();
        back_button = new System.Windows.Forms.Button();
        error_label = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // create_button
        // 
        create_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)255)), ((int)((byte)128)));
        create_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        create_button.Location = new System.Drawing.Point(119, 297);
        create_button.Name = "create_button";
        create_button.Size = new System.Drawing.Size(158, 40);
        create_button.TabIndex = 0;
        create_button.Text = "Create";
        create_button.UseVisualStyleBackColor = false;
        create_button.Click += create_button_Click;
        // 
        // delete_button
        // 
        delete_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
        delete_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        delete_button.Location = new System.Drawing.Point(119, 432);
        delete_button.Name = "delete_button";
        delete_button.Size = new System.Drawing.Size(158, 44);
        delete_button.TabIndex = 1;
        delete_button.Text = "Delete";
        delete_button.UseVisualStyleBackColor = false;
        delete_button.Click += delete_button_Click;
        // 
        // create_language_textbox
        // 
        create_language_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        create_language_textbox.Location = new System.Drawing.Point(84, 233);
        create_language_textbox.Name = "create_language_textbox";
        create_language_textbox.PlaceholderText = "Enter name:";
        create_language_textbox.Size = new System.Drawing.Size(227, 39);
        create_language_textbox.TabIndex = 2;
        create_language_textbox.TextChanged += create_language_textbox_TextChanged;
        create_language_textbox.KeyDown += create_user_textbox_KeyDown;
        // 
        // delete_language_textbox
        // 
        delete_language_textbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        delete_language_textbox.Location = new System.Drawing.Point(84, 365);
        delete_language_textbox.Name = "delete_language_textbox";
        delete_language_textbox.PlaceholderText = "Enter id:";
        delete_language_textbox.Size = new System.Drawing.Size(227, 39);
        delete_language_textbox.TabIndex = 3;
        delete_language_textbox.TextChanged += delete_language_textbox_TextChanged;
        delete_language_textbox.KeyDown += delete_language_textbox_KeyDown;
        // 
        // languages_title
        // 
        languages_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        languages_title.Location = new System.Drawing.Point(55, 56);
        languages_title.Name = "languages_title";
        languages_title.Size = new System.Drawing.Size(298, 71);
        languages_title.TabIndex = 4;
        languages_title.Text = "LANGUAGES";
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idColumn, nameColumn, createdAtColumn, modifiedAtColumn });
        listView1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        listView1.Location = new System.Drawing.Point(407, 56);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(550, 480);
        listView1.TabIndex = 5;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // idColumn
        // 
        idColumn.Name = "idColumn";
        idColumn.Text = "Id";
        // 
        // nameColumn
        // 
        nameColumn.Name = "nameColumn";
        nameColumn.Text = "Name";
        nameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        nameColumn.Width = 163;
        // 
        // createdAtColumn
        // 
        createdAtColumn.Name = "createdAtColumn";
        createdAtColumn.Text = "created at";
        createdAtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        createdAtColumn.Width = 163;
        // 
        // modifiedAtColumn
        // 
        modifiedAtColumn.Name = "modifiedAtColumn";
        modifiedAtColumn.Text = "modified at";
        modifiedAtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        modifiedAtColumn.Width = 159;
        // 
        // back_button
        // 
        back_button.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)128)));
        back_button.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)238));
        back_button.Location = new System.Drawing.Point(119, 557);
        back_button.Name = "back_button";
        back_button.Size = new System.Drawing.Size(158, 57);
        back_button.TabIndex = 6;
        back_button.Text = "Back";
        back_button.UseVisualStyleBackColor = false;
        back_button.Click += back_button_Click;
        // 
        // error_label
        // 
        error_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        error_label.Location = new System.Drawing.Point(467, 557);
        error_label.Name = "error_label";
        error_label.Size = new System.Drawing.Size(422, 35);
        error_label.TabIndex = 8;
        error_label.Click += error_label_Click;
        // 
        // Languages
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.WindowFrame;
        Controls.Add(error_label);
        Controls.Add(back_button);
        Controls.Add(listView1);
        Controls.Add(languages_title);
        Controls.Add(delete_language_textbox);
        Controls.Add(create_language_textbox);
        Controls.Add(delete_button);
        Controls.Add(create_button);
        Size = new System.Drawing.Size(1000, 750);
        Load += Languages_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label error_label;

    private System.Windows.Forms.Button back_button;

    private System.Windows.Forms.ColumnHeader idColumn;
    private System.Windows.Forms.ColumnHeader nameColumn;
    private System.Windows.Forms.ColumnHeader createdAtColumn;
    private System.Windows.Forms.ColumnHeader modifiedAtColumn;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.Label languages_title;

    private System.Windows.Forms.Button create_button;
    private System.Windows.Forms.Button delete_button;
    private System.Windows.Forms.TextBox create_language_textbox;
    private System.Windows.Forms.TextBox delete_language_textbox;

    #endregion
}