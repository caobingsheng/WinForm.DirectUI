using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using WinForm.DirectUI.Forms;

namespace WinForm.DirectUI.Demo
{
    public partial class FrmDemo : UIForm
    {
        private UIButton btnOut;
        private UIButton btnInner;
        private UIButton btnInner2;
        private UILabel label;
        private UIProgress progress;
        private UILine line;
        private UIImage image;
        private UIMarquee marquee;
        private UILink link;
        private UILink link2;

        public FrmDemo()
        {
            InitializeComponent();

            image = new UIImage();
            image.Dock = DockStyle.Right;
            image.Width = 400;
            UIControls.Add(image);
            //
            line = new UILine();
            line.Location = new Point(300, 270);
            line.Size = new Size(500, 50);
            line.LineBlendStyle = BlendStyle.FadeInFadeOut;
            line.LineWidth = 2;
            line.LineDashStyle = DashStyle.Dash;
            UIControls.Add(line);
            //
            label = new UILabel();
            label.Location = new Point(250, 200);
            label.Size = new Size(100, 50);
            label.Font = new Font("微软雅黑", 13f);
            label.Text = "测试文本测试文本测试文本测试文本测试文本";
            UIControls.Add(label);
            //
            progress = new UIProgress();
            progress.Location = new Point(300, 200);
            progress.Percentage = 20;
            progress.Size = new Size(600, 50);
            progress.Anchor = AnchorStyles.None;
            UIControls.Add(progress);
            //
            btnOut = new UIButton();
            btnOut.Size = new Size(300, 100);
            btnOut.Location = new Point(10, 20);
            btnOut.Dock = DockStyle.None;
            btnOut.UIParent = this;
            btnOut.Name = "out";
            btnOut.Text = btnOut.Name;
            btnOut.Font = new Font(btnOut.Font.FontFamily, 45f);
            btnOut.TextRenderingHint = TextRenderingHint.AntiAlias;
            btnOut.Click += (sender, e) => Console.WriteLine("单击out");
            UIControls.Add(btnOut);

            //
            btnInner2 = new UIButton();
            btnInner2.Size = new Size(50, 20);
            btnInner2.Location = new Point(55, 55);
            btnInner2.UIParent = btnOut;
            btnInner2.Name = "in2";
            btnInner2.Text = btnInner2.Name;
            btnInner2.Click += (sender, e) => MessageBox.Show("单击in2");
            btnOut.UIControls.Add(btnInner2);
            //
            btnInner = new UIButton();
            btnInner.Size = new Size(50, 20);
            btnInner.Location = new Point(5, 15);
            btnInner.UIParent = btnOut;
            btnInner.Name = "in";
            btnInner.Text = btnInner.Name;
            btnInner.Click += (sender, e) => Console.WriteLine("单击in");
            btnOut.UIControls.Add(btnInner);
            //
            marquee = new UIMarquee();
            marquee.Size = new Size(801, 4);
            marquee.Location = new Point(100, 200);
            marquee.BorderColor = Color.Transparent;
            marquee.BackColor = Color.Transparent;
            marquee.Dock = DockStyle.Bottom;
            marquee.ProgressColor = Color.DodgerBlue;
            UIControls.Add(marquee);
            marquee.SendToBack();
            //
            link = new UILink();
            link.Size = new Size(40, 15);
            link.Location = new Point(500, 10);
            link.Font = new Font("微软雅黑", 10f, GraphicsUnit.Point);
            link.Text = "换一张";
            UIControls.Add(link);
            //
            link2 = new UILink();
            link2.Size = new Size(40, 15);
            link2.Location = new Point(540, 10);
            link2.Text = "换一张";
            UIControls.Add(link2);
        }

