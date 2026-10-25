using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class MainForm : Form
    {
       
        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelMain;
        private Label lblLogo;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnDashboard;
        private Button btnOrders;
        private Button btnInventory;
        private Button btnSettings;
        private Button activeNavButton;

        private readonly Color colorSidebarBg = Color.FromArgb(24, 28, 36);
        private readonly Color colorHeaderBg = Color.FromArgb(32, 38, 48);
        private readonly Color colorMainBg = Color.FromArgb(240, 242, 245);
        private readonly Color colorAccent = Color.FromArgb(0, 122, 255);
        private readonly Color colorNavHover = Color.FromArgb(40, 48, 62);
        private readonly Color colorTextLight = Color.FromArgb(240, 240, 240);
        private readonly Color colorTextMuted = Color.FromArgb(140, 150, 165);

        public Size MinClientSize { get; private set; }

#pragma warning disable CS8618 
        public MainForm()
#pragma warning restore CS8618
        {
            InitializeCustomLayout();
            LoadDashboardView();
        }

        private void InitializeCustomLayout()
        {
        
            this.Text = "Professional Management System";
            this.Size = new Size(1200, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinClientSize = new Size(900, 600);
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            this.FormBorderStyle = FormBorderStyle.Sizable;

            
            panelSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 220,
                BackColor = colorSidebarBg,
                Padding = new Padding(10)
            };

            lblLogo = new Label
            {
                Text = "NEXUS ADMIN",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = colorAccent,
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnDashboard = CreateNavButton("Dashboard", 70);
            btnOrders = CreateNavButton("Orders", 125);
            btnInventory = CreateNavButton("Inventory", 180);
            btnSettings = CreateNavButton("Settings", 235);

            panelSidebar.Controls.AddRange(new Control[] { btnSettings, btnInventory, btnOrders, btnDashboard, lblLogo });

            
            panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = colorHeaderBg,
                Padding = new Padding(20, 0, 20, 0)
            };

            lblTitle = new Label
            {
                Text = "Dashboard",
                Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold),
                ForeColor = colorTextLight,
                AutoSize = true,
                Location = new Point(20, 18)
            };

            txtSearch = new TextBox
            {
                Text = "Search records...",
                Font = new Font("Segoe UI", 10F),
                Width = 250,
                Location = new Point(880, 18),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                ForeColor = Color.Gray
            };
            txtSearch.GotFocus += (s, e) => { if (txtSearch.Text == "Search records...") txtSearch.Text = ""; };
            txtSearch.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "Search records..."; };

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(txtSearch);

            
            panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = colorMainBg,
                Padding = new Padding(25)
            };

            
            this.Controls.Add(panelMain);
            this.Controls.Add(panelHeader);
            this.Controls.Add(panelSidebar);

           
            SetActiveNavButton(btnDashboard);
        }

        private Button CreateNavButton(string text, int top)
        {
            Button btn = new Button
            {
                Text = "   " + text,
                Top = top,
                Left = 10,
                Width = 200,
                Height = 45,
                FlatStyle = FlatStyle.Flat,
                ForeColor = colorTextMuted,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = colorNavHover;

            btn.Click += (sender, e) =>
            {
                SetActiveNavButton(btn);
                lblTitle.Text = text;
                RenderPanelContent(text);
            };

            return btn;
        }

        private void SetActiveNavButton(Button btn)
        {
            if (activeNavButton != null)
            {
                activeNavButton.BackColor = colorSidebarBg;
                activeNavButton.ForeColor = colorTextMuted;
                activeNavButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }

            activeNavButton = btn;
            activeNavButton.BackColor = colorAccent;
            activeNavButton.ForeColor = Color.White;
            activeNavButton.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
        }

        private void RenderPanelContent(string viewName)
        {
            panelMain.Controls.Clear();

            if (viewName == "Dashboard")
            {
                LoadDashboardView();
            }
            else
            {
                Label placeholder = new Label
                {
                    Text = $"{viewName} Module View",
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(100, 110, 120),
                    AutoSize = true,
                    Location = new Point(30, 30)
                };
                panelMain.Controls.Add(placeholder);
            }
        }

        private void LoadDashboardView()
        {
           
            Panel card1 = CreateMetricCard("Total Revenue", "$124,500.00", Color.FromArgb(46, 204, 113), 25);
            Panel card2 = CreateMetricCard("Active Orders", "1,248", Color.FromArgb(52, 152, 219), 310);
            Panel card3 = CreateMetricCard("System Users", "856", Color.FromArgb(155, 89, 182), 595);

           
            DataGridView dgv = new DataGridView
            {
                Location = new Point(25, 160),
                Width = 840,
                Height = 460,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                RowHeadersVisible = false,
                AllowUserToAddRows = false
            };

           
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 38, 48);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 252);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.RowTemplate.Height = 35;

           
            dgv.Columns.Add("OrderID", "Order ID");
            dgv.Columns.Add("Customer", "Customer Name");
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("Amount", "Amount");
            dgv.Columns.Add("Status", "Status");

            dgv.Rows.Add("#ORD-8921", "Sarah Jenkins", "2026-03-28", "$450.00", "Completed");
            dgv.Rows.Add("#ORD-8922", "Tech Corp LLC", "2026-03-28", "$1,200.00", "Processing");
            dgv.Rows.Add("#ORD-8923", "Michael Scott", "2026-03-29", "$89.99", "Shipped");
            dgv.Rows.Add("#ORD-8924", "Amanda Lewis", "2026-03-29", "$310.50", "Completed");

            panelMain.Controls.Add(card1);
            panelMain.Controls.Add(card2);
            panelMain.Controls.Add(card3);
            panelMain.Controls.Add(dgv);
        }

        private Panel CreateMetricCard(string title, string value, Color accentColor, int left)
        {
            Panel card = new Panel
            {
                Location = new Point(left, 20),
                Size = new Size(260, 110),
                BackColor = Color.White,
                Padding = new Padding(15)
            };

            Panel accentBar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 5,
                BackColor = accentColor
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                ForeColor = colorTextMuted,
                Location = new Point(20, 18),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(18, 45),
                AutoSize = true
            };

            card.Controls.Add(accentBar);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
