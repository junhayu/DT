namespace DT1
{
    partial class FormDT3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            devDept.Eyeshot.SimulationTimeLine simulationTimeLine1 = new devDept.Eyeshot.SimulationTimeLine(System.Drawing.Color.Black, System.Drawing.Color.Orange, System.Drawing.Color.Green, System.Drawing.Color.Red, System.Drawing.Color.LightGray, 1D, true, 0.01D);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.WhiteSmoke, 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(64.0062895995168D, -124.79438226926727D, 110.81242132330227D), 331.10339631698054D, new devDept.Geometry.Quaternion(0.12940952255126034D, 0.22414386804201339D, 0.4829629131445341D, 0.83651630373780794D), devDept.Graphics.projectionType.Perspective, 50D, 43.529448039427621D, false, 0.001D);
            devDept.Eyeshot.BeginningToolBarButton beginningToolBarButton1 = new devDept.Eyeshot.BeginningToolBarButton("Go to beginning", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, false);
            devDept.Eyeshot.PreviousToolBarButton previousToolBarButton1 = new devDept.Eyeshot.PreviousToolBarButton("Go to previous (Ctrl+L)", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, false);
            devDept.Eyeshot.StartToolBarButton startToolBarButton1 = new devDept.Eyeshot.StartToolBarButton("Start the simulation (Ctrl+Space)", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, false);
            devDept.Eyeshot.PauseToolBarButton pauseToolBarButton1 = new devDept.Eyeshot.PauseToolBarButton("Pause the simulation (Ctrl+Space)", devDept.Eyeshot.ToolBarButton.styleType.PushButton, false, false);
            devDept.Eyeshot.NextToolBarButton nextToolBarButton1 = new devDept.Eyeshot.NextToolBarButton("Go to next (Ctrl+R)", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, false);
            devDept.Eyeshot.EndToolBarButton endToolBarButton1 = new devDept.Eyeshot.EndToolBarButton("Go to end", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, false);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalBottomCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(beginningToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(previousToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(startToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(pauseToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(nextToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(endToolBarButton1))});
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar2 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Histogram histogram1 = new devDept.Eyeshot.Histogram(30, 80, "Title", System.Drawing.Color.Blue, System.Drawing.Color.Gray, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.LightYellow, false, true, false, "{0:+0.###;-0.###;0}");
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", false, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D), true);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(1547, 866), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1,
            toolBar2}, new devDept.Eyeshot.Legend[0], histogram1, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, coordinateSystemIcon1, viewCubeIcon1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT3ModelView = new devDept.Eyeshot.Manufacture();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin2Framework.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.kryptonSeparator12 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.button3 = new System.Windows.Forms.Button();
            this.kryptonSeparator8 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.cyberScrollBar8 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label31 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label55 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.kryptonSeparator9 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.button5 = new System.Windows.Forms.Button();
            this.kryptonSeparator7 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.cyberScrollBar7 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label30 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.kryptonSeparator11 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparator5 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.cyberScrollBar6 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.kryptonSeparator10 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparator6 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.cyberScrollBar2 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label24 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.kryptonSeparator4 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.kryptonSeparator3 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.cyberScrollBar4 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.menuMode1 = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.kryptonSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.label32 = new System.Windows.Forms.Label();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.label12 = new System.Windows.Forms.Label();
            this.cyberScrollBar1 = new ReaLTaiizor.Controls.CyberScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.cyberProgressBar2 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.cyberProgressBar1 = new ReaLTaiizor.Controls.CyberProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT3ModelView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator8)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator7)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator5)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator6)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator3)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(3, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(949, 900);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
            this.dataGridView2.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView2_RowPrePaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 189;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 189;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Width = 189;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.Width = 189;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Width = 189;
            // 
            // DT3ModelView
            // 
            this.DT3ModelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DT3ModelView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DT3ModelView.Location = new System.Drawing.Point(16, 27);
            this.DT3ModelView.Name = "DT3ModelView";
            this.DT3ModelView.SimulationTimeLine = simulationTimeLine1;
            this.DT3ModelView.Size = new System.Drawing.Size(1547, 866);
            this.DT3ModelView.StopOnCollision = false;
            this.DT3ModelView.TabIndex = 5;
            this.DT3ModelView.Viewports.Add(viewport1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(1763, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 926);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.DT3ModelView);
            this.panel2.Location = new System.Drawing.Point(21, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1672, 916);
            this.panel2.TabIndex = 7;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1580, 27);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Import";
            this.materialButton1.Type = MaterialSkin2Framework.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Location = new System.Drawing.Point(2750, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 558);
            this.panel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel20, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel19, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel18, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel16, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 530);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel20.Controls.Add(this.label53);
            this.panel20.Controls.Add(this.label47);
            this.panel20.Controls.Add(this.kryptonSeparator12);
            this.panel20.Controls.Add(this.button3);
            this.panel20.Controls.Add(this.kryptonSeparator8);
            this.panel20.Controls.Add(this.cyberScrollBar8);
            this.panel20.Controls.Add(this.label31);
            this.panel20.Controls.Add(this.label38);
            this.panel20.Controls.Add(this.label42);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(437, 352);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(437, 178);
            this.panel20.TabIndex = 26;
            this.panel20.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label53.ForeColor = System.Drawing.SystemColors.Control;
            this.label53.Location = new System.Drawing.Point(86, 158);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 13);
            this.label53.TabIndex = 33;
            this.label53.Text = "18.00";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label47.ForeColor = System.Drawing.Color.IndianRed;
            this.label47.Location = new System.Drawing.Point(13, 52);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(42, 24);
            this.label47.TabIndex = 32;
            this.label47.Text = "NG";
            // 
            // kryptonSeparator12
            // 
            this.kryptonSeparator12.Location = new System.Drawing.Point(282, 79);
            this.kryptonSeparator12.Name = "kryptonSeparator12";
            this.kryptonSeparator12.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator12.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator12.SplitterWidth = 1;
            this.kryptonSeparator12.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator12.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator12.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::DT1.Properties.Resources.빨간_화살표_크기_조정;
            this.button3.Location = new System.Drawing.Point(89, 120);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 38);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // kryptonSeparator8
            // 
            this.kryptonSeparator8.Location = new System.Drawing.Point(147, 79);
            this.kryptonSeparator8.Name = "kryptonSeparator8";
            this.kryptonSeparator8.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator8.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator8.SplitterWidth = 1;
            this.kryptonSeparator8.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator8.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator8.TabIndex = 30;
            // 
            // cyberScrollBar8
            // 
            this.cyberScrollBar8.Alpha = 50;
            this.cyberScrollBar8.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar8.Background = true;
            this.cyberScrollBar8.Background_WidthPen = 3F;
            this.cyberScrollBar8.BackgroundPen = true;
            this.cyberScrollBar8.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar8.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar8.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar8.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar8.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar8.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar8.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar8.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar8.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar8.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar8.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar8.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar8.Enabled = false;
            this.cyberScrollBar8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar8.Lighting = false;
            this.cyberScrollBar8.LinearGradient_Background = false;
            this.cyberScrollBar8.LinearGradient_Value = false;
            this.cyberScrollBar8.LinearGradientPen = false;
            this.cyberScrollBar8.Location = new System.Drawing.Point(17, 91);
            this.cyberScrollBar8.Maximum = 100;
            this.cyberScrollBar8.Minimum = 0;
            this.cyberScrollBar8.Name = "cyberScrollBar8";
            this.cyberScrollBar8.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar8.PenWidth = 10;
            this.cyberScrollBar8.RGB = false;
            this.cyberScrollBar8.Rounding = false;
            this.cyberScrollBar8.RoundingInt = 70;
            this.cyberScrollBar8.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar8.TabIndex = 13;
            this.cyberScrollBar8.Tag = "Cyber";
            this.cyberScrollBar8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar8.ThumbSize = 130;
            this.cyberScrollBar8.Timer_RGB = 300;
            this.cyberScrollBar8.Value = 50;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.SystemColors.Control;
            this.label31.Location = new System.Drawing.Point(13, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(243, 19);
            this.label31.TabIndex = 11;
            this.label31.Text = "Geometric - Roundness 1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.ForeColor = System.Drawing.SystemColors.Control;
            this.label38.Location = new System.Drawing.Point(125, 63);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 13);
            this.label38.TabIndex = 29;
            this.label38.Text = "19.95";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.ForeColor = System.Drawing.SystemColors.Control;
            this.label42.Location = new System.Drawing.Point(260, 63);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(44, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "20.05";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel19.Controls.Add(this.label55);
            this.panel19.Controls.Add(this.label46);
            this.panel19.Controls.Add(this.kryptonSeparator9);
            this.panel19.Controls.Add(this.button5);
            this.panel19.Controls.Add(this.kryptonSeparator7);
            this.panel19.Controls.Add(this.cyberScrollBar7);
            this.panel19.Controls.Add(this.label30);
            this.panel19.Controls.Add(this.label39);
            this.panel19.Controls.Add(this.label37);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 352);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(437, 178);
            this.panel19.TabIndex = 26;
            this.panel19.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label55.ForeColor = System.Drawing.SystemColors.Control;
            this.label55.Location = new System.Drawing.Point(258, 158);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(44, 13);
            this.label55.TabIndex = 33;
            this.label55.Text = "20.03";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label46.Location = new System.Drawing.Point(16, 52);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(74, 24);
            this.label46.TabIndex = 32;
            this.label46.Text = "PASS";
            // 
            // kryptonSeparator9
            // 
            this.kryptonSeparator9.Location = new System.Drawing.Point(283, 79);
            this.kryptonSeparator9.Name = "kryptonSeparator9";
            this.kryptonSeparator9.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator9.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator9.SplitterWidth = 1;
            this.kryptonSeparator9.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator9.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator9.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button5.Image = global::DT1.Properties.Resources.화살표_크기_조정;
            this.button5.Location = new System.Drawing.Point(261, 120);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 38);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // kryptonSeparator7
            // 
            this.kryptonSeparator7.Location = new System.Drawing.Point(152, 79);
            this.kryptonSeparator7.Name = "kryptonSeparator7";
            this.kryptonSeparator7.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator7.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator7.SplitterWidth = 1;
            this.kryptonSeparator7.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator7.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator7.TabIndex = 30;
            this.kryptonSeparator7.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.kryptonSeparator7_SplitterMoved);
            // 
            // cyberScrollBar7
            // 
            this.cyberScrollBar7.Alpha = 50;
            this.cyberScrollBar7.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar7.Background = true;
            this.cyberScrollBar7.Background_WidthPen = 3F;
            this.cyberScrollBar7.BackgroundPen = true;
            this.cyberScrollBar7.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar7.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar7.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar7.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar7.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar7.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar7.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar7.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar7.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar7.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar7.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar7.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar7.Enabled = false;
            this.cyberScrollBar7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar7.Lighting = false;
            this.cyberScrollBar7.LinearGradient_Background = false;
            this.cyberScrollBar7.LinearGradient_Value = false;
            this.cyberScrollBar7.LinearGradientPen = false;
            this.cyberScrollBar7.Location = new System.Drawing.Point(20, 91);
            this.cyberScrollBar7.Maximum = 100;
            this.cyberScrollBar7.Minimum = 0;
            this.cyberScrollBar7.Name = "cyberScrollBar7";
            this.cyberScrollBar7.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar7.PenWidth = 10;
            this.cyberScrollBar7.RGB = false;
            this.cyberScrollBar7.Rounding = false;
            this.cyberScrollBar7.RoundingInt = 70;
            this.cyberScrollBar7.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar7.TabIndex = 13;
            this.cyberScrollBar7.Tag = "Cyber";
            this.cyberScrollBar7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar7.ThumbSize = 130;
            this.cyberScrollBar7.Timer_RGB = 300;
            this.cyberScrollBar7.Value = 50;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(16, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(249, 19);
            this.label30.TabIndex = 11;
            this.label30.Text = "Geometric - Squareness 1";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.ForeColor = System.Drawing.SystemColors.Control;
            this.label39.Location = new System.Drawing.Point(267, 63);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 13);
            this.label39.TabIndex = 29;
            this.label39.Text = "20.05";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.ForeColor = System.Drawing.SystemColors.Control;
            this.label37.Location = new System.Drawing.Point(130, 63);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 13);
            this.label37.TabIndex = 29;
            this.label37.Text = "19.95";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel18.Controls.Add(this.label52);
            this.panel18.Controls.Add(this.label48);
            this.panel18.Controls.Add(this.button2);
            this.panel18.Controls.Add(this.kryptonSeparator11);
            this.panel18.Controls.Add(this.kryptonSeparator5);
            this.panel18.Controls.Add(this.cyberScrollBar6);
            this.panel18.Controls.Add(this.label29);
            this.panel18.Controls.Add(this.label35);
            this.panel18.Controls.Add(this.label41);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(437, 176);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(437, 176);
            this.panel18.TabIndex = 26;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label52.ForeColor = System.Drawing.SystemColors.Control;
            this.label52.Location = new System.Drawing.Point(344, 163);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(44, 13);
            this.label52.TabIndex = 33;
            this.label52.Text = "22.00";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label48.ForeColor = System.Drawing.Color.IndianRed;
            this.label48.Location = new System.Drawing.Point(13, 57);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(42, 24);
            this.label48.TabIndex = 32;
            this.label48.Text = "NG";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::DT1.Properties.Resources.빨간_화살표_크기_조정;
            this.button2.Location = new System.Drawing.Point(347, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 38);
            this.button2.TabIndex = 34;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // kryptonSeparator11
            // 
            this.kryptonSeparator11.Location = new System.Drawing.Point(282, 84);
            this.kryptonSeparator11.Name = "kryptonSeparator11";
            this.kryptonSeparator11.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator11.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator11.SplitterWidth = 1;
            this.kryptonSeparator11.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator11.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator11.TabIndex = 30;
            // 
            // kryptonSeparator5
            // 
            this.kryptonSeparator5.Location = new System.Drawing.Point(147, 84);
            this.kryptonSeparator5.Name = "kryptonSeparator5";
            this.kryptonSeparator5.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator5.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator5.SplitterWidth = 1;
            this.kryptonSeparator5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator5.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator5.TabIndex = 30;
            // 
            // cyberScrollBar6
            // 
            this.cyberScrollBar6.Alpha = 50;
            this.cyberScrollBar6.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar6.Background = true;
            this.cyberScrollBar6.Background_WidthPen = 3F;
            this.cyberScrollBar6.BackgroundPen = true;
            this.cyberScrollBar6.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar6.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar6.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar6.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar6.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar6.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar6.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar6.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar6.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar6.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar6.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar6.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar6.Enabled = false;
            this.cyberScrollBar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar6.Lighting = false;
            this.cyberScrollBar6.LinearGradient_Background = false;
            this.cyberScrollBar6.LinearGradient_Value = false;
            this.cyberScrollBar6.LinearGradientPen = false;
            this.cyberScrollBar6.Location = new System.Drawing.Point(17, 96);
            this.cyberScrollBar6.Maximum = 100;
            this.cyberScrollBar6.Minimum = 0;
            this.cyberScrollBar6.Name = "cyberScrollBar6";
            this.cyberScrollBar6.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar6.PenWidth = 10;
            this.cyberScrollBar6.RGB = false;
            this.cyberScrollBar6.Rounding = false;
            this.cyberScrollBar6.RoundingInt = 70;
            this.cyberScrollBar6.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar6.TabIndex = 13;
            this.cyberScrollBar6.Tag = "Cyber";
            this.cyberScrollBar6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar6.ThumbSize = 130;
            this.cyberScrollBar6.Timer_RGB = 300;
            this.cyberScrollBar6.Value = 50;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(13, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(254, 19);
            this.label29.TabIndex = 11;
            this.label29.Text = "Geometric - Straightness 2";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.ForeColor = System.Drawing.SystemColors.Control;
            this.label35.Location = new System.Drawing.Point(125, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 13);
            this.label35.TabIndex = 29;
            this.label35.Text = "19.95";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.ForeColor = System.Drawing.SystemColors.Control;
            this.label41.Location = new System.Drawing.Point(260, 68);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 13);
            this.label41.TabIndex = 29;
            this.label41.Text = "20.05";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel17.Controls.Add(this.label54);
            this.panel17.Controls.Add(this.label45);
            this.panel17.Controls.Add(this.button4);
            this.panel17.Controls.Add(this.kryptonSeparator10);
            this.panel17.Controls.Add(this.kryptonSeparator6);
            this.panel17.Controls.Add(this.cyberScrollBar2);
            this.panel17.Controls.Add(this.label24);
            this.panel17.Controls.Add(this.label36);
            this.panel17.Controls.Add(this.label40);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 176);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(437, 176);
            this.panel17.TabIndex = 26;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label54.ForeColor = System.Drawing.SystemColors.Control;
            this.label54.Location = new System.Drawing.Point(206, 163);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 13);
            this.label54.TabIndex = 33;
            this.label54.Text = "20.00";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label45.Location = new System.Drawing.Point(16, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(74, 24);
            this.label45.TabIndex = 32;
            this.label45.Text = "PASS";
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Image = global::DT1.Properties.Resources.화살표_크기_조정;
            this.button4.Location = new System.Drawing.Point(209, 125);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 38);
            this.button4.TabIndex = 32;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // kryptonSeparator10
            // 
            this.kryptonSeparator10.Location = new System.Drawing.Point(283, 84);
            this.kryptonSeparator10.Name = "kryptonSeparator10";
            this.kryptonSeparator10.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator10.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator10.SplitterWidth = 1;
            this.kryptonSeparator10.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator10.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator10.TabIndex = 30;
            // 
            // kryptonSeparator6
            // 
            this.kryptonSeparator6.Location = new System.Drawing.Point(152, 84);
            this.kryptonSeparator6.Name = "kryptonSeparator6";
            this.kryptonSeparator6.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator6.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator6.SplitterWidth = 1;
            this.kryptonSeparator6.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator6.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator6.TabIndex = 30;
            // 
            // cyberScrollBar2
            // 
            this.cyberScrollBar2.Alpha = 50;
            this.cyberScrollBar2.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar2.Background = true;
            this.cyberScrollBar2.Background_WidthPen = 3F;
            this.cyberScrollBar2.BackgroundPen = true;
            this.cyberScrollBar2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar2.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar2.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar2.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar2.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar2.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar2.Enabled = false;
            this.cyberScrollBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar2.Lighting = false;
            this.cyberScrollBar2.LinearGradient_Background = false;
            this.cyberScrollBar2.LinearGradient_Value = false;
            this.cyberScrollBar2.LinearGradientPen = false;
            this.cyberScrollBar2.Location = new System.Drawing.Point(20, 96);
            this.cyberScrollBar2.Maximum = 100;
            this.cyberScrollBar2.Minimum = 0;
            this.cyberScrollBar2.Name = "cyberScrollBar2";
            this.cyberScrollBar2.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar2.PenWidth = 10;
            this.cyberScrollBar2.RGB = false;
            this.cyberScrollBar2.Rounding = false;
            this.cyberScrollBar2.RoundingInt = 70;
            this.cyberScrollBar2.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar2.TabIndex = 14;
            this.cyberScrollBar2.Tag = "Cyber";
            this.cyberScrollBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar2.ThumbSize = 130;
            this.cyberScrollBar2.Timer_RGB = 300;
            this.cyberScrollBar2.Value = 50;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.SystemColors.Control;
            this.label24.Location = new System.Drawing.Point(16, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(254, 19);
            this.label24.TabIndex = 11;
            this.label24.Text = "Geometric - Straightness 1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.ForeColor = System.Drawing.SystemColors.Control;
            this.label36.Location = new System.Drawing.Point(129, 68);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(44, 13);
            this.label36.TabIndex = 29;
            this.label36.Text = "19.95";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.ForeColor = System.Drawing.SystemColors.Control;
            this.label40.Location = new System.Drawing.Point(267, 68);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 13);
            this.label40.TabIndex = 29;
            this.label40.Text = "20.05";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel16.Controls.Add(this.label51);
            this.panel16.Controls.Add(this.button1);
            this.panel16.Controls.Add(this.label49);
            this.panel16.Controls.Add(this.kryptonSeparator4);
            this.panel16.Controls.Add(this.kryptonSeparator3);
            this.panel16.Controls.Add(this.cyberScrollBar4);
            this.panel16.Controls.Add(this.label34);
            this.panel16.Controls.Add(this.label33);
            this.panel16.Controls.Add(this.label13);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(437, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(437, 176);
            this.panel16.TabIndex = 26;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label51.ForeColor = System.Drawing.SystemColors.Control;
            this.label51.Location = new System.Drawing.Point(300, 159);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(44, 13);
            this.label51.TabIndex = 33;
            this.label51.Text = "21.00";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DT1.Properties.Resources.빨간_화살표_크기_조정;
            this.button1.Location = new System.Drawing.Point(303, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 38);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label49.ForeColor = System.Drawing.Color.IndianRed;
            this.label49.Location = new System.Drawing.Point(13, 54);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(42, 24);
            this.label49.TabIndex = 32;
            this.label49.Text = "NG";
            // 
            // kryptonSeparator4
            // 
            this.kryptonSeparator4.Location = new System.Drawing.Point(282, 80);
            this.kryptonSeparator4.Name = "kryptonSeparator4";
            this.kryptonSeparator4.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator4.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator4.SplitterWidth = 1;
            this.kryptonSeparator4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator4.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator4.TabIndex = 30;
            // 
            // kryptonSeparator3
            // 
            this.kryptonSeparator3.Location = new System.Drawing.Point(147, 80);
            this.kryptonSeparator3.Name = "kryptonSeparator3";
            this.kryptonSeparator3.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator3.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator3.SplitterWidth = 1;
            this.kryptonSeparator3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator3.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator3.TabIndex = 30;
            // 
            // cyberScrollBar4
            // 
            this.cyberScrollBar4.Alpha = 50;
            this.cyberScrollBar4.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar4.Background = true;
            this.cyberScrollBar4.Background_WidthPen = 3F;
            this.cyberScrollBar4.BackgroundPen = true;
            this.cyberScrollBar4.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar4.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar4.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar4.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar4.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar4.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar4.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar4.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar4.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar4.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar4.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar4.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar4.Enabled = false;
            this.cyberScrollBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar4.Lighting = false;
            this.cyberScrollBar4.LinearGradient_Background = false;
            this.cyberScrollBar4.LinearGradient_Value = false;
            this.cyberScrollBar4.LinearGradientPen = false;
            this.cyberScrollBar4.Location = new System.Drawing.Point(17, 92);
            this.cyberScrollBar4.Maximum = 100;
            this.cyberScrollBar4.Minimum = 0;
            this.cyberScrollBar4.Name = "cyberScrollBar4";
            this.cyberScrollBar4.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar4.PenWidth = 10;
            this.cyberScrollBar4.RGB = false;
            this.cyberScrollBar4.Rounding = false;
            this.cyberScrollBar4.RoundingInt = 70;
            this.cyberScrollBar4.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar4.TabIndex = 13;
            this.cyberScrollBar4.Tag = "Cyber";
            this.cyberScrollBar4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar4.ThumbSize = 135;
            this.cyberScrollBar4.Timer_RGB = 300;
            this.cyberScrollBar4.Value = 50;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.ForeColor = System.Drawing.SystemColors.Control;
            this.label34.Location = new System.Drawing.Point(260, 64);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "20.05";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.SystemColors.Control;
            this.label33.Location = new System.Drawing.Point(125, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "19.95";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(13, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(270, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Dimensional Tolerance - DT2";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel14.Controls.Add(this.label50);
            this.panel14.Controls.Add(this.menuMode1);
            this.panel14.Controls.Add(this.label44);
            this.panel14.Controls.Add(this.kryptonSeparator2);
            this.panel14.Controls.Add(this.label32);
            this.panel14.Controls.Add(this.kryptonSeparator1);
            this.panel14.Controls.Add(this.label12);
            this.panel14.Controls.Add(this.cyberScrollBar1);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(437, 176);
            this.panel14.TabIndex = 24;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label50.ForeColor = System.Drawing.SystemColors.Control;
            this.label50.Location = new System.Drawing.Point(145, 159);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(44, 13);
            this.label50.TabIndex = 33;
            this.label50.Text = "19.95";
            // 
            // menuMode1
            // 
            this.menuMode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuMode1.FlatAppearance.BorderSize = 0;
            this.menuMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuMode1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.menuMode1.Image = global::DT1.Properties.Resources.화살표_크기_조정;
            this.menuMode1.Location = new System.Drawing.Point(148, 121);
            this.menuMode1.Margin = new System.Windows.Forms.Padding(0);
            this.menuMode1.Name = "menuMode1";
            this.menuMode1.Size = new System.Drawing.Size(25, 38);
            this.menuMode1.TabIndex = 32;
            this.menuMode1.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label44.Location = new System.Drawing.Point(16, 54);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(74, 24);
            this.label44.TabIndex = 31;
            this.label44.Text = "PASS";
            // 
            // kryptonSeparator2
            // 
            this.kryptonSeparator2.Location = new System.Drawing.Point(283, 80);
            this.kryptonSeparator2.Name = "kryptonSeparator2";
            this.kryptonSeparator2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator2.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator2.SplitterWidth = 1;
            this.kryptonSeparator2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator2.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator2.TabIndex = 30;
            this.kryptonSeparator2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.kryptonSeparator2_SplitterMoved);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.Location = new System.Drawing.Point(267, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 13);
            this.label32.TabIndex = 29;
            this.label32.Text = "20.05";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(152, 80);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSeparator1.Size = new System.Drawing.Size(3, 15);
            this.kryptonSeparator1.SplitterWidth = 1;
            this.kryptonSeparator1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Separator.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Separator.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSeparator1.StateCommon.Separator.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSeparator1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(130, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "19.95";
            // 
            // cyberScrollBar1
            // 
            this.cyberScrollBar1.Alpha = 50;
            this.cyberScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.cyberScrollBar1.Background = true;
            this.cyberScrollBar1.Background_WidthPen = 3F;
            this.cyberScrollBar1.BackgroundPen = true;
            this.cyberScrollBar1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar1.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar1.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberScrollBar1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberScrollBar1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberScrollBar1.ColorScrollBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberScrollBar1.ColorScrollBar_Transparency = 255;
            this.cyberScrollBar1.CyberScrollBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberScrollBar1.Enabled = false;
            this.cyberScrollBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberScrollBar1.Lighting = false;
            this.cyberScrollBar1.LinearGradient_Background = false;
            this.cyberScrollBar1.LinearGradient_Value = false;
            this.cyberScrollBar1.LinearGradientPen = false;
            this.cyberScrollBar1.Location = new System.Drawing.Point(20, 92);
            this.cyberScrollBar1.Maximum = 100;
            this.cyberScrollBar1.Minimum = 0;
            this.cyberScrollBar1.Name = "cyberScrollBar1";
            this.cyberScrollBar1.OrientationValue = System.Windows.Forms.Orientation.Horizontal;
            this.cyberScrollBar1.PenWidth = 10;
            this.cyberScrollBar1.RGB = false;
            this.cyberScrollBar1.Rounding = false;
            this.cyberScrollBar1.RoundingInt = 70;
            this.cyberScrollBar1.Size = new System.Drawing.Size(401, 26);
            this.cyberScrollBar1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberScrollBar1.TabIndex = 13;
            this.cyberScrollBar1.Tag = "Cyber";
            this.cyberScrollBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberScrollBar1.ThumbSize = 130;
            this.cyberScrollBar1.Timer_RGB = 300;
            this.cyberScrollBar1.Value = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dimensional Tolerance - DT1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(21, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1672, 40);
            this.panel6.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "3차원 포인트 좌표";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1763, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 36);
            this.panel4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "좌표 데이터";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(2750, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 39);
            this.panel5.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "검사 항목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "검사 내용";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(2750, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(874, 39);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Location = new System.Drawing.Point(2750, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(874, 214);
            this.panel8.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label28, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(696, 72);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(178, 108);
            this.label28.TabIndex = 23;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel12.Controls.Add(this.label21);
            this.panel12.Controls.Add(this.label23);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(522, 72);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(174, 108);
            this.panel12.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(0, 31);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 77);
            this.label21.TabIndex = 20;
            this.label21.Text = "0";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 31);
            this.label23.TabIndex = 19;
            this.label23.Text = "Z";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel13.Controls.Add(this.label26);
            this.panel13.Controls.Add(this.label27);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(174, 72);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(174, 108);
            this.panel13.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label26.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(0, 31);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(174, 77);
            this.label26.TabIndex = 20;
            this.label26.Text = "0";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Margin = new System.Windows.Forms.Padding(0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(174, 31);
            this.label27.TabIndex = 19;
            this.label27.Text = "X";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel11.Controls.Add(this.label25);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(348, 72);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(174, 108);
            this.panel11.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label25.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.SystemColors.Control;
            this.label25.Location = new System.Drawing.Point(0, 31);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(174, 77);
            this.label25.TabIndex = 20;
            this.label25.Text = "0";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.SystemColors.Control;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(174, 31);
            this.label22.TabIndex = 19;
            this.label22.Text = "Y";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(0, 72);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 108);
            this.label20.TabIndex = 17;
            this.label20.Text = "Workplace Coordinate System";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(696, 36);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 36);
            this.label19.TabIndex = 16;
            this.label19.Text = "1";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(522, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 36);
            this.label18.TabIndex = 15;
            this.label18.Text = "2. NG";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(348, 36);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 36);
            this.label17.TabIndex = 14;
            this.label17.Text = "1";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(174, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 36);
            this.label16.TabIndex = 13;
            this.label16.Text = "1. PASS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(0, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 36);
            this.label15.TabIndex = 12;
            this.label15.Text = "Quality Issue";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(696, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 36);
            this.label14.TabIndex = 11;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(522, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 36);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(348, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 36);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(174, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "None";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 36);
            this.label11.TabIndex = 7;
            this.label11.Text = "Part ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(2750, 823);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(874, 39);
            this.panel9.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "공구수명 추정 값";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel10.Controls.Add(this.label43);
            this.panel10.Controls.Add(this.cyberProgressBar2);
            this.panel10.Controls.Add(this.cyberProgressBar1);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(2750, 857);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(874, 120);
            this.panel10.TabIndex = 23;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.ForeColor = System.Drawing.SystemColors.Control;
            this.label43.Location = new System.Drawing.Point(5, 85);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(140, 13);
            this.label43.TabIndex = 16;
            this.label43.Text = "OP-020 D16.0-E/M";
            // 
            // cyberProgressBar2
            // 
            this.cyberProgressBar2.Alpha = 50;
            this.cyberProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar2.Background = true;
            this.cyberProgressBar2.Background_WidthPen = 3F;
            this.cyberProgressBar2.BackgroundPen = true;
            this.cyberProgressBar2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar2.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar2.ColorValue_Transparency = 200;
            this.cyberProgressBar2.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar2.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar2.Lighting = false;
            this.cyberProgressBar2.LinearGradient_Background = false;
            this.cyberProgressBar2.LinearGradient_Value = false;
            this.cyberProgressBar2.LinearGradientPen = false;
            this.cyberProgressBar2.Location = new System.Drawing.Point(189, 74);
            this.cyberProgressBar2.Maximum = 100;
            this.cyberProgressBar2.Minimum = 0;
            this.cyberProgressBar2.Name = "cyberProgressBar2";
            this.cyberProgressBar2.PenWidth = 10;
            this.cyberProgressBar2.ProgressText = true;
            this.cyberProgressBar2.RGB = false;
            this.cyberProgressBar2.Rounding = true;
            this.cyberProgressBar2.RoundingInt = 70;
            this.cyberProgressBar2.Size = new System.Drawing.Size(666, 34);
            this.cyberProgressBar2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar2.StartDrawingValue = 0;
            this.cyberProgressBar2.TabIndex = 15;
            this.cyberProgressBar2.Tag = "Cyber";
            this.cyberProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar2.Timer_RGB = 300;
            this.cyberProgressBar2.Value = 60;
            // 
            // cyberProgressBar1
            // 
            this.cyberProgressBar1.Alpha = 50;
            this.cyberProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.cyberProgressBar1.Background = true;
            this.cyberProgressBar1.Background_WidthPen = 3F;
            this.cyberProgressBar1.BackgroundPen = true;
            this.cyberProgressBar1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.cyberProgressBar1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberProgressBar1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberProgressBar1.ColorProgressBar = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberProgressBar1.ColorValue_Transparency = 200;
            this.cyberProgressBar1.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberProgressBar1.Font = new System.Drawing.Font("Arial", 11F);
            this.cyberProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberProgressBar1.Lighting = false;
            this.cyberProgressBar1.LinearGradient_Background = false;
            this.cyberProgressBar1.LinearGradient_Value = false;
            this.cyberProgressBar1.LinearGradientPen = false;
            this.cyberProgressBar1.Location = new System.Drawing.Point(189, 23);
            this.cyberProgressBar1.Maximum = 100;
            this.cyberProgressBar1.Minimum = 0;
            this.cyberProgressBar1.Name = "cyberProgressBar1";
            this.cyberProgressBar1.PenWidth = 10;
            this.cyberProgressBar1.ProgressText = true;
            this.cyberProgressBar1.RGB = false;
            this.cyberProgressBar1.Rounding = true;
            this.cyberProgressBar1.RoundingInt = 70;
            this.cyberProgressBar1.Size = new System.Drawing.Size(666, 34);
            this.cyberProgressBar1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberProgressBar1.StartDrawingValue = 0;
            this.cyberProgressBar1.TabIndex = 14;
            this.cyberProgressBar1.Tag = "Cyber";
            this.cyberProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberProgressBar1.Timer_RGB = 300;
            this.cyberProgressBar1.Value = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(5, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "OP-020 D32.0-CUTTER";
            // 
            // FormDT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(3636, 990);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDT3";
            this.Text = "frmAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT3ModelView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator8)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator7)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator5)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator6)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator3)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private devDept.Eyeshot.Manufacture DT3ModelView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private MaterialSkin2Framework.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label28;
        
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel20;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel19;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar7;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel18;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel16;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel14;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar1;
        private System.Windows.Forms.Label label6;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar2;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar1;
        private ReaLTaiizor.Controls.CyberScrollBar cyberScrollBar2;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator12;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator8;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator9;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator7;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator11;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator5;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label41;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator10;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label40;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator4;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator3;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button menuMode1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button button4;
    }
}