        public void TestCore(FormBorderStyle border, IUIWindow target)
        {
            //初始化
            FormBorderStyle = border;
            btnOut.UIParent = target;

            //FindUIWindow
            Assert.AreEqual(btnOut.FindUIWindow(), target);
            Assert.AreEqual(btnInner.FindUIWindow(), target);
            Assert.AreEqual(target.FindUIWindow(), target);

            //FindUIChild
            Assert.AreEqual(target.FindUIChild(Point.Empty), null);
            Assert.AreEqual(target.FindUIChild(new Point(10, 20)), btnOut);
            Assert.AreEqual(target.FindUIChild(new Point(109, 69)), btnOut);
            Assert.AreEqual(target.FindUIChild(new Point(15, 35)), btnInner);
            Assert.AreEqual(target.FindUIChild(new Point(64, 54)), btnInner);
            //FindUIChild
            Assert.AreEqual(btnOut.FindUIChild(Point.Empty), null);
            Assert.AreEqual(btnOut.FindUIChild(new Point(5, 15)), btnInner);
            Assert.AreEqual(btnOut.FindUIChild(new Point(54, 34)), btnInner);
            //FindUIChild
            Assert.AreEqual(target.FindUIChild("in2"), btnInner2);
            //PointToClient
            Point p = new Point(15, 35);//window client
            Point sp = target.PointToScreen(p);
            Assert.AreEqual(target.PointToClient(sp), p);
            Assert.AreEqual(btnOut.PointToClient(sp), new Point(5, 15));
            Assert.AreEqual(btnInner.PointToClient(sp), Point.Empty);
            //PointToScreen
            Assert.AreEqual(target.PointToScreen(p), sp);
            Assert.AreEqual(btnOut.PointToScreen(new Point(5, 15)), sp);
            Assert.AreEqual(btnInner.PointToScreen(Point.Empty), sp);
            //PointToUIControl
            Assert.AreEqual(target.PointToUIControl(p), p);
            Assert.AreEqual(btnOut.PointToUIControl(p), new Point(5, 15));
            Assert.AreEqual(btnInner.PointToUIControl(p), Point.Empty);
            //PointToUIWindow
            Assert.AreEqual(target.PointToUIWindow(p), p);
            Assert.AreEqual(btnOut.PointToUIWindow(new Point(5, 15)), p);
            Assert.AreEqual(btnInner.PointToUIWindow(Point.Empty), p);
            //RectangleToClient
            Rectangle r = new Rectangle(15, 35, 10, 20);//window client
            Rectangle sr = target.RectangleToScreen(r);
            Assert.AreEqual(target.RectangleToClient(sr), r);
            Assert.AreEqual(btnOut.RectangleToClient(sr), new Rectangle(5, 15, 10, 20));
            Assert.AreEqual(btnInner.RectangleToClient(sr), new Rectangle(0, 0, 10, 20));
            //RectangleToScreen
            Assert.AreEqual(target.RectangleToScreen(r), sr);
            Assert.AreEqual(btnOut.RectangleToScreen(new Rectangle(5, 15, 10, 20)), sr);
            Assert.AreEqual(btnInner.RectangleToScreen(new Rectangle(0, 0, 10, 20)), sr);
            //RectangleToUIControl
            Assert.AreEqual(target.RectangleToUIControl(r), r);
            Assert.AreEqual(btnOut.RectangleToUIControl(r), new Rectangle(5, 15, 10, 20));
            Assert.AreEqual(btnInner.RectangleToUIControl(r), new Rectangle(0, 0, 10, 20));
            //RectangleToUIWindow
            Assert.AreEqual(target.RectangleToUIWindow(r), r);
            Assert.AreEqual(btnOut.RectangleToUIWindow(new Rectangle(5, 15, 10, 20)), r);
            Assert.AreEqual(btnInner.RectangleToUIWindow(new Rectangle(0, 0, 10, 20)), r);
            //
            btnOut.SendToBack();
            btnOut.BringToFront();
        }

        private void btnWithBorder_Click(object sender, EventArgs e)
        {
            TestCore(FormBorderStyle.Sizable, this);
        }

        private void btnNoBorder_Click(object sender, EventArgs e)
        {
            TestCore(FormBorderStyle.None, this);
        }

        private void btnWithBorder2_Click(object sender, EventArgs e)
        {
            TestCore(FormBorderStyle.Sizable, uiWinControl1);
        }

        private void btnNoBorder2_Click(object sender, EventArgs e)
        {
            TestCore(FormBorderStyle.None, uiWinControl1);
        }

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            image.AddFrame();
            image.AddFrame();
            image.AddFrame();
            image.AddFrame();
            image.AddFrame();
            image.AddFrame();
        }

        private void btnClearFrame_Click(object sender, EventArgs e)
        {
            image.ClearFrame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marquee.Stopped = !marquee.Stopped;
        }
    }
}
