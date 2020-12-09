using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace Calculator{
    public partial class GraphicPaint : Form{
        Graphics gr, g;
        Pen p = new Pen(Color.Blue, 2); Pen new_p = new Pen(Color.Black, 2);
        Bitmap bmp;
        Stack<Point> pointStack = new Stack<Point>(); Point[] pointList = new Point[4];
        private double[] dist = new double[4];
        public static Point p1, p2, p3, p4, p_1, p_2, p_3, p_4;
        Point p0 = new Point(163,132); Point _p = new Point();
        Vector2 v_i = new Vector2(71, 51); Vector2 v_j = new Vector2(93, 124); Vector2 v_k = new Vector2(124, 96);
        
        public GraphicPaint(){
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            imgForm();
            comboBox1.Enabled = false;
        }

        public void imgForm(){
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
        }

        //Vector3, Vector2,...

        
        private void btnPrl_Clicked(object sender, EventArgs e){ 
            try{
                for(int i=2; i>=0; i--)
                    pointList[i] = pointStack.Pop();
                btnPrl_Clicked(p,pointList);
            }
            catch (Exception){
                lblNotif.Text = "Mark Enough Points...";
            } 
        }

        ///     p2--------p4
        ///    /         /   
        ///   /         /
        ///  p1--------p3

        private void btnPrl_Clicked(Pen p, Point[] pointList){
            btnPrl_Clicked(p, pointList[0], pointList[1], pointList[2]);
        }

        private void btnPrl_Clicked(Pen p, Point p1, Point p2, Point p3){
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            g.DrawLine(p, p1, p2); g.DrawLine(p, p1, p3); g.DrawLine(p, p2, p4); g.DrawLine(p, p3, p4);
            pictureBox1.Image = bmp;
        }

        ///    p_2-------p_4
        ///    /|        /|
        ///   / |       / |
        /// p_1-------p_3 |
        ///  |  |      |  |
        ///  |  p2-----|--p4
        ///  | /       | /   
        ///  |/        |/
        ///  p1--------p3

        private void btnPrlp_Clicked(object sender, EventArgs e){ 
            try{
                for (int i = 3; i >= 0; i--)
                    pointList[i] = pointStack.Pop();
                btnPrlp_Clicked(p, pointList);
            }
            catch (Exception){
                lblNotif.Text = "Mark Enough Points...";
            } 
        }

        private void btnPrlp_Clicked(Pen p,Point[] pointList){
            btnPrlp_Clicked(p,pointList[0],pointList[1],pointList[2],pointList[3]);
        }

        private void btnPrlp_Clicked(Pen p, Point p1, Point p2, Point p3, Point p_1){
            Point p4 = new Point(p2.X+p3.X-p1.X, p2.Y+p3.Y-p1.Y);
            Point p1Top_1 = new Point(p_1.X - p1.X, p_1.Y - p1.Y);
            Point p_2 = AddPoint(p2, p1Top_1); Point p_3 = AddPoint(p3, p1Top_1); Point p_4 = AddPoint(p4, p1Top_1);
            //Point p_2 = new Point(p_1.X + p2.X - p1.X, p_1.Y + p2.Y - p1.Y); 
            //Point p_3 = new Point(p_1.X + p3.X - p1.X, p_1.Y + p3.Y - p1.Y); 
            //Point p_4 = new Point(p_2.X + p_3.X - p_1.X, p_2.Y + p_3.Y - p_1.Y);

            btnPrl_Clicked(p,p1,p2,p3); btnPrl_Clicked(p,p_1,p_2,p_3);
            g.DrawLine(p,p1,p_1); g.DrawLine(p,p2,p_2); g.DrawLine(p,p3,p_3); g.DrawLine(p,p4,p_4);
            listBox1.Items.Add("p1.X: " + p1.X + "   p1.Y: " + p1.Y); listBox1.Items.Add("p2.X: " + p2.X + "   p2.Y: " + p2.Y); listBox1.Items.Add("p3.X: " + p3.X + "   p3.Y: " + p3.Y); listBox1.Items.Add("p4.X: " + p4.X + "   p4.Y: " + p4.Y);
            listBox1.Items.Add("p_1.X: " + p_1.X + "   p_1.Y: " + p_1.Y); listBox1.Items.Add("p_2.X: " + p_2.X + "   p_2.Y: " + p_2.Y); listBox1.Items.Add("p_3.X: " + p_3.X + "   p_3.Y: " + p_3.Y); listBox1.Items.Add("p_4.X: " + p_4.X + "   p_4.Y: " + p_4.Y);
            comboBox1.Enabled = true;
            pictureBox1.Image = bmp;
        }

        private static Point AddPoint(Point p1, Point p2){
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        } 

        private void pictureBox1_Click(object sender, MouseEventArgs e){
            pointStack.Push(e.Location);
            gr.DrawEllipse(p,e.X,e.Y,2,2);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e){
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK){
                try{
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                catch(Exception){
                    lblNotif.Text = "Unavailable File...";
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e){
            SaveFileDialog save = new SaveFileDialog();
            save.CheckFileExists = false;
            save.CheckPathExists = true;
            save.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            save.InitialDirectory = @"C:\Users\tswizzle\Documents\HUST\oop\";

            DialogResult result = save.ShowDialog();
            if(result == DialogResult.OK){
                Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp,pictureBox1.ClientRectangle);
                bmp.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void mMove_MouseMove(object sender, MouseEventArgs e){
            _p = this.PointToClient(Cursor.Position);
            mouseStatus.Text = "X: " + _p.X + "   Y: " + _p.Y;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            int idx = ((ComboBox)sender).SelectedIndex;
            try{
                pointList[idx] = pointStack.Pop();
                imgForm(); listBox1.Items.Clear();
                Point p_2 = new Point(p_1.X + p2.X - p1.X, p_1.Y + p2.Y - p1.Y); Point p_3 = new Point(p_1.X + p3.X - p1.X, p_1.Y + p3.Y - p1.Y); Point p_4 = new Point(p_2.X + p_3.X - p_1.X, p_2.Y + p_3.Y - p_1.Y);
                btnPrlp_Clicked(new_p, pointList);
            }
            catch{
                lblNotif.Text = "Mark Enough Points...";
            }
        }

        private void GraphicPaint_Click(object sender, EventArgs e){

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e){
            pointStack.Push(e.Location);
            gr.DrawEllipse(p, e.X, e.Y, 2, 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e){
            
        }

        private void btnVol_Click(object sender, EventArgs e){
            txtBoxVol.Text = System.Convert.ToString(btnVol_Click(pointList[0],pointList[1],pointList[2],pointList[3],p0,v_i,v_j,v_k));
        }

        private double btnVol_Click(Point p1, Point p2, Point p3, Point p_1, Point p0, Vector2 v_i, Vector2 v_j, Vector2 v_k){
            Vector2 v12 = Coordination(p1, p2, p0, v_i, v_j); Vector2 v13 = Coordination(p1, p3, p0, v_i, v_j); Vector2 v1_1 = Coordination(p1, p_1, p0, v_i, v_j);
            return btnVol_Click(new Vector3(v12.X,v12.Y,0), new Vector3(v13.X,v13.Y,0), new Vector3(v1_1.X,v1_1.Y,(p_1.Y-p1.Y)/v_k.Y));
        }

        private double btnVol_Click(Vector3 v1, Vector3 v2, Vector3 v3){
            return Math.Abs(Vector3.Dot(v1, Vector3.Cross(v2, v3)));
        }

        private void btnSur_Click(object sender, EventArgs e){
            txtBoxSur.Text = System.Convert.ToString(btnSur_Click(pointList[0], pointList[1], pointList[2], pointList[3], p0, v_i, v_j, v_k));
        }

        private double btnSur_Click(Point p1, Point p2, Point p3, Point p_1, Point p0, Vector2 v_i, Vector2 v_j, Vector2 v_k){
            Vector2 v12 = Coordination(p1, p2, p0, v_i, v_j); Vector2 v13 = Coordination(p1, p3, p0, v_i, v_j); Vector2 v1_1 = Coordination(p1, p_1, p0, v_i, v_j);
            Vector3 _v12 = new Vector3(v12.X, v12.Y, 0); Vector3 _v13 = new Vector3(v13.X, v13.Y, 0); Vector3 _v1_1 = new Vector3(v1_1.X, v1_1.Y, (p_1.Y - p1.Y) / v_k.Y);
            return 2 * (Vector3.VectorLength(Vector3.Cross(_v12, _v13)) + Vector3.VectorLength(Vector3.Cross(_v12, _v1_1)) + Vector3.VectorLength(Vector3.Cross(_v13, _v1_1)));
        }

        public Vector2 Coordination(Point a, Point b, Point p0, Vector2 v_a, Vector2 v_b){
            Vector2 ab = new Vector2(b.X - a.X, b.Y - a.Y);
            var coo = Linear2Equations.btnSolve_Click(v_a.X,v_a.Y,v_b.X,v_b.Y,ab.X,ab.Y);
            return new Vector2((double)coo[0], (double)coo[1]);
        }
    }
}
