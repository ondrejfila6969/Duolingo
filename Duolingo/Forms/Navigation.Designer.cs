using System.ComponentModel;

namespace Duolingo.Forms;

partial class Navigation
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigation));
        duolingo_title = new System.Windows.Forms.Label();
        users_button = new System.Windows.Forms.Button();
        languages_button = new System.Windows.Forms.Button();
        registrations_button = new System.Windows.Forms.Button();
        imageList1 = new System.Windows.Forms.ImageList(components);
        SuspendLayout();
        // 
        // duolingo_title
        // 
        duolingo_title.BackColor = System.Drawing.SystemColors.Window;
        duolingo_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        duolingo_title.Location = new System.Drawing.Point(241, 31);
        duolingo_title.Name = "duolingo_title";
        duolingo_title.Size = new System.Drawing.Size(540, 60);
        duolingo_title.TabIndex = 0;
        duolingo_title.Text = "SIMPLE DUOLINGO APP";
        // 
        // users_button
        // 
        users_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        users_button.Location = new System.Drawing.Point(75, 278);
        users_button.Name = "users_button";
        users_button.Size = new System.Drawing.Size(240, 64);
        users_button.TabIndex = 1;
        users_button.Text = "Users";
        users_button.UseVisualStyleBackColor = true;
        users_button.Click += users_button_Click;
        // 
        // languages_button
        // 
        languages_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        languages_button.Location = new System.Drawing.Point(379, 278);
        languages_button.Name = "languages_button";
        languages_button.Size = new System.Drawing.Size(240, 64);
        languages_button.TabIndex = 2;
        languages_button.Text = "Languages";
        languages_button.UseVisualStyleBackColor = true;
        languages_button.Click += languages_button_Click;
        // 
        // registrations_button
        // 
        registrations_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        registrations_button.Location = new System.Drawing.Point(684, 278);
        registrations_button.Name = "registrations_button";
        registrations_button.Size = new System.Drawing.Size(240, 64);
        registrations_button.TabIndex = 3;
        registrations_button.Text = "Registrations";
        registrations_button.UseVisualStyleBackColor = true;
        registrations_button.Click += registrations_button_Click;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
        imageList1.ImageSize = new System.Drawing.Size(16, 16);
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // Navigation
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        Controls.Add(registrations_button);
        Controls.Add(languages_button);
        Controls.Add(users_button);
        Controls.Add(duolingo_title);
        DoubleBuffered = true;
        Size = new System.Drawing.Size(1000, 750);
        Load += Navigation_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.Button users_button;
    private System.Windows.Forms.Button languages_button;
    private System.Windows.Forms.Button registrations_button;

    private System.Windows.Forms.Label duolingo_title;

    #endregion
}