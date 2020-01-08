namespace KryptonIssue
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
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.gdiPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.simpleGDIControl2 = new KryptonIssue.SimpleGDIControl();
            this.emptyPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.glControlPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.simpleGLControl1 = new KryptonIssue.SimpleGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdiPage)).BeginInit();
            this.gdiPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glControlPage)).BeginInit();
            this.glControlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Location = new System.Drawing.Point(26, 23);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.gdiPage,
            this.emptyPage,
            this.glControlPage});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(334, 274);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // gdiPage
            // 
            this.gdiPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.gdiPage.Controls.Add(this.simpleGDIControl2);
            this.gdiPage.Flags = 65534;
            this.gdiPage.LastVisibleSet = true;
            this.gdiPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.gdiPage.Name = "gdiPage";
            this.gdiPage.Size = new System.Drawing.Size(332, 247);
            this.gdiPage.Text = "GDI";
            this.gdiPage.ToolTipTitle = "Page ToolTip";
            this.gdiPage.UniqueName = "0d0f25edcf46444d9edbf1aeba72d5e6";
            // 
            // simpleGDIControl2
            // 
            this.simpleGDIControl2.Location = new System.Drawing.Point(13, 14);
            this.simpleGDIControl2.Name = "simpleGDIControl2";
            this.simpleGDIControl2.Size = new System.Drawing.Size(305, 224);
            this.simpleGDIControl2.TabIndex = 1;
            this.simpleGDIControl2.Text = "simpleGDIControl2";
            // 
            // emptyPage
            // 
            this.emptyPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.emptyPage.Flags = 65534;
            this.emptyPage.LastVisibleSet = true;
            this.emptyPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.emptyPage.Name = "emptyPage";
            this.emptyPage.Size = new System.Drawing.Size(332, 247);
            this.emptyPage.Text = "Empty";
            this.emptyPage.ToolTipTitle = "Page ToolTip";
            this.emptyPage.UniqueName = "0a98fb0a29674f1fb2f463306df3e4c5";
            // 
            // glControlPage
            // 
            this.glControlPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.glControlPage.Controls.Add(this.simpleGLControl1);
            this.glControlPage.Flags = 65534;
            this.glControlPage.LastVisibleSet = true;
            this.glControlPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.glControlPage.Name = "glControlPage";
            this.glControlPage.Size = new System.Drawing.Size(332, 247);
            this.glControlPage.Text = "GLControl";
            this.glControlPage.ToolTipTitle = "Page ToolTip";
            this.glControlPage.UniqueName = "adf4e78c47c14c95b8c4755f500f56fe";
            // 
            // simpleGLControl1
            // 
            this.simpleGLControl1.BackColor = System.Drawing.Color.Black;
            this.simpleGLControl1.Location = new System.Drawing.Point(76, 46);
            this.simpleGLControl1.Name = "simpleGLControl1";
            this.simpleGLControl1.Size = new System.Drawing.Size(150, 150);
            this.simpleGLControl1.TabIndex = 1;
            this.simpleGLControl1.VSync = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "Form1";
            this.Text = "GLIssue Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdiPage)).EndInit();
            this.gdiPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptyPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glControlPage)).EndInit();
            this.glControlPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage gdiPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage emptyPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage glControlPage;
        private SimpleGDIControl simpleGDIControl2;
        private SimpleGLControl simpleGLControl1;
    }
}

